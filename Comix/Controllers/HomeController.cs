using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Comix.Infrastructure;
using Comix.Models;
using Marvel.Api.Model.DomainObjects;
using Marvel.Api.Filters;
using System.Web.Script.Serialization;

namespace Comix.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {

            var response = ApiHelper.HeroContext.GetCharaterId("spider-man");
            return View(response);
            //var response = ApiHelper.HeroContext.GetCharaterId("spider-man");
            //return Json(response, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult About(int currentPage=2, int pageSize=10)
        {
            var response = ApiHelper.MarvelClient.FindCharacters(
                new CharacterRequestFilter {
                    Offset = currentPage, Limit= pageSize
                });

            var paging = new PageModel
            {
                CurrentPage = currentPage,
                ItemsPerPage = pageSize,
                TotalItems = int.Parse(response.Data.Total)
            };

            CharacterListViewModel characterList = new CharacterListViewModel
            {
                Characters = response.Data.Results,
                PageInfo = paging
            };

            return View(characterList);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}