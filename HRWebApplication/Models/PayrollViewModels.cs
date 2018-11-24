using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    public class PayrollViewModels
    {
        public Guid Id { get; set; }
        public string No { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Timestamp { get; set; }
        public string Employee { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal Amount { get; set; }
        public decimal Remaining { get; set; }
        public string Status { get; set; }

        [Display(Name = "Has Payment")]
        public bool HasPayment { get; set; }
    }
}