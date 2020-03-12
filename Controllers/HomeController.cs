using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VLGroupWebSite.Models;
using VLGroupWebSite.Repository.Abstract;
using VLGroupWebSite.Repository.Concrete.EntityFramework;

namespace VLGroupWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly VLGroupContext context;
        private IProductRepository repository;
        public HomeController(IProductRepository _repository, VLGroupContext _context)
        {
            context = _context;
            repository = _repository;
        }

        public IActionResult Index()
        {
            var query = repository.GetAll();
            return View(query);
        }

        public IActionResult FotoQalereya()
        {
            var query = repository.GetAll();
            return View(query);
        }
    }
}