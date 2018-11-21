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
                    for (int a = 0; a < arrID.Length; a++)
                    {
                        Guid attID = new Guid(arrID[a]);
                        isValid = db.Attendance.Where(x => x.Id == attID).Select(x => x.Approved).Single();
                        if (!isValid)
                        {
                            break;
                        }
                    }

                    if (!isValid)
                    {
                        return Json(new { status = "405" }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        for (int i = 0; i < arrID.Length; i++)
                        {
                            Guid attID = new Guid(arrID[i]);
                            PayrollModels pRoll = new PayrollModels();
                            pRoll.Id = Guid.NewGuid();
                            pRoll.Timestamp = DateTime.Now;
                            pRoll.Employee_UserAccounts_Id = db.Attendance.Where(x => x.Id == attID).Select(x => x.UserAccounts_Id).Single();
                            int hours = db.Attendance.Where(x => x.Id == attID).Select(x => x.Workshifts_DurationMinutes).Single() / 60;
                            decimal payRate = (from a in db.Attendance
                                               join w in db.Workshift on a.Workshifts_Id equals w.Id
                                               join t in db.WsTemplate on w.WorkshiftTemplates_Id equals t.Id
                                               join p in db.AttPayRate on t.Id equals p.RefId
                                               select p.Amount).Single();
                            pRoll.Amount = hours * payRate;
                            pRoll.No = "00001";
                            pRoll.hasPayment = false;
                            db.Payroll.Add(pRoll);
                            db.SaveChanges();
                        }
                        return Json(new { status = "200" }, JsonRequestBehavior.AllowGet);
                    }
                }
                else
                {
                    return Json(new { status = "404" }, JsonRequestBehavior.AllowGet);
                }
            } //end ids is not null/empty
        } //end generate payroll
    }
}