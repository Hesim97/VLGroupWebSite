using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VLGroupWebSite.Controllers
{
    public class SearchController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //[HttpGet]
        //public ActionResult Index()
        //{
        //    return View();
        //}

        [HttpPost]
        public ActionResult Search(string searchString)
        {
            return View();
        }
    }
}