using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRWebApplication.Common
{
    public class Permissions
    {
        private Models.HrContext db = new Models.HrContext();

        public bool isGranted(string username, string controller_action)
        {
            var isValid = (from u in db.User
                           join ur in db.UserRole on u.Id equals ur.UserId
                           join a in db.Access on ur.RoleId equals a.UserAccountRoles_Id.ToString()
                           where u.UserName == username && a.WebMenuAccess == controller_action.ToLower()
                           select u);
            if (isValid.Count() > 0)
                return true;
            else
                return false;
        }
    }
}