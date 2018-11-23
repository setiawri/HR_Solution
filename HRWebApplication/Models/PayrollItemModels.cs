using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    [Table("PayrollItems")]
    public class PayrollItemModels
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Payrolls_Id { get; set; }
        public Guid RefId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
    }
}