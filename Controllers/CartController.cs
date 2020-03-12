using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VLGroupWebSite.Entity;
using VLGroupWebSite.Infrastructure;
using VLGroupWebSite.Models;
using VLGroupWebSite.Repository.Abstract;

namespace VLGroupWebSite.Controllers
{
    public class CartController : Controller
    {
        private IUnitOfWork uow;
        public CartController(IUnitOfWork _uow)
        {
            uow = _uow;
        }
        public IActionResult Index()
        {
            return View(GetCart());
        }
        public IActionResult AddToCart(int ProductId, int quantity = 1)
        {
            var product = uow.Product.Get(ProductId);

            if (product != null)
            {
                var cart = GetCart();
                cart.AddProduct(product, quantity);
                SaveCart(cart);
            }
            return RedirectToAction("Index");
        }
        public IActionResult RemoveFromCart(int ProductId)
        {
            var product = uow.Product.Get(ProductId);
            if (product != null)
            {
                var cart = GetCart();
                cart.RemoveProduct(product);
                SaveCart(cart);
            }
            return RedirectToAction("Index");
        }
        //[Authorize]
        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        //[Authorize]
        public IActionResult Checkout(OrderDetails model)
        {
            var cart = GetCart();
            if (cart.Products.Count == 0)
            {
                ModelState.AddModelError("MehsulYoxModel", "Sebetinizde mehsul tapilmir");
            }
            if (ModelState.IsValid)
            {
                SaveOrder(cart, model);
                cart.ClearAll();
                SaveCart(cart);
                return View("Completed");
            }
            return View(model);
        }
        private void SaveOrder(Cart cart, OrderDetails details)
        {
            var order = new Order();
            order.OrderNumber = "A" + (new Random()).Next(11111, 99999).ToString();
            order.OrderDate = DateTime.Now;
            order.OrderState = EnumOrderState.Waiting;
            order.UserName = User.Identity.Name;

            order.Adres = details.Adres;
            order.Telefon = details.Telefon;


            foreach (var product in cart.Products)
            {
                var orderline = new OrderLine();
                orderline.Quantity = product.Quantity;
                orderline.ProductId = product.Product.ProductId;

                order.OrderLines.Add(orderline);

            }
            uow.Orders.Add(order);
            uow.SaveChanges();


        }
        private void SaveCart(Cart cart)
        {
            HttpContext.Session.SetJson("Cart", cart);
        }

        private Cart GetCart()
        {
            return HttpContext.Session.GetJson<Cart>("Cart") ?? new Cart();
        }
    }
}