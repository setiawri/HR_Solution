using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HR_Web.Models
{
    [Table("Clients")]
    public class ClientModels
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        public string Address { get; set; }

        [Display(Name = "Billing Address")]
        public string BillingAddress { get; set; }

        [Display(Name = "Contact")]
        public string ContactPersonName { get; set; }

        [Display(Name = "Phone 1")]
        public string Phone1 { get; set; }

        [Display(Name = "Phone 2")]
        public string Phone2 { get; set; }
        public string Notes { get; set; }
        public string NPWP { get; set; }

        [Display(Name = "NPWP Address")]
        public string NPWPAddress { get; set; }
        public bool Active { get; set; }
    }
}