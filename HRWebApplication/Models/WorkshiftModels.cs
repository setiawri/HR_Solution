using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    [Table("Workshifts")]
    public class WorkshiftModels
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Template Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Client")]
        public Guid Clients_Id { get; set; }

        [Required]
        [Display(Name = "Workshift Category")]
        public Guid WorkshiftCategories_Id { get; set; }

        [Required]
        [Display(Name = "Day of Week")]
        public byte DayOfWeek { get; set; }

        [Required]
        public TimeSpan Start { get; set; }

        [Required]
        [Display(Name = "Duration")]
        public int DurationMinutes { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }

        [Required]
        [Display(Name = "Employee")]
        public Guid UserAccounts_Id { get; set; }

        [Display(Name = "Workshift Templates")]
        public Guid WorkshiftTemplates_Id { get; set; }
    }
}