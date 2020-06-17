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
    public class CategoryController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly IConfiguration _configuration;

        public CategoryController(IProductApiClient productApiClient, IConfiguration configuration)
        {
            _productApiClient = productApiClient;
            _configuration = configuration;
        }

        public async Task<IActionResult> Category(List<int> categoryId, int pageIndex = 1, int pageSize = 10)
        {
            var list = new List<int>() { 1 };
            var sessions = HttpContext.Session.GetString("Token");
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
    }
}
