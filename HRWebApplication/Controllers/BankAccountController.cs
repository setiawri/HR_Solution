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
    public class BankAccountController : Controller
    {
        private HrContext db = new HrContext();

        // GET: BankAccount
        public async Task<ActionResult> Index()
        {
            Permissions p = new Permissions();
            bool auth = p.isGranted(User.Identity.Name, this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + this.ControllerContext.RouteData.Values["action"].ToString());
            if (!auth) { return new ViewResult() { ViewName = "Unauthorized" }; }
            else
            {
                var result = (from b in db.BankAccount
                              orderby b.Name
                              select new BankAccountViewModels
                              {
                                  Id = b.Id,
                                  Owner = (b.Owner_Id == 1) ? "Client" : "Employee",
                                  Name = b.Name,
                                  BankName = b.BankName,
                                  AccountNumber = b.AccountNumber,
                                  Internal = b.Internal,
                                  Active = b.Active
                              });
                return View(await result.ToListAsync());
            }
        }

        // GET: BankAccount/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankAccountModels bankAccountModels = await db.BankAccount.FindAsync(id);
            if (bankAccountModels == null)
            {
                return HttpNotFound();
            }
            return View(bankAccountModels);
        }

        public JsonResult LoadOwnerReff(int owner_id)
        {
            if (owner_id == 1) //Client
            {
                var result = new SelectList(db.Clients.Where(x => x.Active == true).OrderBy(x => x.CompanyName).ToList(), "Id", "CompanyName");
                return Json(new { result }, JsonRequestBehavior.AllowGet);
            }
            else //Employee
            {
                var result = new SelectList(db.User.OrderBy(x => x.FullName).ToList(), "Id", "FullName");
                return Json(new { result }, JsonRequestBehavior.AllowGet);
            }
        }

        // GET: BankAccount/Create
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

        // POST: BankAccount/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,Owner_Id,Owner_RefId,BankName,AccountNumber,Notes,Active,Internal")] BankAccountModels bankAccountModels)
        {
            if (ModelState.IsValid)
            {
                bankAccountModels.Id = Guid.NewGuid();
                db.BankAccount.Add(bankAccountModels);
                await db.SaveChangesAsync();
                return RedirectToAction("Create");
            }

            return View(bankAccountModels);
        }

        // GET: BankAccount/Edit/5
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
                BankAccountModels bankAccountModels = await db.BankAccount.FindAsync(id);
                if (bankAccountModels == null)
                {
                    return HttpNotFound();
                }

                if (bankAccountModels.Owner_Id == 1)
                {
                    ViewBag.listOwner = new SelectList(db.Clients.Where(x => x.Active == true).OrderBy(x => x.CompanyName).ToList(), "Id", "CompanyName");
                }
                else
                {
                    ViewBag.listOwner = new SelectList(db.User.OrderBy(x => x.FullName).ToList(), "Id", "FullName");
                }
                return View(bankAccountModels);
            }
        }

        // POST: BankAccount/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Owner_Id,Owner_RefId,BankName,AccountNumber,Notes,Active,Internal")] BankAccountModels bankAccountModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bankAccountModels).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            if (bankAccountModels.Owner_Id == 1)
            {
                ViewBag.listOwner = new SelectList(db.Clients.Where(x => x.Active == true).OrderBy(x => x.CompanyName).ToList(), "Id", "CompanyName");
            }
            else
            {
                ViewBag.listOwner = new SelectList(db.User.OrderBy(x => x.FullName).ToList(), "Id", "FullName");
            }
            return View(bankAccountModels);
        }

        // GET: BankAccount/Delete/5
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
                BankAccountModels bankAccountModels = await db.BankAccount.FindAsync(id);
                if (bankAccountModels == null)
                {
                    return HttpNotFound();
                }
                return View(bankAccountModels);
            }
        }

        // POST: BankAccount/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            BankAccountModels bankAccountModels = await db.BankAccount.FindAsync(id);
            db.BankAccount.Remove(bankAccountModels);
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
