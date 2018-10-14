using HRWebApplication.Common;
using HRWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HRWebApplication.Controllers
{
    [CustomAuthorize(Roles = "Superuser, Manager")]
    public class UserController : Controller
    {
        private HrContext db = new HrContext();

        public ActionResult Index()
        {
            var user = (from u in db.User
                        join ur in db.UserRole on u.Id equals ur.UserId
                        join r in db.Role on ur.RoleId equals r.Id
                        select new UserViewModel
                        {
                            Id = u.Id,
                            FullName = u.FullName,
                            UserName = u.UserName,
                            Email = u.Email,
                            Role = r.Name,
                            RoleId = r.Id
                        });

            return View(user.ToList());
        }

        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var userVM = (from u in db.User
                        join ur in db.UserRole on u.Id equals ur.UserId
                        join r in db.Role on ur.RoleId equals r.Id
                        where u.Id == id
                        select new UserViewModel
                        {
                            Id = u.Id,
                            FullName = u.FullName,
                            UserName = u.UserName,
                            Email = u.Email,
                            Role = r.Name,
                            RoleId = r.Id
                        }).FirstOrDefault();

            UserViewModel userModels = userVM;

            if (userModels == null)
            {
                return HttpNotFound();
            }

            ViewBag.listRole = new SelectList(db.Role.OrderBy(x => x.Name).ToList(), "Id", "Name");

            return View(userModels);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,FullName,UserName,Email,RoleId")] UserViewModel userModels)
        {
            if (ModelState.IsValid)
            {
                var user = new UserModels() { Id = userModels.Id, FullName = userModels.FullName, Email = userModels.Email };
                var userRole = new UserRoleModels() { UserId = userModels.Id, RoleId = userModels.RoleId };
                using (var database = new HrContext())
                {
                    database.User.Attach(user);
                    database.Entry(user).Property(x => x.FullName).IsModified = true;
                    database.Entry(user).Property(x => x.Email).IsModified = true;

                    database.UserRole.Attach(userRole);
                    database.Entry(userRole).Property(x => x.RoleId).IsModified = true;

                    await database.SaveChangesAsync();
                }

                return RedirectToAction("Index");
            }
            ViewBag.listRole = new SelectList(db.Role.OrderBy(x => x.Name).ToList(), "Id", "Name");
            return View(userModels);
        }
    }
}