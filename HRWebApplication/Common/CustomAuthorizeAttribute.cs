using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRWebApplication.Common
{
    [AttributeUsage(AttributeTargets.All)]
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public string ViewName { get; set; }

        public CustomAuthorizeAttribute()
        {
            ViewName = "Unauthorized";
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
            IsUserAuthorized(filterContext);
        }

        void IsUserAuthorized(AuthorizationContext filterContext)
        {
            //user is authorized
            if (filterContext.Result == null)
                return;
            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                ViewDataDictionary dic = new ViewDataDictionary();
                dic.Add("Message", "Access denied due to invalid credentials.");
                var result = new ViewResult() { ViewName = this.ViewName, ViewData = dic };
                filterContext.Result = result;
            }
        }
    }
}