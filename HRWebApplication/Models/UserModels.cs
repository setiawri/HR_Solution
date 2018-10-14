﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    [Table("AspNetUsers")]
    public class UserModels
    {
        [Key]
        public string Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
    }

    [Table("AspNetRoles")]
    public class RoleModels
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
    }

    [Table("AspNetUserRoles")]
    public class UserRoleModels
    {
        [Key]
        public string UserId { get; set; }
        public string RoleId { get; set; }
    }

    public class UserViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }
        public string Role { get; set; }
        public string RoleId { get; set; }
    }
}