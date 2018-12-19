using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Comix.Infrastructure;
using Comix.Models;
using Marvel.Api.Model.DomainObjects;
using Marvel.Api.Filters;

namespace Comix.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            
            return View();
        }

        [HttpGet]
        public ActionResult About(int currentPage=2, int pageSize=100)
        {
            var paging = new PageModel { CurrentPage = currentPage, ItemsPerPage = pageSize };

            var response = ApiHelper.MarvelClient.FindCharacters(
                new CharacterRequestFilter {
                    Offset = paging.Offset, Limit= paging.ItemsPerPage
                });

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