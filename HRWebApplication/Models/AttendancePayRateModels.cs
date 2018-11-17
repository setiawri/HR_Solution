using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    [Table("AttendancePayRates")]
    public class AttendancePayRateModels
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Workshifts Template")]
        public Guid RefId { get; set; }

        [Required]
        [Display(Name = "Attendance Status")]
        public Guid AttendanceStatuses_Id { get; set; }

        [Required]
        public decimal Amount { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }
    }
}