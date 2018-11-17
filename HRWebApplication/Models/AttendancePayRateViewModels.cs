using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    public class AttendancePayRateViewModels
    {
        public Guid Id { get; set; }

        [Display(Name = "Workshifts Template")]
        public string WorkshiftsTemplate { get; set; }
        public string Status { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal Amount { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }
    }
}