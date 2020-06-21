using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using eCommerce.WebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using eCommerce.ViewModels.Catalog.Products;
using eCommerce.WebApp.Services;

namespace eCommerce.WebApp.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly IConfiguration _configuration;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IProductApiClient productApiClient, IConfiguration configuration)
        {
            _logger = logger;
            _productApiClient = productApiClient;
            _configuration = configuration;
        }

        public IActionResult Product()
        {
            var user = User.Identity.Name;
            return View();
        }

        public async Task<IActionResult> Index( string keyword,List<int> categoryId, int pageIndex = 1, int pageSize = 10)
        {
            var list = new List<int>() { 1 };
            /// var sessions = HttpContext.Session.GetString("Token");
            var request = new GetManageProductPagingRequest()
            {
                Keyword = keyword,
                //BearerToken = sessions,
                CategoryIds = list,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _productApiClient.GetAllPaging(request);
            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }



        [HttpGet]
        public async Task<IActionResult> Detail(int id )
        {

            var result = await _productApiClient.GetProductById(id);
            if (result != null)
            {
                var product = result;
                var updateRequest = new ProductViewModel()
                /*{
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


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
