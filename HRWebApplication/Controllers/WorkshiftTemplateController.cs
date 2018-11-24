using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HRWebApplication.Models;
using HRWebApplication.Common;

namespace HRWebApplication.Controllers
{
    [Authorize]
    public class WorkshiftTemplateController : Controller
    {
        private HrContext db = new HrContext();

        // GET: WorkshiftTemplate
        public async Task<ActionResult> Index()
        {
            Permissions p = new Permissions();
            bool auth = p.isGranted(User.Identity.Name, this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + this.ControllerContext.RouteData.Values["action"].ToString());
            if (!auth) { return new ViewResult() { ViewName = "Unauthorized" }; }
            else
            {
                var data = (from wt in db.WsTemplate
                            join wc in db.WsCategory on wt.WorkshiftCategories_Id equals wc.Id
                            join c in db.Clients on wt.Clients_Id equals c.Id
                            orderby wt.Name
                            select new WorkshiftTemplateViewModels
                            {
                                Id = wt.Id,
                                Name = wt.Name,
                                Client = c.CompanyName,
                                WorkshiftCategory = wc.Name,
                                DayOfWeek = ((Common.Master.DayOfWeek)wt.DayOfWeek).ToString(),
                                Start = wt.Start.ToString(),
                                Duration = wt.DurationMinutes,
                                Active = wt.Active
                            });

                return View(await data.ToListAsync());
            }
        }

        // GET: WorkshiftTemplate/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkshiftTemplateModels workshiftTemplateModels = await db.WsTemplate.FindAsync(id);
            if (workshiftTemplateModels == null)
            {
                return HttpNotFound();
            }
            return View(workshiftTemplateModels);
        }

        // GET: WorkshiftTemplate/Create
        public ActionResult Create()
        {
            Permissions p = new Permissions();
            bool auth = p.isGranted(User.Identity.Name, this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + this.ControllerContext.RouteData.Values["action"].ToString());
            if (!auth) { return new ViewResult() { ViewName = "Unauthorized" }; }
            else
            {
                ViewBag.listClient = new SelectList(db.Clients.Where(x => x.Active == true).OrderBy(x => x.CompanyName).ToList(), "Id", "CompanyName");
                ViewBag.listCategory = new SelectList(db.WsCategory.Where(x => x.Active == true).OrderBy(x => x.Name).ToList(), "Id", "Name");
                var dow = from Common.Master.DayOfWeek d in Enum.GetValues(typeof(Common.Master.DayOfWeek))
                          select new { Id = (byte)d, Name = d.ToString() };
                ViewBag.listDOW = new SelectList(dow, "Id", "Name");
                return View();
            }
        }

        // POST: WorkshiftTemplate/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,Clients_Id,WorkshiftCategories_Id,DayOfWeek,Start,DurationMinutes,Notes,Active")] WorkshiftTemplateModels workshiftTemplateModels)
        {
            int check = (from wt in db.WsTemplate
                         where wt.Name == workshiftTemplateModels.Name
                         && wt.Clients_Id == workshiftTemplateModels.Clients_Id
                         && wt.WorkshiftCategories_Id == workshiftTemplateModels.WorkshiftCategories_Id
                         && wt.DayOfWeek == workshiftTemplateModels.DayOfWeek
                         && wt.Start == workshiftTemplateModels.Start
                         && wt.DurationMinutes == workshiftTemplateModels.DurationMinutes
                         select wt).Count();
            if (check > 0)
            {
                ModelState.AddModelError("Duplicate", "Data Workshift Templates already exist!");
            }

            if (ModelState.IsValid)
            {
                workshiftTemplateModels.Id = Guid.NewGuid();
                db.WsTemplate.Add(workshiftTemplateModels);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.listClient = new SelectList(db.Clients.Where(x => x.Active == true).OrderBy(x => x.CompanyName).ToList(), "Id", "CompanyName");
            ViewBag.listCategory = new SelectList(db.WsCategory.Where(x => x.Active == true).OrderBy(x => x.Name).ToList(), "Id", "Name");
            var dow = from Common.Master.DayOfWeek d in Enum.GetValues(typeof(Common.Master.DayOfWeek))
                      select new { Id = (byte)d, Name = d.ToString() };
            ViewBag.listDOW = new SelectList(dow, "Id", "Name");
            return View(workshiftTemplateModels);
        }

        // GET: WorkshiftTemplate/Edit/5
        public async Task<ActionResult> Edit(Guid? id)
        {
            Permissions p = new Permissions();
            bool auth = p.isGranted(User.Identity.Name, this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + this.ControllerContext.RouteData.Values["action"].ToString());
            if (!auth) { return new ViewResult() { ViewName = "Unauthorized" }; }
            else
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                WorkshiftTemplateModels workshiftTemplateModels = await db.WsTemplate.FindAsync(id);
                if (workshiftTemplateModels == null)
                {
                    return HttpNotFound();
                }

                ViewBag.listClient = new SelectList(db.Clients.Where(x => x.Active == true).OrderBy(x => x.CompanyName).ToList(), "Id", "CompanyName");
                ViewBag.listCategory = new SelectList(db.WsCategory.Where(x => x.Active == true).OrderBy(x => x.Name).ToList(), "Id", "Name");
                var dow = from Common.Master.DayOfWeek d in Enum.GetValues(typeof(Common.Master.DayOfWeek))
                          select new { Id = (byte)d, Name = d.ToString() };
                ViewBag.listDOW = new SelectList(dow, "Id", "Name");
                return View(workshiftTemplateModels);
            }
        }

