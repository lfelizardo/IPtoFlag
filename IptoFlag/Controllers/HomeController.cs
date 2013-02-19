using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
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


        public ActionResult ReturnInfos([DataSourceRequest]DataSourceRequest request)
        {
            return Json(this.repository.GetInfos().Select(x => new {IdInfo = x.IdInfo, 
                                                                    IdCountry = x.IdCountry, 
                                                                    InfoCountry = x.InfoCountry, 
                                                                    IP = x.IP, 
                                                                    Location = x.Location, 
                                                                    Date = x.Date }).ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }


    }
}
