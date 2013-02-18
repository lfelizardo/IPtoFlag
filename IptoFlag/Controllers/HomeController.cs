using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IptoFlag.Controllers
{
    public class HomeController : Controller
    {
        private Repository repository;

        public HomeController()
        {
            this.repository = new Repository();
        }

        public ActionResult Index()
        {
            ViewBag.Message = "World Map";
            return View();
        }

        public ActionResult Info()
        {
            ViewBag.Infos = this.repository.GetInfos().ToList();
            return View();
        }

        public ActionResult Europe()
        {
            ViewBag.Message = "Europe";
            ViewBag.Countries = this.repository.GetCountries().ToList();
            return View();
        }
    }
}
