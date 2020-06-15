using eCommerce.ViewModels.Catalog.ProductImages;
using eCommerce.ViewModels.Catalog.Products;
using eCommerce.ViewModels.Common;
using eCommerce.ViewModels.System.Users;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.AdminApp.Services
{
    public class ProductApiClient : IProductApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ProductApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", request.BearerToken);
            var response = await client.GetAsync($"/api/Products?PageIndex={request.PageIndex}&PageSize={request.PageSize}&CategoryIds=1");
            var body = await response.Content.ReadAsStringAsync();
            var products = JsonConvert.DeserializeObject<PagedResult<ProductViewModel>>(body);
            return products;
        }
    }
}
