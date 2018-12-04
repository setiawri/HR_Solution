using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    [Table("Attendances")]
    public class AttendanceModels
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Employee")]
        public Guid UserAccounts_Id { get; set; }

        [Required]
        [Display(Name = "In")]
        public DateTime TimestampIn { get; set; }

        [Required]
        [Display(Name = "Out")]
        public DateTime TimestampOut { get; set; }
        public string Notes { get; set; }
        public bool Flag1 { get; set; }
        public bool Flag2 { get; set; }
        public bool Approved { get; set; }
        public byte? Workshifts_DayOfWeek { get; set; }
        public DateTime? Workshifts_Start { get; set; }
        public int? Workshifts_DurationMinutes { get; set; }

        [Required]
        [Display(Name = "Effective In")]
        public DateTime EffectiveTimestampIn { get; set; }

        [Required]
        [Display(Name = "Effective Out")]
        public DateTime EffectiveTimestampOut { get; set; }

        [Required]
        [Display(Name = "Client")]
        public Guid Clients_Id { get; set; }
        public bool Rejected { get; set; }
        public Guid? PayrollItems_Id { get; set; }

        [Required]
        [Display(Name = "Status")]
        public Guid AttendanceStatuses_Id { get; set; }

        //[Required]
        [Display(Name = "Workshift")]
        public Guid? Workshifts_Id { get; set; }
        public Guid? AttendancePayRates_Id { get; set; }
        
        [Display(Name = "Pay Rate Amount")]
        public decimal? AttendancePayRates_Amount { get; set; }
    }
}