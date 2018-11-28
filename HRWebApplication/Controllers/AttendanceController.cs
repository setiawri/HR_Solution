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
    public class AttendanceController : Controller
    {
        private HrContext db = new HrContext();

        // GET: Attendance
        public async Task<ActionResult> Index()
        {
            Permissions p = new Permissions();
            bool auth = p.isGranted(User.Identity.Name, this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + this.ControllerContext.RouteData.Values["action"].ToString());
            if (!auth) { return new ViewResult() { ViewName = "Unauthorized" }; }
            else
            {
                var result = (from a in db.Attendance
                              join u in db.User on a.UserAccounts_Id.ToString() equals u.Id
                              join c in db.Clients on a.Clients_Id equals c.Id
                              join w in db.Workshift on a.Workshifts_Id equals w.Id
                              where a.PayrollItems_Id == null
                              orderby u.FullName, c.CompanyName
                              select new AttendanceViewModels
                              {
                                  Id = a.Id,
                                  Employee = u.FullName,
                                  Client = c.CompanyName,
                                  Workshift = w.Name,
                                  Day = ((Common.Master.DayOfWeek)w.DayOfWeek).ToString(),
                                  Start = a.Workshifts_Start.ToString(),
                                  Duration = a.Workshifts_DurationMinutes,
                                  Hours = (a.Workshifts_DurationMinutes / 60).ToString(),
                                  Notes = a.Notes,
                                  Approved = a.Approved,
                                  Status = a.Approved ? "Approved" : "Rejected"
                              });
                return View(await result.ToListAsync());
            }
        }

        // GET: Attendance/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AttendanceModels attendanceModels = await db.Attendance.FindAsync(id);
            if (attendanceModels == null)
            {
                return HttpNotFound();
            }
            return View(attendanceModels);
        }

        public JsonResult LoadWorkshifts(Guid id_emp, Guid id_client)
        {
            var result = new SelectList(db.Workshift.Where(x => x.UserAccounts_Id == id_emp && x.Clients_Id == id_client).OrderBy(x => x.Name).ToList(), "Id", "Name");
            return Json(new { result }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetTime(Guid id)
        {
            var result = (from w in db.Workshift
                          where w.Id == id
                          select w).FirstOrDefault();
            
            string date_in = DateTime.Now.ToShortDateString() + " " + result.Start.ToString().Substring(0, 5);
            string date_out = DateTime.Now.ToShortDateString() + " " + result.Start.Add(TimeSpan.FromMinutes(result.DurationMinutes)).ToString().Substring(0, 5);

            return Json(new { result, date_in, date_out }, JsonRequestBehavior.AllowGet);
        }

        // GET: Attendance/Create
        public ActionResult Create()
        {
            Permissions p = new Permissions();
            bool auth = p.isGranted(User.Identity.Name, this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + this.ControllerContext.RouteData.Values["action"].ToString());
            if (!auth) { return new ViewResult() { ViewName = "Unauthorized" }; }
            else
            {
                ViewBag.listClient = new SelectList(db.Clients.Where(x => x.Active == true).OrderBy(x => x.CompanyName).ToList(), "Id", "CompanyName");
                ViewBag.listEmployee = new SelectList(db.User.OrderBy(x => x.FullName).ToList(), "Id", "FullName");
                ViewBag.listAttStatus = new SelectList(db.AttStatus.Where(x => x.Active == true).OrderBy(x => x.Name).ToList(), "Id", "Name");
                return View();
            }
        }

        // POST: Attendance/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,UserAccounts_Id,TimestampIn,TimestampOut,Notes,Flag1,Flag2,Approved,Workshifts_DayOfWeek,Workshifts_Start,Workshifts_DurationMinutes,EffectiveTimestampIn,EffectiveTimestampOut,Clients_Id,Rejected,PayrollItems_Id,AttendanceStatuses_Id,Workshifts_Id,AttendancePayRates_Id,AttendancePayRates_Amount")] AttendanceModels attendanceModels)
        {
            if (ModelState.IsValid)
            {
                attendanceModels.Id = Guid.NewGuid();
                attendanceModels.Workshifts_Start = attendanceModels.EffectiveTimestampIn;
                attendanceModels.Workshifts_DurationMinutes = (int)attendanceModels.EffectiveTimestampOut.Subtract(attendanceModels.EffectiveTimestampIn).TotalMinutes;
                db.Attendance.Add(attendanceModels);
                await db.SaveChangesAsync();
                return RedirectToAction("Create");
            }

            ViewBag.listClient = new SelectList(db.Clients.Where(x => x.Active == true).OrderBy(x => x.CompanyName).ToList(), "Id", "CompanyName");
            ViewBag.listEmployee = new SelectList(db.User.OrderBy(x => x.FullName).ToList(), "Id", "FullName");
            ViewBag.listAttStatus = new SelectList(db.AttStatus.Where(x => x.Active == true).OrderBy(x => x.Name).ToList(), "Id", "Name");
            return View(attendanceModels);
        }

        // GET: Attendance/Edit/5
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
                AttendanceModels attendanceModels = await db.Attendance.FindAsync(id);
                if (attendanceModels == null)
                {
                    return HttpNotFound();
                }

                ViewBag.listClient = new SelectList(db.Clients.Where(x => x.Active == true).OrderBy(x => x.CompanyName).ToList(), "Id", "CompanyName");
                ViewBag.listEmployee = new SelectList(db.User.OrderBy(x => x.FullName).ToList(), "Id", "FullName");
                ViewBag.listAttStatus = new SelectList(db.AttStatus.Where(x => x.Active == true).OrderBy(x => x.Name).ToList(), "Id", "Name");
                ViewBag.listWorkshift = new SelectList(db.Workshift.Where(x => x.UserAccounts_Id == attendanceModels.UserAccounts_Id && x.Clients_Id == attendanceModels.Clients_Id).OrderBy(x => x.Name).ToList(), "Id", "Name");
                return View(attendanceModels);
            }
        }

        // POST: Attendance/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,UserAccounts_Id,TimestampIn,TimestampOut,Notes,Flag1,Flag2,Approved,Workshifts_DayOfWeek,Workshifts_Start,Workshifts_DurationMinutes,EffectiveTimestampIn,EffectiveTimestampOut,Clients_Id,Rejected,PayrollItems_Id,AttendanceStatuses_Id,Workshifts_Id,AttendancePayRates_Id,AttendancePayRates_Amount")] AttendanceModels attendanceModels)
        {
            if (ModelState.IsValid)
            {
                attendanceModels.Workshifts_Start = attendanceModels.EffectiveTimestampIn;
                attendanceModels.Workshifts_DurationMinutes = (int)attendanceModels.EffectiveTimestampOut.Subtract(attendanceModels.EffectiveTimestampIn).TotalMinutes;
                db.Entry(attendanceModels).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.listClient = new SelectList(db.Clients.Where(x => x.Active == true).OrderBy(x => x.CompanyName).ToList(), "Id", "CompanyName");
            ViewBag.listEmployee = new SelectList(db.User.OrderBy(x => x.FullName).ToList(), "Id", "FullName");
            ViewBag.listAttStatus = new SelectList(db.AttStatus.Where(x => x.Active == true).OrderBy(x => x.Name).ToList(), "Id", "Name");
            ViewBag.listWorkshift = new SelectList(db.Workshift.Where(x => x.UserAccounts_Id == attendanceModels.UserAccounts_Id && x.Clients_Id == attendanceModels.Clients_Id).OrderBy(x => x.Name).ToList(), "Id", "Name");
            return View(attendanceModels);
        }

        // GET: Attendance/Delete/5
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
                var result = (from a in db.Attendance
                              join u in db.User on a.UserAccounts_Id.ToString() equals u.Id
                              join c in db.Clients on a.Clients_Id equals c.Id
                              join w in db.Workshift on a.Workshifts_Id equals w.Id
                              where a.Id == id
                              select new AttendanceViewModels
                              {
                                  Id = a.Id,
                                  Employee = u.FullName,
                                  Client = c.CompanyName,
                                  Workshift = w.Name,
                                  Day = ((Common.Master.DayOfWeek)w.DayOfWeek).ToString(),
                                  Start = w.Start.ToString(),
                                  Duration = w.DurationMinutes,
                                  Flag1 = a.Flag1,
                                  Flag2 = a.Flag2,
                                  Approved = a.Approved
                              });
                if (result == null) { return HttpNotFound(); }
                return View(await result.SingleAsync());
            }
        }

        // POST: Attendance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            AttendanceModels attendanceModels = await db.Attendance.FindAsync(id);
            db.Attendance.Remove(attendanceModels);
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
