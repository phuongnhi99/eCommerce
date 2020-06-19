using eCommerce.ViewModels.Catalog.ProductImages;
using eCommerce.ViewModels.Catalog.Products;
using eCommerce.ViewModels.Common;
using eCommerce.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.WebApp.Services
{
    public interface IProductApiClient
    {
        Task<ApiResult<ProductViewModel>> GetById(int id);
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);
        Task<ApiResult<bool>> CreateProduct(ProductCreateRequest request);
        Task<ApiResult<bool>> UpdateProduct(int id, ProductUpdateRequest request);
    }
}