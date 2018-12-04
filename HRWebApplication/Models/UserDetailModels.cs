using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    public class UserDetailModels
    {
        public UserViewModel userModel { get; set; }
        public List<BankAccountViewModels> bankModels { get; set; }
        public List<WorkshiftViewModels> workshiftModels { get; set; }
    }
}