        // POST: WorkshiftTemplate/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Clients_Id,WorkshiftCategories_Id,DayOfWeek,Start,DurationMinutes,Notes,Active")] WorkshiftTemplateModels workshiftTemplateModels)
        {
            int check = (from wt in db.WsTemplate
                         where wt.Name == workshiftTemplateModels.Name
                         && wt.Clients_Id == workshiftTemplateModels.Clients_Id
                         && wt.WorkshiftCategories_Id == workshiftTemplateModels.WorkshiftCategories_Id
                         && wt.DayOfWeek == workshiftTemplateModels.DayOfWeek
                         && wt.Start == workshiftTemplateModels.Start
                         && wt.DurationMinutes == workshiftTemplateModels.DurationMinutes
                         select wt).Count();
            if (check > 0)
            {
                ModelState.AddModelError("Duplicate", "Data Workshift Templates already exist!");
            }

            if (ModelState.IsValid)
            {
                db.Entry(workshiftTemplateModels).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.listClient = new SelectList(db.Clients.Where(x => x.Active == true).OrderBy(x => x.CompanyName).ToList(), "Id", "CompanyName");
            ViewBag.listCategory = new SelectList(db.WsCategory.Where(x => x.Active == true).OrderBy(x => x.Name).ToList(), "Id", "Name");
            var dow = from Common.Master.DayOfWeek d in Enum.GetValues(typeof(Common.Master.DayOfWeek))
                      select new { Id = (byte)d, Name = d.ToString() };
            ViewBag.listDOW = new SelectList(dow, "Id", "Name");
            return View(workshiftTemplateModels);
        }

        // GET: WorkshiftTemplate/Delete/5
        public async Task<ActionResult> Delete(Guid? id)
        {
            Permissions p = new Permissions();
            bool auth = p.isGranted(User.Identity.Name, this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + this.ControllerContext.RouteData.Values["action"].ToString());
            if (!auth) { return new ViewResult() { ViewName = "Unauthorized" }; }
            else
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                //WorkshiftTemplateModels workshiftTemplateModels = await db.WsTemplate.FindAsync(id);
                //if (workshiftTemplateModels == null)
                //{
                //    return HttpNotFound();
                //}
                //return View(workshiftTemplateModels);
                var data = (from wt in db.WsTemplate
                            join wc in db.WsCategory on wt.WorkshiftCategories_Id equals wc.Id
                            join c in db.Clients on wt.Clients_Id equals c.Id
                            where wt.Id == id
                            select new WorkshiftTemplateViewModels
                            {
                                Id = wt.Id,
                                Name = wt.Name,
                                Client = c.CompanyName,
                                WorkshiftCategory = wc.Name,
                                DayOfWeek = ((Common.Master.DayOfWeek)wt.DayOfWeek).ToString(),
                                Start = wt.Start.ToString(),
                                Duration = wt.DurationMinutes,
                                Active = wt.Active
                            });
                if (data == null) { return HttpNotFound(); }
                return View(await data.SingleAsync());
            }
        }

        // POST: WorkshiftTemplate/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            WorkshiftTemplateModels workshiftTemplateModels = await db.WsTemplate.FindAsync(id);
            db.WsTemplate.Remove(workshiftTemplateModels);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
