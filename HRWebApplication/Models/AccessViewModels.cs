using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    public class AccessViewModels
    {
        [Display(Name = "#")]
        public int MenuOrder { get; set; }

        [Display(Name = "Menu Name")]
        public string MenuName { get; set; }

        [Display(Name = "Reference")]
        public string WebMenuAccess { get; set; }

        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
    }
}