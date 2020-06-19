using eCommerce.Application.Catalog.Products;
using eCommerce.ViewModels.Catalog.ProductImages;
using eCommerce.ViewModels.Catalog.Products;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eCommerce.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        //http://localhost:port/products?pageIndex=1&pageSize=10&categoryId=?
        [HttpGet/*("{languageId}")*/]
        public async Task<IActionResult> GetAllPaging([FromQuery]GetManageProductPagingRequest request)
        {
            var products = await _productService.GetAllPaging(request);
            return Ok(products);
        }

        //http://localhost:port/products/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id/*, string languageId*/)
        {
            var product = await _productService.GetById(id/*, languageId*/);
            if (product == null)
                return BadRequest("Cannot find product");
            return Ok(product);
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody]ProductCreateRequest request)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var productId = await _productService.Create(request);
            if (productId == 0)
                return BadRequest();

            var product = await _productService.GetById(productId/*, request.LanguageId*/);

            return CreatedAtAction(nameof(GetById), new {id = productId },product);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody]ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var affactedResult = await _productService.Update(request);
            if (affactedResult == 0)
                return BadRequest();
            return Ok();
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var affactedResult = await _productService.Delete(productId);
            if (affactedResult == 0)
                return BadRequest();


            return Ok();
        }


        [HttpPatch("{productId}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice(int productId, decimal newPrice)
        {
            var isSuccessful = await _productService.UpdatePrice(productId, newPrice);
            if (isSuccessful)
                return Ok();

            return BadRequest();
        }


        //ProductImage
        [HttpPost("{productId}/images")]
        public async Task<IActionResult> CreateImage(int productId, [FromForm] ProductImageCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var imageId = await _productService.AddImage(productId,request);
            if (imageId == 0)
                return BadRequest();

            var image = await _productService.GetImageById(productId);

            return CreatedAtAction(nameof(GetImageById), new { id = productId }, image);
        }

        [HttpPut("{productId}/images/{imageId}")]
        public async Task<IActionResult> UpdateImage(int imageId, [FromForm] ProductImageUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _productService.UpdateImage(imageId, request);
            if (result == 0)
                return BadRequest();
            return Ok();
        }

        [HttpDelete("{productId}/images/{imageId}")]
        public async Task<IActionResult> RemoveImage(int imageId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var affactedResult = await _productService.RemoveImage(imageId);
            if (affactedResult == 0)
                return BadRequest();


            return Ok();
        }


        //http://localhost:port/product/1
        [HttpGet("{productId}/images/{imageId}")]
        public async Task<IActionResult> GetImageById(int productId, int imageId)
        {
            var image = await _productService.GetImageById(imageId);
            if (image == null)
                return BadRequest("Cannot find product");
            return Ok(image);
        }

    }
}
