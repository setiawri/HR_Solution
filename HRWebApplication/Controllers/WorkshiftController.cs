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
    public class WorkshiftController : Controller
    {
        private HrContext db = new HrContext();

        // GET: Workshift
        public async Task<ActionResult> Index()
        {
            Permissions p = new Permissions();
            bool auth = p.isGranted(User.Identity.Name, this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + this.ControllerContext.RouteData.Values["action"].ToString());
            if (!auth) { return new ViewResult() { ViewName = "Unauthorized" }; }
            else
            {
                var data = (from w in db.Workshift
                            join c in db.Clients on w.Clients_Id equals c.Id
                            join u in db.User on w.UserAccounts_Id.ToString() equals u.Id
                            join wt in db.WsTemplate on w.WorkshiftTemplates_Id equals wt.Id
                            join wc in db.WsCategory on w.WorkshiftCategories_Id equals wc.Id
                            //orderby c.CompanyName, u.FullName
                            select new WorkshiftViewModels
                            {
                                Id = w.Id,
                                Client = c.CompanyName,
                                Employee = u.FullName,
                                Name = w.Name,
                                TemplateName = wt.Name,
                                Category = wc.Name,
                                DayOfWeek = ((Common.Master.DayOfWeek)w.DayOfWeek).ToString(),
                                Start = w.Start.ToString(),
                                DurationMinutes = w.DurationMinutes,
                                Active = w.Active
                            });

                return View(await data.ToListAsync());
            }
        }

        // GET: Workshift/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkshiftModels workshiftModels = await db.Workshift.FindAsync(id);
            if (workshiftModels == null)
            {
                return HttpNotFound();
            }
            return View(workshiftModels);
        }

        public JsonResult LoadTemplates(Guid id)
        {
            //var result = new SelectList(db.WsTemplate.Where(x => x.Clients_Id == id).OrderBy(x => x.Name).ToList(), "Id", "Name");
            List<WorkshiftTemplateViewModels> data = (from t in db.WsTemplate
                                                      where t.Clients_Id == id
                                                      orderby t.DayOfWeek, t.Start
                                                      select new WorkshiftTemplateViewModels
                                                      {
                                                          Id = t.Id,
                                                          Name = t.Name,
                                                          DayOfWeek = ((Master.DayOfWeek)t.DayOfWeek).ToString(),
                                                          Start = t.Start.ToString().Substring(0, 5),
                                                          Duration = t.DurationMinutes
                                                      }).ToList();
            List<object> newList = new List<object>(); //create anonymous object list
            foreach (var item in data)
            {
                newList.Add(new
                {
                    Id = item.Id,
                    Name = item.DayOfWeek + " ( " + item.Start + " - " + DateTime.Parse(item.Start).AddMinutes(item.Duration).ToString("HH:mm") + " ) " + item.Name
                });
            }
            var result = new SelectList(newList, "Id", "Name");

            return Json(new { result }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetTemplates(Guid id)
        {
            var result = db.WsTemplate.Where(x => x.Id == id).FirstOrDefault();
            string start = result.Start.ToString().Substring(0, 5);
            string stop = result.Start.Add(TimeSpan.FromMinutes(result.DurationMinutes)).ToString().Substring(0, 5);
            return Json(new { result, start, stop }, JsonRequestBehavior.AllowGet);
        }

        // GET: Workshift/Create
        public ActionResult Create()
        {
            Permissions p = new Permissions();
            bool auth = p.isGranted(User.Identity.Name, this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + this.ControllerContext.RouteData.Values["action"].ToString());
            if (!auth) { return new ViewResult() { ViewName = "Unauthorized" }; }
            else
            {
                ViewBag.listClient = new SelectList(db.Clients.Where(x => x.Active == true).OrderBy(x => x.CompanyName).ToList(), "Id", "CompanyName");
                ViewBag.listEmployee = new SelectList(db.User.OrderBy(x => x.FullName).ToList(), "Id", "FullName");
                ViewBag.listCategory = new SelectList(db.WsCategory.Where(x => x.Active == true).OrderBy(x => x.Name).ToList(), "Id", "Name");
                var dow = from Common.Master.DayOfWeek d in Enum.GetValues(typeof(Common.Master.DayOfWeek))
                          select new { Id = (byte)d, Name = d.ToString() };
                ViewBag.listDOW = new SelectList(dow, "Id", "Name");
                return View();
            }
        }

        // POST: Workshift/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,Clients_Id,WorkshiftCategories_Id,DayOfWeek,Start,DurationMinutes,Notes,Active,UserAccounts_Id,WorkshiftTemplates_Id")] WorkshiftModels workshiftModels)
        {
            int check = (from ws in db.Workshift
                         where ws.Clients_Id == workshiftModels.Clients_Id
                         && ws.WorkshiftCategories_Id == workshiftModels.WorkshiftCategories_Id
                         && ws.WorkshiftTemplates_Id == workshiftModels.WorkshiftTemplates_Id
                         && ws.Name == workshiftModels.Name
                         && ws.UserAccounts_Id == workshiftModels.UserAccounts_Id
                         && ws.DayOfWeek == workshiftModels.DayOfWeek
                         && ws.Start == workshiftModels.Start
                         && ws.DurationMinutes == workshiftModels.DurationMinutes
                         select ws).Count();
            if (check > 0)
            {
                ModelState.AddModelError("Duplicate", "Data Workshift already exist!");
            }

            if (ModelState.IsValid)
            {
                workshiftModels.Id = Guid.NewGuid();
                db.Workshift.Add(workshiftModels);
                await db.SaveChangesAsync();
                return RedirectToAction("Create");
            }

            ViewBag.listClient = new SelectList(db.Clients.Where(x => x.Active == true).OrderBy(x => x.CompanyName).ToList(), "Id", "CompanyName");
            ViewBag.listEmployee = new SelectList(db.User.OrderBy(x => x.FullName).ToList(), "Id", "FullName");
            ViewBag.listCategory = new SelectList(db.WsCategory.Where(x => x.Active == true).OrderBy(x => x.Name).ToList(), "Id", "Name");
            var dow = from Common.Master.DayOfWeek d in Enum.GetValues(typeof(Common.Master.DayOfWeek))
                      select new { Id = (byte)d, Name = d.ToString() };
            ViewBag.listDOW = new SelectList(dow, "Id", "Name");
            return View(workshiftModels);
        }

        // GET: Workshift/Edit/5
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
                WorkshiftModels workshiftModels = await db.Workshift.FindAsync(id);
                if (workshiftModels == null)
                {
                    return HttpNotFound();
                }

                ViewBag.listClient = new SelectList(db.Clients.Where(x => x.Active == true).OrderBy(x => x.CompanyName).ToList(), "Id", "CompanyName");
                ViewBag.listEmployee = new SelectList(db.User.OrderBy(x => x.FullName).ToList(), "Id", "FullName");
                ViewBag.listCategory = new SelectList(db.WsCategory.Where(x => x.Active == true).OrderBy(x => x.Name).ToList(), "Id", "Name");
                var dow = from Common.Master.DayOfWeek d in Enum.GetValues(typeof(Common.Master.DayOfWeek))
                          select new { Id = (byte)d, Name = d.ToString() };
                ViewBag.listDOW = new SelectList(dow, "Id", "Name");
                ViewBag.listTemplate = new SelectList(db.WsTemplate.Where(x => x.Clients_Id == workshiftModels.Clients_Id).OrderBy(x => x.Name).ToList(), "Id", "Name");
                return View(workshiftModels);
            }
        }

        // POST: Workshift/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Clients_Id,WorkshiftCategories_Id,DayOfWeek,Start,DurationMinutes,Notes,Active,UserAccounts_Id,WorkshiftTemplates_Id")] WorkshiftModels workshiftModels)
        {
            int check = (from ws in db.Workshift
                         where ws.Clients_Id == workshiftModels.Clients_Id
                         && ws.WorkshiftCategories_Id == workshiftModels.WorkshiftCategories_Id
                         && ws.WorkshiftTemplates_Id == workshiftModels.WorkshiftTemplates_Id
                         && ws.Name == workshiftModels.Name
                         && ws.UserAccounts_Id == workshiftModels.UserAccounts_Id
                         && ws.DayOfWeek == workshiftModels.DayOfWeek
                         && ws.Start == workshiftModels.Start
                         && ws.DurationMinutes == workshiftModels.DurationMinutes
                         select ws).Count();
            if (check > 0)
            {
                ModelState.AddModelError("Duplicate", "Data Workshift already exist!");
            }

            if (ModelState.IsValid)
            {
                db.Entry(workshiftModels).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.listClient = new SelectList(db.Clients.Where(x => x.Active == true).OrderBy(x => x.CompanyName).ToList(), "Id", "CompanyName");
            ViewBag.listEmployee = new SelectList(db.User.OrderBy(x => x.FullName).ToList(), "Id", "FullName");
            ViewBag.listCategory = new SelectList(db.WsCategory.Where(x => x.Active == true).OrderBy(x => x.Name).ToList(), "Id", "Name");
            var dow = from Common.Master.DayOfWeek d in Enum.GetValues(typeof(Common.Master.DayOfWeek))
                      select new { Id = (byte)d, Name = d.ToString() };
            ViewBag.listDOW = new SelectList(dow, "Id", "Name");
            ViewBag.listTemplate = new SelectList(db.WsTemplate.Where(x => x.Clients_Id == workshiftModels.Clients_Id).OrderBy(x => x.Name).ToList(), "Id", "Name");
            return View(workshiftModels);
        }

        // GET: Workshift/Delete/5
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
                //WorkshiftModels workshiftModels = await db.Workshift.FindAsync(id);
                //if (workshiftModels == null)
                //{
                //    return HttpNotFound();
                //}
                //return View(workshiftModels);
                var data = (from w in db.Workshift
                            join c in db.Clients on w.Clients_Id equals c.Id
                            join u in db.User on w.UserAccounts_Id.ToString() equals u.Id
                            join wt in db.WsTemplate on w.WorkshiftTemplates_Id equals wt.Id
                            join wc in db.WsCategory on w.WorkshiftCategories_Id equals wc.Id
                            where w.Id == id
                            select new WorkshiftViewModels
                            {
                                Id = w.Id,
                                Client = c.CompanyName,
                                Employee = u.FullName,
                                Name = w.Name,
                                TemplateName = wt.Name,
                                Category = wc.Name,
                                DayOfWeek = ((Common.Master.DayOfWeek)w.DayOfWeek).ToString(),
                                Start = w.Start.ToString(),
                                DurationMinutes = w.DurationMinutes,
                                Active = w.Active
                            });
                if (data == null) { return HttpNotFound(); }
                return View(await data.SingleAsync());
            }
        }

        // POST: Workshift/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            WorkshiftModels workshiftModels = await db.Workshift.FindAsync(id);
            db.Workshift.Remove(workshiftModels);
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
