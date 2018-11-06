using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    public class AttendanceViewModels
    {
        public Guid Id { get; set; }
        public string Employee { get; set; }
        public string Client { get; set; }
        public string Workshift { get; set; }
        public string Day { get; set; }
        public string Start { get; set; }
        public int Duration { get; set; }
        public bool Flag1 { get; set; }
        public bool Flag2 { get; set; }
        public bool Approved { get; set; }
    }
}