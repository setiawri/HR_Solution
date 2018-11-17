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
        public string Name { get; set; }

        [Required]
        public Guid Owner_RefId { get; set; }

        [Required]
        public string BankName { get; set; }

        [Required]
        public string AccountNumber { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }
        public bool Internal { get; set; }
        public int Owner_Id { get; set; }
    }
}