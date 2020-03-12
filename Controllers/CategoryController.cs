using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VLGroupWebSite.Repository.Abstract;

namespace VLGroupWebSite.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository repository;
        public CategoryController(ICategoryRepository _repository)
        {
            repository = _repository;
        }
        public IActionResult Index()
        {
            var cat = repository.GetByName("Jaluz");
            return View(cat);
        }
    }
}