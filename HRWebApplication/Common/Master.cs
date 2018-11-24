using HRWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRWebApplication.Common
{
    public class Master
    {
        public enum DayOfWeek
        {
            Sunday = 0,
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6
        }

        public int GetLastHexNo(string key)
        {
            int result;
            using (var ctx = new HrContext())
            {
                if (key == "payroll") { result = ctx.Payroll.Select(x => x.No).Cast<int>().DefaultIfEmpty(0).Max(); } //payroll
                else { result = ctx.Payment.Select(x => x.No).Cast<int>().DefaultIfEmpty(0).Max(); } //payment
            }

            return result + 1;
        }

        public decimal GetTotalPayment(Guid IdPayroll)
        {
            decimal result;
            using (var ctx = new HrContext())
            {
                result = ctx.PaymentItem.Where(x => x.Transaction_RefId == IdPayroll).Select(x => x.Amount).DefaultIfEmpty(0).Sum();
            }

            return result;
        }
    }
}