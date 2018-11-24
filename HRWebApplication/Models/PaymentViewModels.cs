using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    public class PaymentViewModels
    {
        public Guid Id { get; set; }

        [Display(Name = "Payroll No.")]
        public string No { get; set; }

        //public DateTime Timestamp { get; set; }

        [Display(Name = "Source Bank Account")]
        public Guid Source_BankAccounts_Id { get; set; }

        [Display(Name = "Target Bank Account")]
        public Guid Target_BankAccounts_Id { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Display(Name = "Confirmation Number")]
        public string ConfirmationNumber { get; set; }
        public string Notes { get; set; }

        public Guid IdUser { get; set; }
        public bool hasPayment { get; set; }

        //public string NoPayment { get; set; }
        //public string Employee { get; set; }
        //public string Target { get; set; }
        //public string Source { get; set; }
    }
}