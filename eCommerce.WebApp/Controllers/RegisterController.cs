using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerce.ViewModels.System.Users;
using eCommerce.WebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace eCommerce.WebApp.Controllers
{
    public class RegisterController : BaseController
    {
        private readonly IUserApiClient _userApiClient;
        //private readonly IConfiguration _configuration;
        //private readonly IRoleApiClient _roleApiClient;

        public RegisterController(IUserApiClient userApiClient, IRoleApiClient roleApiClient, IConfiguration configuration)
        {
            _userApiClient = userApiClient;
            //_roleApiClient = roleApiClient;
            //_configuration = configuration;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterRequest request)
        {
            if (!ModelState.IsValid)
                return View();
            var result = await _userApiClient.RegisterUser(request);
            if (result.IsSuccessed)
                return RedirectToAction("Index");
            ModelState.AddModelError("", result.Message);
            return View();
        }
    }
}
