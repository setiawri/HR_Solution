using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    public class PaymentIndexViewModels
    {
        [Display(Name = "No Payment")]
        public string NoPayment { get; set; }

        [Display(Name = "No Payroll")]
        public string NoPayroll { get; set; }
        public DateTime Timestamp { get; set; }
        public string Employee { get; set; }
        public decimal Amount { get; set; }
        public string Target { get; set; }
        public string Source { get; set; }
        public string Notes { get; set; }
    }
}