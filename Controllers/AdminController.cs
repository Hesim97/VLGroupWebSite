using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VLGroupWebSite.Entity;
using VLGroupWebSite.Models;
using VLGroupWebSite.Repository.Abstract;
using VLGroupWebSite.Repository.Concrete.EntityFramework;

namespace VLGroupWebSite.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly VLGroupContext _context;
        private IUnitOfWork uow;
        public AdminController(IUnitOfWork _uow, VLGroupContext context)
        {
            uow = _uow;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        // ProductCategory Index and Create

        public async Task<IActionResult> PCIndex()
        {
            var vLGroupContext = _context.ProductCategory.Include(p => p.Category).Include(p => p.Product).OrderByDescending(i=>i.ProductId).Take(25);
            return View(await vLGroupContext.ToListAsync());
        }
        public IActionResult CreatePC()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductName");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePC([Bind("CategoryId,ProductId")] ProductCategory productCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(PCIndex));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", productCategory.CategoryId);
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductName", productCategory.ProductId);
            return View(productCategory);
        }


        // Kategoriya Edit

        public async Task<IActionResult> CatEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CatEdit(int id, [Bind("CategoryId,CategoryName")] Category category)
        {
            if (id != category.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.CategoryId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(CatalogList));
            }
            return View(category);
        }

        public async Task<IActionResult> CatDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("CatDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CatDeleteConfirmed(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(CatalogList));
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.CategoryId == id);
        }


        //Product Edit
        public async Task<IActionResult> PrEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PrEdit(int id,Product product,IFormFile file)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                        product.Image = file.FileName;
                    }
                }
                product.Image = file.FileName;
                product.ProductId = id;
                product.DateAdded = DateTime.Now;
                product.Price = 0;            
                _context.Products.Update(product);
                _context.SaveChanges();
                return RedirectToAction("CatalogList");
            } 
            return View(product);
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }


        //[HttpGet]
        //public IActionResult EditCategory(int id)
        //{
        //    var entity = uow.Categories.GetAll()
        //        .Include(i => i.ProductCategories)
        //        .ThenInclude(i => i.Product)
        //        .Where(i => i.CategoryId == id)
        //        .Select(i => new AdminEditCategoryModel()
        //        {
        //            CategoryId = i.CategoryId,
        //            CategoryName = i.CategoryName,
        //            Products = i.ProductCategories.Select(a => new AdminEditProductModel()
        //            {
        //                ProductId = a.ProductId,
        //                ProductName = a.Product.ProductName,
        //                Image = a.Product.Image,
        //                IsActiv = a.Product.IsActiv,
        //                IsHome = a.Product.IsHome,
        //            }).ToList()
        //        }).FirstOrDefault();
        //    return View(entity);
        //}
        //[HttpPost]
        //public IActionResult EditCategory(Category entity)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        uow.Categories.Edit(entity);
        //        uow.SaveChanges();
        //        return RedirectToAction("CatalogList");
        //    }
        //    return View(entity);
        //}

        // Kategoriyaya aid mehsulu silmek

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RemoveFromCategory(int ProductId,int CategoryId)
        {
            if (ModelState.IsValid)
            {
                uow.Categories.RemoveFromCategory(ProductId, CategoryId);
                uow.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }


        // Admin Index

        public IActionResult CatalogList(int? page)
        {
            var model = new CatalogListModel()
            {
                Categories = uow.Categories.GetAll().ToList(),
                Products = uow.Product.GetAll().ToList()
            };
            return View(model);
        }
        
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category entity)
        {
            if (ModelState.IsValid)
            {
                uow.Categories.Add(entity);
                uow.SaveChanges();
                return RedirectToAction("CatalogList");
            }
                return View(entity);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult AddCategory(Category entity)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        uow.Categories.Add(entity);
        //        uow.SaveChanges();

        //        return Ok(entity);
        //    }
        //    return BadRequest();
        //}



            // Add Product

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(Product entity,IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null) 
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create)) 
                    {
                        await file.CopyToAsync(stream);
                        entity.Image = file.FileName;
                    }
                }
                entity.DateAdded = DateTime.Now;
                entity.Price = 0;
                entity.IsActiv = true;
                entity.IsHome = true;
                uow.Product.Add(entity);
                uow.SaveChanges();
               return  RedirectToAction("CatalogList");
            }
            return View(entity);
        }

        // Delete Product

        public async Task<IActionResult> PrDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost, ActionName("PrDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PrDeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(CatalogList));
        }

        
        /// Image Index
        public async Task<IActionResult> ImIndex()
        {
            var vLGroupContext = _context.Images.Include(i => i.Product).OrderByDescending(i=>i.ImageId).Take(15);
            return View(await vLGroupContext.ToListAsync());
        }



          /// Add Images
           
        public IActionResult ImCreate()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ImCreate( Image image, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                        image.ImageName = file.FileName;
                    }
                    _context.Add(image);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(ImIndex));
                }
               ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductName", image.ProductId);
              
            } 
             return View(image);
        }

        // Image Delete

        public async Task<IActionResult> ImDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await _context.Images
                .Include(i => i.Product)
                .FirstOrDefaultAsync(m => m.ImageId == id);
            if (image == null)
            {
                return NotFound();
            }

            return View(image);
        }

        
        [HttpPost, ActionName("ImDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ImDeleteConfirmed(int id)
        {
            var image = await _context.Images.FindAsync(id);
            _context.Images.Remove(image);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ImIndex));
        }

        //Orders Index

        public async Task<IActionResult> OrIndex()
        {
            return View(await _context.Orders.OrderByDescending(i => i.OrderId).Take(10).ToListAsync());
        }

        //Orders Delete

        public async Task<IActionResult> OrDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        [HttpPost, ActionName("OrDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OrDeleteConfirmed(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(OrIndex));
        }

        //Atribut Index

        public async Task<IActionResult> AtrIndex()
        {
            var vLGroupContext = _context.Attributes.Include(p => p.Product).OrderByDescending(i=>i.ProductAttributeId).Take(15);
            return View(await vLGroupContext.ToListAsync());
        }

        public IActionResult AtrCreate()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AtrCreate([Bind("ProductAttributeId,Attribute,Value,ProductId")] ProductAttribute productAttribute)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productAttribute);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AtrIndex));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductName", productAttribute.ProductId);
            return View(productAttribute);
        }

        //Atr Delete

        public async Task<IActionResult> AtrDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productAttribute = await _context.Attributes
                .Include(p => p.Product)
                .FirstOrDefaultAsync(m => m.ProductAttributeId == id);
            if (productAttribute == null)
            {
                return NotFound();
            }

            return View(productAttribute);
        }
        [HttpPost, ActionName("AtrDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AtrDeleteConfirmed(int id)
        {
            var productAttribute = await _context.Attributes.FindAsync(id);
            _context.Attributes.Remove(productAttribute);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AtrIndex));
        }


    }
}