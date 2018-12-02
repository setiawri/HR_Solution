using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    [Table("BankAccounts")]
    public class BankAccountModels
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Account Name")]
        public string Name { get; set; }
        
        [Display(Name = "Client / Employee")]
        public Guid? Owner_RefId { get; set; }

        [Required]
        [Display(Name = "Bank Name")]
        public string BankName { get; set; }

        [Required]
        [Display(Name = "Account Number")]
        public string AccountNumber { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }
        public bool Internal { get; set; }

        [Display(Name = "Owner")]
        public int? Owner_Id { get; set; }
    }
}