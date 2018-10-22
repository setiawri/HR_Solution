using HRWebApplication.Common;
using HRWebApplication.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HRWebApplication.Controllers
{
    [Authorize]
    public class RoleController : Controller
    {
        private HrContext db = new HrContext();
        private ApplicationRoleManager _roleManager;

        public RoleController()
        {
        }

        public RoleController(ApplicationRoleManager roleManager)
        {
            RoleManager = roleManager;
        }

        public ApplicationRoleManager RoleManager
        {
            get
            {
                return _roleManager ?? HttpContext.GetOwinContext().Get<ApplicationRoleManager>();
            }
            private set
            {
                _roleManager = value;
            }
        }

        // GET: Role
        public ActionResult Index()
        {
            Permissions p = new Permissions();
            bool auth = p.isGranted(User.Identity.Name, this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + this.ControllerContext.RouteData.Values["action"].ToString());
            if (!auth) { return new ViewResult() { ViewName = "Unauthorized" }; }
            else
            {
                List<RoleViewModels> list = new List<RoleViewModels>();
                foreach (var role in RoleManager.Roles.OrderBy(x => x.Name))
                {
                    list.Add(new RoleViewModels(role));
                }
                return View(list);
            }
        }

        public ActionResult Create()
        {
            Permissions p = new Permissions();
            bool auth = p.isGranted(User.Identity.Name, this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + this.ControllerContext.RouteData.Values["action"].ToString());
            if (!auth) { return new ViewResult() { ViewName = "Unauthorized" }; }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<ActionResult> Create(RoleViewModels model)
        {
            var role = new ApplicationRole() { Name = model.Name };
            await RoleManager.CreateAsync(role);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Edit(string id)
        {
            Permissions p = new Permissions();
            bool auth = p.isGranted(User.Identity.Name, this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + this.ControllerContext.RouteData.Values["action"].ToString());
            if (!auth) { return new ViewResult() { ViewName = "Unauthorized" }; }
            else
            {
                var role = await RoleManager.FindByIdAsync(id);
                return View(new RoleViewModels(role));
            }
        }

        [HttpPost]
        public async Task<ActionResult> Edit(RoleViewModels model)
        {
            var role = new ApplicationRole() { Id = model.Id, Name = model.Name };
            await RoleManager.UpdateAsync(role);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Details(string id)
        {
            var role = await RoleManager.FindByIdAsync(id);
            return View(new RoleViewModels(role));
        }

        public async Task<ActionResult> Delete(string id)
        {
            Permissions p = new Permissions();
            bool auth = p.isGranted(User.Identity.Name, this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + this.ControllerContext.RouteData.Values["action"].ToString());
            if (!auth) { return new ViewResult() { ViewName = "Unauthorized" }; }
            else
            {
                var role = await RoleManager.FindByIdAsync(id);
                return View(new RoleViewModels(role));
            }
        }

        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            var role = await RoleManager.FindByIdAsync(id);
            await RoleManager.DeleteAsync(role);
            return RedirectToAction("Index");
        }

        public ActionResult Manage(string id)
        {
            Permissions p = new Permissions();
            bool auth = p.isGranted(User.Identity.Name, this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + this.ControllerContext.RouteData.Values["action"].ToString());
            if (!auth) { return new ViewResult() { ViewName = "Unauthorized" }; }
            else
            {
                ViewBag.Id = id;
                var data = (from m in db.MasterMenu
                            join a in db.Access
                                .Join(db.Role, x => x.UserAccountRoles_Id.ToString(), y => y.Id, (x, y) => new { WebMenuAccess = x.WebMenuAccess, RoleName = y.Name, RoleId = y.Id })
                                .Where(x => x.RoleId == id)
                            on m.WebMenuAccess equals a.WebMenuAccess into joined
                            from access in joined.DefaultIfEmpty()
                            select new AccessViewModels
                            {
                                MenuOrder = m.MenuOrder,
                                MenuName = m.MenuName,
                                WebMenuAccess = m.WebMenuAccess,
                                RoleName = (access.RoleName == null) ? string.Empty : access.RoleName
                            });

                return View(data.ToList());
            }
        }

        public JsonResult EnableMenu(string WebMenuAccess, Guid IdRole)
        {
            AccessModels am = new AccessModels();
            am.Id = Guid.NewGuid();
            am.UserAccountRoles_Id = IdRole;
            am.UserAccountAccess_EnumId = 0;
            am.WebMenuAccess = WebMenuAccess;
            db.Access.Add(am);
            db.SaveChanges();

            return Json(new { status = "200" }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult DisableMenu(string WebMenuAccess, Guid IdRole)
        {
            var data = (from a in db.Access
                        where a.WebMenuAccess == WebMenuAccess && a.UserAccountRoles_Id == IdRole
                        select a).Single();
            AccessModels am = data;
            db.Access.Remove(am);
            db.SaveChanges();

            return Json(new { status = "200" }, JsonRequestBehavior.AllowGet);
        }
    }
}