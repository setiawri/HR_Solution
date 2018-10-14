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
    [CustomAuthorize(Roles = "Superuser, Manager")]
    public class ClientController : Controller
    {
        private HrContext db = new HrContext();

        // GET: Client
        public async Task<ActionResult> Index()
        {
            return View(await db.Clients.ToListAsync());
        }

        // GET: Client/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientModels clientModels = await db.Clients.FindAsync(id);
            if (clientModels == null)
            {
                return HttpNotFound();
            }
            return View(clientModels);
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,CompanyName,Address,BillingAddress,ContactPersonName,Phone1,Phone2,Notes,NPWP,NPWPAddress,Active")] ClientModels clientModels)
        {
            if (ModelState.IsValid)
            {
                clientModels.Id = Guid.NewGuid();
                db.Clients.Add(clientModels);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(clientModels);
        }

        // GET: Client/Edit/5
        public async Task<ActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientModels clientModels = await db.Clients.FindAsync(id);
            if (clientModels == null)
            {
                return HttpNotFound();
            }
            return View(clientModels);
        }

        // POST: Client/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,CompanyName,Address,BillingAddress,ContactPersonName,Phone1,Phone2,Notes,NPWP,NPWPAddress,Active")] ClientModels clientModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clientModels).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(clientModels);
        }

        // GET: Client/Delete/5
        public async Task<ActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientModels clientModels = await db.Clients.FindAsync(id);
            if (clientModels == null)
            {
                return HttpNotFound();
            }
            return View(clientModels);
        }

        // POST: Client/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            ClientModels clientModels = await db.Clients.FindAsync(id);
            db.Clients.Remove(clientModels);
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
