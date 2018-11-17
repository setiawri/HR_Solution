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

namespace HRWebApplication.Controllers
{
    public class AttendancePayRateController : Controller
    {
        private HrContext db = new HrContext();

        // GET: AttendancePayRate
        public async Task<ActionResult> Index()
        {
            var result = (from p in db.AttPayRate
                          join wt in db.WsTemplate on p.RefId equals wt.Id
                          join s in db.AttStatus on p.AttendanceStatuses_Id equals s.Id
                          select new AttendancePayRateViewModels
                          {
                              Id = p.Id,
                              WorkshiftsTemplate = wt.Name,
                              Status = s.Name,
                              Amount = p.Amount,
                              Notes = p.Notes,
                              Active = p.Active
                          });
            return View(await result.ToListAsync());
        }

        // GET: AttendancePayRate/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var result = (from p in db.AttPayRate
                          join wt in db.WsTemplate on p.RefId equals wt.Id
                          join s in db.AttStatus on p.AttendanceStatuses_Id equals s.Id
                          where p.Id == id
                          select new AttendancePayRateViewModels
                          {
                              Id = p.Id,
                              WorkshiftsTemplate = wt.Name,
                              Status = s.Name,
                              Amount = p.Amount,
                              Notes = p.Notes,
                              Active = p.Active
                          }).SingleAsync();
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(await result);
        }

        // GET: AttendancePayRate/Create
        public ActionResult Create()
        {
            ViewBag.listWsTemplate = new SelectList(db.WsTemplate.Where(x => x.Active == true).OrderBy(x => x.Name).ToList(), "Id", "Name");
            ViewBag.listAttStatus = new SelectList(db.AttStatus.Where(x => x.Active == true).OrderBy(x => x.Name).ToList(), "Id", "Name");
            return View();
        }

        // POST: AttendancePayRate/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,RefId,AttendanceStatuses_Id,Amount,Notes,Active")] AttendancePayRateModels attendancePayRateModels)
        {
            if (ModelState.IsValid)
            {
                attendancePayRateModels.Id = Guid.NewGuid();
                db.AttPayRate.Add(attendancePayRateModels);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.listWsTemplate = new SelectList(db.WsTemplate.Where(x => x.Active == true).OrderBy(x => x.Name).ToList(), "Id", "Name");
            ViewBag.listAttStatus = new SelectList(db.AttStatus.Where(x => x.Active == true).OrderBy(x => x.Name).ToList(), "Id", "Name");
            return View(attendancePayRateModels);
        }

        // GET: AttendancePayRate/Edit/5
        public async Task<ActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AttendancePayRateModels attendancePayRateModels = await db.AttPayRate.FindAsync(id);
            if (attendancePayRateModels == null)
            {
                return HttpNotFound();
            }
            ViewBag.listWsTemplate = new SelectList(db.WsTemplate.Where(x => x.Active == true).OrderBy(x => x.Name).ToList(), "Id", "Name");
            ViewBag.listAttStatus = new SelectList(db.AttStatus.Where(x => x.Active == true).OrderBy(x => x.Name).ToList(), "Id", "Name");
            return View(attendancePayRateModels);
        }

        // POST: AttendancePayRate/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,RefId,AttendanceStatuses_Id,Amount,Notes,Active")] AttendancePayRateModels attendancePayRateModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(attendancePayRateModels).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.listWsTemplate = new SelectList(db.WsTemplate.Where(x => x.Active == true).OrderBy(x => x.Name).ToList(), "Id", "Name");
            ViewBag.listAttStatus = new SelectList(db.AttStatus.Where(x => x.Active == true).OrderBy(x => x.Name).ToList(), "Id", "Name");
            return View(attendancePayRateModels);
        }

        // GET: AttendancePayRate/Delete/5
        public async Task<ActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var result = (from p in db.AttPayRate
                          join wt in db.WsTemplate on p.RefId equals wt.Id
                          join s in db.AttStatus on p.AttendanceStatuses_Id equals s.Id
                          where p.Id == id
                          select new AttendancePayRateViewModels
                          {
                              Id = p.Id,
                              WorkshiftsTemplate = wt.Name,
                              Status = s.Name,
                              Amount = p.Amount,
                              Notes = p.Notes,
                              Active = p.Active
                          }).SingleAsync();
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(await result);
        }

        // POST: AttendancePayRate/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            AttendancePayRateModels attendancePayRateModels = await db.AttPayRate.FindAsync(id);
            db.AttPayRate.Remove(attendancePayRateModels);
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
