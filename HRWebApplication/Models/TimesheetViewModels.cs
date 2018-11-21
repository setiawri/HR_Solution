using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    public class TimesheetViewModels
    {
        public Guid Id { get; set; }
        public string Employee { get; set; }
        public string Client { get; set; }
        public string Day { get; set; }
        public DateTime IN { get; set; }
        public DateTime OUT { get; set; }

        [Display(Name = "Effective In")]
        public DateTime EffectiveIN { get; set; }

        [Display(Name = "Effective Out")]
        public DateTime EffectiveOUT { get; set; }
        public string Hours { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
    }
}