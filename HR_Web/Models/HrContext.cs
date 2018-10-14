using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HR_Web.Models
{
    public class HrContext : DbContext
    {
        public DbSet<ClientModels> Clients { get; set; }
    }
}