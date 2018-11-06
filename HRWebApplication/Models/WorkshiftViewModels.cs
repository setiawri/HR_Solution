using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    public class WorkshiftViewModels
    {
        public Guid Id { get; set; }
        public string Client { get; set; }
        public string Employee { get; set; }

        [Display(Name = "Template Name")]
        public string Name { get; set; }

        [Display(Name = "Workshift Template")]
        public string TemplateName { get; set; }
        public string Category { get; set; }

        [Display(Name = "Day of Week")]
        public string DayOfWeek { get; set; }
        public string Start { get; set; }

        [Display(Name = "Duration Minutes")]
        public int DurationMinutes { get; set; }
        public bool Active { get; set; }
    }
}