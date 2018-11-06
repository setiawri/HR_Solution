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
    public class AttendanceStatusController : Controller
    {
        private HrContext db = new HrContext();

        // GET: AttendanceStatus
        public async Task<ActionResult> Index()
        {
            Permissions p = new Permissions();
            bool auth = p.isGranted(User.Identity.Name, this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + this.ControllerContext.RouteData.Values["action"].ToString());
            if (!auth) { return new ViewResult() { ViewName = "Unauthorized" }; }
            else
            {
                return View(await db.AttStatus.ToListAsync());
            }
        }

        // GET: AttendanceStatus/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AttendanceStatusModels attendanceStatusModels = await db.AttStatus.FindAsync(id);
            if (attendanceStatusModels == null)
            {
                return HttpNotFound();
            }
            return View(attendanceStatusModels);
        }

        // GET: AttendanceStatus/Create
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

        // POST: AttendanceStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,Notes,Active")] AttendanceStatusModels attendanceStatusModels)
        {
            if (ModelState.IsValid)
            {
                attendanceStatusModels.Id = Guid.NewGuid();
                db.AttStatus.Add(attendanceStatusModels);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(attendanceStatusModels);
        }

        // GET: AttendanceStatus/Edit/5
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
                AttendanceStatusModels attendanceStatusModels = await db.AttStatus.FindAsync(id);
                if (attendanceStatusModels == null)
                {
                    return HttpNotFound();
                }
                return View(attendanceStatusModels);
            }
        }

        // POST: AttendanceStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Notes,Active")] AttendanceStatusModels attendanceStatusModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(attendanceStatusModels).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(attendanceStatusModels);
        }

        // GET: AttendanceStatus/Delete/5
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
                AttendanceStatusModels attendanceStatusModels = await db.AttStatus.FindAsync(id);
                if (attendanceStatusModels == null)
                {
                    return HttpNotFound();
                }
                return View(attendanceStatusModels);
            }
        }

        // POST: AttendanceStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            AttendanceStatusModels attendanceStatusModels = await db.AttStatus.FindAsync(id);
            db.AttStatus.Remove(attendanceStatusModels);
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
