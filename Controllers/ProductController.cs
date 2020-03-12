using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VLGroupWebSite.Entity;
using VLGroupWebSite.Infrastructure;
using VLGroupWebSite.Models;
using VLGroupWebSite.Repository.Abstract;
using VLGroupWebSite.Repository.Concrete.EntityFramework;

namespace VLGroupWebSite.Controllers
{
 
    public class ProductController : Controller
    {
        private readonly VLGroupContext context;
        public int PageSize = 20;
        private IProductRepository repository;
        public ProductController(IProductRepository _repository, VLGroupContext _context)
        {
            context = _context;
            repository = _repository;
        }
        public async Task<IActionResult> Index(int? id)
        {
            var data = repository.GetAll();
            if (id != null)
            {
            }


            return View(data);
        }


        public IActionResult List(string category, int page = 1)
        {

            var products = repository.GetAll().OrderByDescending(i => i.ProductId).Where(i => i.IsActiv == true);
            if (!string.IsNullOrEmpty(category))
            {
                products = products
                    .Include(i => i.ProductCategories)
                    .ThenInclude(i => i.Category)
                    .Where(i => i.ProductCategories.Any(a => a.Category.CategoryName == category));
            }

            var count = products.Count();
            products = products.Skip((page - 1) * PageSize).Take(PageSize);
            return View(
            new ProductListModel()
            {
                Products = products,
                PagingInfo = new PagingInfo()
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = count
                }
            });
        }

        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var query = repository
                .GetAll()
                .Where(i => i.ProductId == id)
                .Include(i => i.Images)
                .Include(i => i.Attributes)
                .Include(i => i.ProductCategories)
                .ThenInclude(i => i.Category)
                .Select(i => new ProductDetailsModel()
                {
                    Product = i,
                    ProductImages = i.Images,
                    ProductAttributes = i.Attributes,
                    Categories = i.ProductCategories.Select(a => a.Category).ToList()

                })
                .FirstOrDefault();

            return View(query);

        }
    }
}