using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    public class WorkshiftTemplateViewModels
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Template Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Client")]
        public string Client { get; set; }

        [Required]
        [Display(Name = "Workshift Category")]
        public string WorkshiftCategory { get; set; }

        [Required]
        [Display(Name = "Day")]
        public string DayOfWeek { get; set; }

        [Required]
        public string Start { get; set; }

        [Required]
        public int Duration { get; set; }
        
        [Required]
        public bool Active { get; set; }
    }
}