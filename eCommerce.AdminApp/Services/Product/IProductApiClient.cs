using eCommerce.ViewModels.Catalog.ProductImages;
using eCommerce.ViewModels.Catalog.Products;
using eCommerce.ViewModels.Common;
using eCommerce.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.AdminApp.Services
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductViewModel>>GetAllPaging(GetManageProductPagingRequest request);
        Task<ApiResult<bool>> CreateProduct(ProductCreateRequest request);
        Task<ApiResult<bool>> UpdateProduct(ProductUpdateRequest request);
        Task<ApiResult<bool>> Delete(int id);
        Task<ProductViewModel> GetProductById(int id);
    }
}