using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerce.AdminApp.Services;
using eCommerce.ViewModels.Catalog.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace eCommerce.AdminApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly IConfiguration _configuration;

        public ProductController(IProductApiClient productApiClient, IConfiguration configuration)
        {
            _productApiClient = productApiClient;
            _configuration = configuration;
        }

        public async Task<IActionResult> Product(List<int> categoryId , int pageIndex = 1, int pageSize = 10)
        {
            var list = new List<int>() { 1 };
           /// var sessions = HttpContext.Session.GetString("Token");
            var request = new GetManageProductPagingRequest()
            {
                //BearerToken = sessions,
                CategoryIds = list,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _productApiClient.GetAllPaging(request);
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _productApiClient.CreateProduct(request);
            if (result.IsSuccessed)
                return RedirectToAction("Product");
            ModelState.AddModelError("", result.Message);
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            
            var result = await _productApiClient.GetById(id);
            if (result.IsSuccessed)
            {
                var product = result.ResultObj;
                var updateRequest = new ProductUpdateRequest()
               /* {
                    Description = "Beo",
                    Name = "Beo",
                    Price = 40000,
                    OriginalPrice = 20000,
                    Stock = 100,
                    Id = 1
                };*/
                {
                    Description = product.Description,
                     Name = product.Name,
                     Price = product.Price,
                     OriginalPrice = product.OriginalPrice,
                     Stock = product.Stock,
                     Id = id
                 };
                return View(updateRequest);
            }
            return RedirectToAction("Error", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return View();
            var result = await _productApiClient.UpdateProduct(request.Id, request);
            if (result.IsSuccessed)
                return RedirectToAction("Index");
            ModelState.AddModelError("", result.Message);
            return View(request);
        }
    }
}
