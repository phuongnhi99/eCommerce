using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerce.ViewModels.Catalog.Carts;
using Microsoft.AspNetCore.Mvc;
using myeshop.AdminApp.Services;

namespace eCommerce.WebApp.Controllers
{
    public class OrderInfoController : Controller
    {
        public IActionResult Index()
        {
            var cart = CartSession.GetObjectFromJson<List<CartItemViewModel>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Price * item.Quantity);
            return View();
        }
    }
}