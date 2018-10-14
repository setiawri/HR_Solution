using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    [Table("MasterMenu")]
    public class MasterMenuModels
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string MenuName { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Icon { get; set; }
        public int MenuOrder { get; set; }
        public int IsExpanded { get; set; }
    }
}