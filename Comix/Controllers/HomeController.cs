using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Comix.Infrastructure;

namespace Comix.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            var response = ApiHelper.MarvelClient.FindCharacters();
            return View(response.Data.Results);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}