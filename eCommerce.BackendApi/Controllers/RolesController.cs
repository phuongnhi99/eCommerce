using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerce.Application.System.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   /* [Authorize]*/
    public class RolesController : ControllerBase
    {
        private readonly IRoleSevice _roleService;

        public RolesController(IRoleSevice roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var roles = await _roleService.GetAll();
            return Ok(roles);
        }
    }
}
