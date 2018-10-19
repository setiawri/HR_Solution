﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    public class HrContext : DbContext
    {
        public DbSet<MasterMenuModels> MasterMenu { get; set; }
        public DbSet<UserModels> User { get; set; }
        public DbSet<RoleModels> Role { get; set; }
        public DbSet<UserRoleModels> UserRole { get; set; }
        public DbSet<ClientModels> Clients { get; set; }
    }
}