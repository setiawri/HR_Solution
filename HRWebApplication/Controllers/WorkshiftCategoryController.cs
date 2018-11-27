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
    public class WorkshiftCategoryController : Controller
    {
        private HrContext db = new HrContext();

        // GET: WorkshiftCategory
        public async Task<ActionResult> Index()
        {
            Permissions p = new Permissions();
            bool auth = p.isGranted(User.Identity.Name, this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + this.ControllerContext.RouteData.Values["action"].ToString());
            if (!auth) { return new ViewResult() { ViewName = "Unauthorized" }; }
            else
            {
                return View(await db.WsCategory.ToListAsync());
            }
        }

        // GET: WorkshiftCategory/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkshiftCategoryModels workshiftCategoryModels = await db.WsCategory.FindAsync(id);
            if (workshiftCategoryModels == null)
            {
                return HttpNotFound();
            }
            return View(workshiftCategoryModels);
        }

        // GET: WorkshiftCategory/Create
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

        // POST: WorkshiftCategory/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,Notes,Active")] WorkshiftCategoryModels workshiftCategoryModels)
        {
            if (ModelState.IsValid)
            {
                workshiftCategoryModels.Id = Guid.NewGuid();
                db.WsCategory.Add(workshiftCategoryModels);
                await db.SaveChangesAsync();
                return RedirectToAction("Create");
            }

            return View(workshiftCategoryModels);
        }

        // GET: WorkshiftCategory/Edit/5
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
                WorkshiftCategoryModels workshiftCategoryModels = await db.WsCategory.FindAsync(id);
                if (workshiftCategoryModels == null)
                {
                    return HttpNotFound();
                }
                return View(workshiftCategoryModels);
            }            
        }

        // POST: WorkshiftCategory/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Notes,Active")] WorkshiftCategoryModels workshiftCategoryModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workshiftCategoryModels).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(workshiftCategoryModels);
        }

        // GET: WorkshiftCategory/Delete/5
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
                WorkshiftCategoryModels workshiftCategoryModels = await db.WsCategory.FindAsync(id);
                if (workshiftCategoryModels == null)
                {
                    return HttpNotFound();
                }
                return View(workshiftCategoryModels);
            }
        }

        // POST: WorkshiftCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            WorkshiftCategoryModels workshiftCategoryModels = await db.WsCategory.FindAsync(id);
            db.WsCategory.Remove(workshiftCategoryModels);
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
