using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    public class PayrollItemViewModels
    {
        public Guid Id { get; set; }
        public DateTime In { get; set; }
        public DateTime Out { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
    }
}