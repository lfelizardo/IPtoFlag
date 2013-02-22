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
            CreateEuropeView();

            return View();
        }

        private void CreateEuropeView()
        {
            ViewBag.Message = "Europe";
            ViewBag.Countries = this.repository.GetCountries().ToList();

            var itens = new List<SelectListItem>();
            foreach (var country in ViewBag.Countries as List<IptoFlag.Countries>)
            {
                itens.Add(new SelectListItem { Text = country.Name, Value = country.IdCountry.ToString() });
            }
            ViewBag.SelectCountries = itens;
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

        [HttpPost]
        public ActionResult Create(Info information)
        {
                try
                {
                    if (ModelState.IsValid)
                    {
                        information.IP = GetIP();
                        information.Location = "Default";
                        information.Date = DateTime.Now;
                        this.repository.AddInfo(information);
                        this.repository.SubmitChanges();
                        CreateEuropeView();
                        return View("Europe");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            return View(information);
        }

        public String GetIP()
        {
            String clientIP = (HttpContext.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] == null) ? HttpContext.Request.UserHostAddress: HttpContext.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            return clientIP;
        }

    }
}
