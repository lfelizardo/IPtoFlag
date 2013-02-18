using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IptoFlag.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "World Map";
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Europe()
        {
            ViewBag.Message = "Europe";
            return View();
        }
    }
}
