using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    [Table("Payrolls")]
    public class PayrollModels
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }
        public Guid Employee_UserAccounts_Id { get; set; }
        public decimal Amount { get; set; }
        public string No { get; set; }
        public bool hasPayment { get; set; }
    }
}