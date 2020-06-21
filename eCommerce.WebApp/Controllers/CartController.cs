using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerce.ViewModels.Catalog.Products;
using Microsoft.AspNetCore.Mvc;
using eCommerce.ViewModels.Catalog.Carts;
using eCommerce.WebApp.Services;
using myeshop.AdminApp.Services;

namespace eCommerce.WebApp.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        public CartController(IProductApiClient productApiClient)
        {


            _productApiClient = productApiClient;
        }
        public IActionResult Index()
        {
            var cart = CartSession.GetObjectFromJson<List<CartItemViewModel>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Price * item.Quantity);
            return View();
        }

        [Route("buy/{id}")]
        public async Task<IActionResult> Buy(int id)
        {
            var result = await _productApiClient.GetProductById(id);
            var a = result;
            ProductViewModel productModel = new ProductViewModel()
            {
                Id = a.Id,
                Name = a.Name,
                Price = a.Price,
                //ImagePath = a.ImagePath
            };
            if (CartSession.GetObjectFromJson<List<CartItemViewModel>>(HttpContext.Session, "cart") == null)
            {
                List<CartItemViewModel> cart = new List<CartItemViewModel>();
                cart.Add(new CartItemViewModel { Id = 1.ToString(), Prod_ID = productModel.Id, Prod_Name = productModel.Name, Price = productModel.Price, Quantity = 1/*, ImagePath = productModel.ImagePath */});
                CartSession.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<CartItemViewModel> cart = CartSession.GetObjectFromJson<List<CartItemViewModel>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new CartItemViewModel { Prod_ID = productModel.Id, Prod_Name = productModel.Name, Price = productModel.Price, Quantity = 1/*, ImagePath = productModel.ImagePath */});
                }
                CartSession.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");
        }

        [Route("remove/{id}")]
        public IActionResult Remove(int id)
        {
            List<CartItemViewModel> cart = CartSession.GetObjectFromJson<List<CartItemViewModel>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            CartSession.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }




        private int isExist(int id)
        {
            List<CartItemViewModel> cart = CartSession.GetObjectFromJson<List<CartItemViewModel>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Prod_ID.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
    
    }
}