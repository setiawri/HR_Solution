using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    [Table("Payments")]
    public class PaymentModels
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string No { get; set; }

        [Required]
        public DateTime Timestamp { get; set; }
        public Guid Source_BankAccounts_Id { get; set; }
        public Guid Target_BankAccounts_Id { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Display(Name = "Confirmation Number")]
        public string ConfirmationNumber { get; set; }
        public string Notes { get; set; }
        public bool Approved { get; set; }
        public bool Rejected { get; set; }
    }
}