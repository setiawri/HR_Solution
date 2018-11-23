using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    [Table("PaymentItems")]
    public class PaymentItemModels
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Payments_Id { get; set; }
        public Guid Transaction_RefId { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
    }
}