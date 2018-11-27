using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    public class BankAccountViewModels
    {
        public Guid Id { get; set; }
        public string Owner { get; set; }

        [Display(Name = "Bank Name")]
        public string BankName { get; set; }

        [Display(Name = "Account Name")]
        public string Name { get; set; }

        [Display(Name = "Account Number")]
        public string AccountNumber { get; set; }
        public bool Internal { get; set; }
        public bool Active { get; set; }
    }
}