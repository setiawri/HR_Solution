using HRWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRWebApplication.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private HrContext db = new HrContext();

        public ActionResult Index()
        {
            ViewBag.UserCount = db.User.SqlQuery("SELECT * FROM AspNetUsers").Count().ToString("000");
            ViewBag.ClientCount = db.Clients.SqlQuery("SELECT * FROM Clients").Count().ToString("000");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}