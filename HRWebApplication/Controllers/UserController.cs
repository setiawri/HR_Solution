﻿using HRWebApplication.Common;
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
    [Authorize]
    public class UserController : Controller
    {
        private HrContext db = new HrContext();

        public ActionResult Index()
        {
            Permissions p = new Permissions();
            bool auth = p.isGranted(User.Identity.Name, this.ControllerContext.RouteData.Values["controller"].ToString() + "_" + this.ControllerContext.RouteData.Values["action"].ToString());
            if (!auth) { return new ViewResult() { ViewName = "Unauthorized" }; }
            else
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
        }

        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            UserModels userData = await db.User.FindAsync(id);
            UserViewModel userVM = new UserViewModel();
            userVM.Id = id;
            userVM.FullName = userData.FullName;
            userVM.UserName = userData.UserName;
            userVM.Email = userData.Email;
            userVM.Role = (from u in db.User
                           join ur in db.UserRole on u.Id equals ur.UserId
                           join r in db.Role on ur.RoleId equals r.Id
                           where u.Id == id
                           select r.Name).FirstOrDefault();
            userVM.DOB = userData.DOB;
            userVM.Height = userData.Height;
            userVM.Weight = userData.Weight;
            userVM.Phone1 = userData.Phone1;
            userVM.Phone2 = userData.Phone2;
            userVM.Address1 = userData.Address1;
            userVM.Address2 = userData.Address2;
            userVM.Notes = userData.Notes;

            List<BankAccountViewModels> bankVMs = new List<BankAccountViewModels>();
            List<BankAccountModels> banks = await db.BankAccount.Where(x => x.Owner_RefId.ToString() == id).ToListAsync();
            foreach (var item in banks)
            {
                BankAccountViewModels bankVM = new BankAccountViewModels();
                bankVM.BankName = item.BankName;
                bankVM.Name = item.Name;
                bankVM.AccountNumber = item.AccountNumber;
                bankVM.Active = item.Active;
                bankVMs.Add(bankVM);
            }

            List<WorkshiftViewModels> workshiftVMs = new List<WorkshiftViewModels>();
            List<WorkshiftModels> workshifts = await db.Workshift.Where(x => x.UserAccounts_Id.ToString() == id).ToListAsync();
            foreach (var item in workshifts)
            {
                WorkshiftViewModels workshiftVM = new WorkshiftViewModels();
                workshiftVM.Client = await db.Clients.Where(x => x.Id == item.Clients_Id).Select(x => x.CompanyName).FirstOrDefaultAsync();
                workshiftVM.Name = item.Name;
                workshiftVM.DayOfWeek = ((Master.DayOfWeek)item.DayOfWeek).ToString();
                workshiftVM.Start = item.Start.ToString().Substring(0, 5);
                workshiftVM.DurationMinutes = item.DurationMinutes;
                workshiftVM.Active = item.Active;
                workshiftVMs.Add(workshiftVM);
            }

            UserDetailModels userDetail = new UserDetailModels();
            userDetail.userModel = userVM;
            userDetail.bankModels = bankVMs;
            userDetail.workshiftModels = workshiftVMs;

            return View(userDetail);
        }

        public ActionResult Edit(string id)
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
                                  RoleId = r.Id,
                                  Identification = u.Identification,
                                  DOB = u.DOB,
                                  Height = u.Height,
                                  Weight = u.Weight,
                                  Phone1 = u.Phone1,
                                  Phone2 = u.Phone2,
                                  Address1 = u.Address1,
                                  Address2 = u.Address2,
                                  Notes = u.Notes
                              }).FirstOrDefault();

                UserViewModel userModels = userVM;

                if (userModels == null)
                {
                    return HttpNotFound();
                }

                ViewBag.listRole = new SelectList(db.Role.OrderBy(x => x.Name).ToList(), "Id", "Name");

                return View(userModels);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,FullName,UserName,Email,RoleId,Identification,DOB,Height,Weight,Phone1,Phone2,Address1,Address2,Notes")] UserViewModel userModels)
        {
            if (ModelState.IsValid)
            {
                var user = new UserModels()
                {
                    Id = userModels.Id,
                    FullName = userModels.FullName,
                    Email = userModels.Email,
                    Identification = userModels.Identification,
                    DOB = userModels.DOB,
                    Height = userModels.Height,
                    Weight = userModels.Weight,
                    Phone1 = userModels.Phone1,
                    Phone2 = userModels.Phone2,
                    Address1 = userModels.Address1,
                    Address2 = userModels.Address2,
                    Notes = userModels.Notes
                };
                var userRole = new UserRoleModels() { UserId = userModels.Id, RoleId = userModels.RoleId };
                using (var database = new HrContext())
                {
                    database.User.Attach(user);
                    database.Entry(user).Property(x => x.FullName).IsModified = true;
                    database.Entry(user).Property(x => x.Email).IsModified = true;
                    database.Entry(user).Property(x => x.Identification).IsModified = true;
                    database.Entry(user).Property(x => x.DOB).IsModified = true;
                    database.Entry(user).Property(x => x.Height).IsModified = true;
                    database.Entry(user).Property(x => x.Weight).IsModified = true;
                    database.Entry(user).Property(x => x.Phone1).IsModified = true;
                    database.Entry(user).Property(x => x.Phone2).IsModified = true;
                    database.Entry(user).Property(x => x.Address1).IsModified = true;
                    database.Entry(user).Property(x => x.Address2).IsModified = true;
                    database.Entry(user).Property(x => x.Notes).IsModified = true;

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