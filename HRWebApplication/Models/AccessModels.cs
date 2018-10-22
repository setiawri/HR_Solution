using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    [Table("UserAccountAccessRoleAssignments")]
    public class AccessModels
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserAccountRoles_Id { get; set; }
        public int UserAccountAccess_EnumId { get; set; }
        public string WebMenuAccess { get; set; }
    }
}