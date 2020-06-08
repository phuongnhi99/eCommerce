using eCommerce.Application.Catalog.Products;
using eCommerce.ViewModels.Catalog.Products;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eCommerce.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IPublicProductService _PublicProductService;
        private readonly IManageProductService _manageProductService;
        public ProductController(IPublicProductService PublicProductService, IManageProductService manageProductService)
        {
            _PublicProductService = PublicProductService;
            _manageProductService = manageProductService;
        }

        //http://localhost:port/product
        [HttpGet("{languageId}")]
        public async Task <IActionResult> Get(string languageId)
        {
            var products = await _PublicProductService.GetAll(languageId);
            return Ok(products);
        }

        //http://localhost:port/product/public-paging
        [HttpGet("public-paging/{languageId}")]
        public async Task<IActionResult> Get([FromQuery]GetPublicProductPagingRequest request)
        {
            var products = await _PublicProductService.GetAllByCategoryId(request);
            return Ok(products);
        }

        //http://localhost:port/product/1
        [HttpGet("{id}/{languageId}")]
        public async Task<IActionResult> GetById(int id, string languageId)
        {
            var product = await _manageProductService.GetById(id, languageId);
            if (product == null)
                return BadRequest("Cannot find product");
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm]ProductCreateRequest request)
        {
            var productId = await _manageProductService.Create(request);
            if (productId == 0)
                return BadRequest();

            var product = await _manageProductService.GetById(productId, request.LanguageId);

            return CreatedAtAction(nameof(GetById), new {id = productId },product);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody]ProductUpdateRequest request)
        {
            var affactedResult = await _manageProductService.Update(request);
            if (affactedResult == 0)
                return BadRequest();


            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var affactedResult = await _manageProductService.Delete(id);
            if (affactedResult == 0)
                return BadRequest();


            return Ok();
        }


        [HttpPut("price/{id}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice([FromQuery] int id, decimal newPrice)
        {
            var isSuccessful = await _manageProductService.UpdatePrice(id, newPrice);
            if (isSuccessful)
                return Ok();

            return BadRequest();
        }

    }
}
