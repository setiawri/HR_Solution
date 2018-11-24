using HRWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRWebApplication.Controllers
{
    public class ReportController : Controller
    {
        private HrContext db = new HrContext();

        public ActionResult Timesheet()
        {
            var result = (from a in db.Attendance
                          join u in db.User on a.UserAccounts_Id.ToString() equals u.Id
                          join c in db.Clients on a.Clients_Id equals c.Id
                          join w in db.Workshift on a.Workshifts_Id equals w.Id
                          where a.PayrollItems_Id == null
                          orderby u.FullName, c.CompanyName
                          select new TimesheetViewModels
                          {
                              Id = a.Id,
                              Employee = u.FullName,
                              Client = c.CompanyName,
                              Day = ((Common.Master.DayOfWeek)w.DayOfWeek).ToString(),
                              IN = a.TimestampIn,
                              OUT = a.TimestampOut,
                              EffectiveIN = a.EffectiveTimestampIn,
                              EffectiveOUT = a.EffectiveTimestampOut,
                              Hours = (a.Workshifts_DurationMinutes / 60).ToString(),
                              Notes = a.Notes,
                              Status = a.Approved ? "Approved" : "Not Approved"
                          });
            return View(result.ToList());
        }

        public JsonResult AcceptStatus(Guid Id)
        {
            using (var ctx = new HrContext())
            {
                int rowUpdate = ctx.Database.ExecuteSqlCommand("UPDATE Attendances SET Approved='True' WHERE Id='" + Id + "'");
            }
            return Json(new { status = "200" }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult RejectStatus(Guid Id)
        {
            using (var ctx = new HrContext())
            {
                int rowUpdate = ctx.Database.ExecuteSqlCommand("UPDATE Attendances SET Approved='False' WHERE Id='" + Id + "'");
            }
            return Json(new { status = "200" }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GeneratePayroll(string ids)
        {
            if (string.IsNullOrEmpty(ids))
            {
                return Json(new { status = "404" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                string[] arrID = ids.Split(',');
                if (arrID.Length > 0)
                {
                    bool isValid = false;
                    string empID = null;
                    for (int a = 0; a < arrID.Length; a++)
                    {
                        Guid attID = new Guid(arrID[a]);

                        //Approved Checked
                        isValid = db.Attendance.Where(x => x.Id == attID).Select(x => x.Approved).Single();
                        if (!isValid) { break; }

                        //Same Employee Checked
                        string userID = db.Attendance.Where(x => x.Id == attID).Select(x => x.UserAccounts_Id).Single().ToString();
                        if (a == 0) { empID = userID; }
                        else
                        {
                            isValid = (empID == userID) ? true : false;
                        }

                    }

                    if (!isValid)
                    {
                        return Json(new { status = "405" }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        Guid _attID = new Guid(arrID[0]);
                        Guid employeeID = db.Attendance.Where(x => x.Id == _attID).Select(x => x.UserAccounts_Id).Single();

                        PayrollModels pRoll = new PayrollModels();
                        pRoll.Id = Guid.NewGuid();
                        pRoll.Timestamp = DateTime.Now;
                        pRoll.Employee_UserAccounts_Id = employeeID;
                        pRoll.Amount = 0;
                        Common.Master m = new Common.Master();
                        pRoll.No = m.GetLastHexNo("payroll").ToString("00000");
                        pRoll.hasPayment = false;
                        db.Payroll.Add(pRoll);
                        db.SaveChanges();

                        for (int i = 0; i < arrID.Length; i++)
                        {
                            Guid attID = new Guid(arrID[i]);
                            PayrollItemModels pi = new PayrollItemModels();
                            pi.Id = Guid.NewGuid();
                            pi.Payrolls_Id = pRoll.Id;
                            pi.RefId = attID;
                            pi.Description = string.Empty;
                            int hours = db.Attendance.Where(x => x.Id == attID).Select(x => x.Workshifts_DurationMinutes).Single() / 60;
                            decimal payRate = (from a in db.Attendance
                                               join w in db.Workshift on a.Workshifts_Id equals w.Id
                                               join t in db.WsTemplate on w.WorkshiftTemplates_Id equals t.Id
                                               join p in db.AttPayRate on t.Id equals p.RefId
                                               where a.Id == attID
                                               select p.Amount).Single();
                            pi.Amount = hours * payRate;
                            pi.Notes = string.Empty;
                            db.PayrollItem.Add(pi);
                            db.SaveChanges();

                            using (var ctx = new HrContext())
                            {
                                int result = ctx.Database.ExecuteSqlCommand("UPDATE Attendances SET PayrollItems_Id='" + pi.Id + "' WHERE Id='" + attID + "'");
                            }
                        }

                        decimal total_amount = db.PayrollItem.Where(x => x.Payrolls_Id == pRoll.Id).Select(x => x.Amount).Sum();
                        int update_amount = db.Database.ExecuteSqlCommand("UPDATE Payrolls SET Amount=" + total_amount + " WHERE Id='" + pRoll.Id + "'");

                        return Json(new { status = "200" }, JsonRequestBehavior.AllowGet);
                    }
                }
                else
                {
                    return Json(new { status = "404" }, JsonRequestBehavior.AllowGet);
                }
            } //end ids is not null/empty
        } //end generate payroll

        public JsonResult GetDetails(Guid Id)
        {
            var result = (from pr in db.Payroll
                          join pi in db.PayrollItem on pr.Id equals pi.Payrolls_Id
                          join a in db.Attendance on pi.Id equals a.PayrollItems_Id
                          where pr.Id == Id
                          select new PayrollItemViewModels
                          {
                              Id = pi.Id,
                              In = a.EffectiveTimestampIn,
                              Out = a.EffectiveTimestampOut,
                              Amount = pi.Amount,
                              Notes = a.Notes
                          }).ToList();

            string message = @"<div class='table-responsive'>
                                    <table id='chkDatatable' class='table table-striped table-bordered'>
                                        <thead>
                                            <tr>
                                                <th>Attend In</th>
                                                <th>Attend Out</th>
                                                <th>Amount</th>
                                                <th>Notes</th>
                                            </tr>
                                        </thead>
                                        <tbody>";
            foreach (PayrollItemViewModels piVM in result)
            {
                message += @"<tr>
                                <td>" + piVM.In.ToString("yyyy-MM-dd HH:mm") + @"</td>
                                <td>" + piVM.Out.ToString("yyyy-MM-dd HH:mm") + @"</td>
                                <td>" + piVM.Amount.ToString("#,##0.00") + @"</td>
                                <td>" + piVM.Notes + @"</td>
                            </tr>";
            }
            message += "</tbody></table></div>";

            return Json(new { content = message }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Payroll()
        {
            var result = (from r in db.Payroll
                          join u in db.User on r.Employee_UserAccounts_Id.ToString() equals u.Id
                          where r.Amount > 0
                          select new PayrollViewModels
                          {
                              Id = r.Id,
                              No = r.No,
                              Timestamp = r.Timestamp,
                              Employee = u.FullName,
                              Amount = r.Amount,
                              HasPayment = r.hasPayment
                          });
            return View(result.ToList());
        }

        public ActionResult Payment(Guid? Id)
        {
            HRWebApplication.Common.Master m = new Common.Master();
            PaymentViewModels result = (from pRoll in db.Payroll
                                        where pRoll.Id == Id
                                        select new PaymentViewModels
                                        {
                                            No = pRoll.No,
                                            Amount = pRoll.Amount,
                                            IdUser = pRoll.Employee_UserAccounts_Id,
                                            hasPayment = pRoll.hasPayment
                                        }).Single();
            result.Amount -= m.GetTotalPayment(Id.Value);
            ViewBag.listTarget = new SelectList(db.BankAccount.Where(x => x.Active == true && x.Owner_RefId == result.IdUser).OrderBy(x => x.Name).ToList(), "Id", "Name");
            ViewBag.listSource = new SelectList(db.BankAccount.Where(x => x.Active == true && x.Internal == true).OrderBy(x => x.Name).ToList(), "Id", "Name");
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Payment([Bind(Include = "Id,No,Source_BankAccounts_Id,Target_BankAccounts_Id,Amount,ConfirmationNumber,Notes,IdUser,HasPayment")] PaymentViewModels paymentVM)
        {
            Common.Master m = new Common.Master();
            decimal remaining = db.Payroll.Where(x => x.Id == paymentVM.Id).Select(x => x.Amount).Single()- m.GetTotalPayment(paymentVM.Id);
            if (paymentVM.Amount > remaining)
            {
                ModelState.AddModelError("Over", "The field Amount can't greater than " + remaining.ToString("#,##0"));
            }

            if (ModelState.IsValid)
            {
                PaymentModels pay = new PaymentModels();
                pay.Id = Guid.NewGuid();
                pay.No = m.GetLastHexNo("payment").ToString("00000");
                pay.Timestamp = DateTime.Now;
                pay.Source_BankAccounts_Id = paymentVM.Source_BankAccounts_Id;
                pay.Target_BankAccounts_Id = paymentVM.Target_BankAccounts_Id;
                pay.Amount = paymentVM.Amount;
                pay.ConfirmationNumber = paymentVM.ConfirmationNumber;
                pay.Notes = paymentVM.Notes;
                db.Payment.Add(pay);

                PaymentItemModels pi = new PaymentItemModels();
                pi.Id = Guid.NewGuid();
                pi.Payments_Id = pay.Id;
                pi.Transaction_RefId = paymentVM.Id;
                pi.Amount = paymentVM.Amount;
                pi.Notes = paymentVM.Notes;
                db.PaymentItem.Add(pi);

                db.SaveChanges();

                if (!paymentVM.hasPayment)
                {
                    using (var ctx = new HrContext())
                    {
                        int result = ctx.Database.ExecuteSqlCommand("UPDATE Payrolls SET hasPayment='True' WHERE Id='" + paymentVM.Id + "'");
                    }
                }

                return RedirectToAction("Payroll");
            }
            
            ViewBag.listTarget = new SelectList(db.BankAccount.Where(x => x.Active == true && x.Owner_RefId == paymentVM.IdUser).OrderBy(x => x.Name).ToList(), "Id", "Name");
            ViewBag.listSource = new SelectList(db.BankAccount.Where(x => x.Active == true && x.Internal == true).OrderBy(x => x.Name).ToList(), "Id", "Name");
            return View(paymentVM);
        }

        public ActionResult Payments()
        {
            List<PaymentIndexViewModels> result = db.Database.SqlQuery<PaymentIndexViewModels>(@"
                SELECT pay.No NoPayment,pRoll.No NoPayroll,pay.Timestamp,emp.FullName Employee,pay.Amount,bTarget.Name Target,bSource.Name Source,pay.Notes
                FROM Payments pay
                INNER JOIN PaymentItems pItem ON pay.Id = pItem.Payments_Id
                INNER JOIN BankAccounts bTarget ON pay.Target_BankAccounts_Id = bTarget.Id
                INNER JOIN BankAccounts bSource ON pay.Source_BankAccounts_Id = bSource.Id
                LEFT JOIN Payrolls pRoll ON pItem.Transaction_RefId = pRoll.Id
                LEFT JOIN AspNetUsers emp ON pRoll.Employee_UserAccounts_Id = emp.Id
            ").ToList();
            return View(result);
        }
    }
}