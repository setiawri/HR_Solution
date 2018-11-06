using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    public class HrContext : DbContext
    {
        public DbSet<MasterMenuModels> MasterMenu { get; set; }
        public DbSet<AccessModels> Access { get; set; }
        public DbSet<UserModels> User { get; set; }
        public DbSet<RoleModels> Role { get; set; }
        public DbSet<UserRoleModels> UserRole { get; set; }
        public DbSet<ClientModels> Clients { get; set; }
        public DbSet<WorkshiftCategoryModels> WsCategory { get; set; }
        public DbSet<WorkshiftTemplateModels> WsTemplate { get; set; }
        public DbSet<WorkshiftModels> Workshift { get; set; }
        public DbSet<AttendanceStatusModels> AttStatus { get; set; }
        public DbSet<AttendanceModels> Attendance { get; set; }
    }
}