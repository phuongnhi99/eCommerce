using eCommerce.ViewModels.Catalog.ProductImages;
using eCommerce.ViewModels.Catalog.Products;
using eCommerce.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Catalog.Products
{
    public interface IProductService
    {
        //Product
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);
        Task<ProductViewModel> GetById(int productId, string languageId);
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productID);
       //Update
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        
        Task AddViewCount(int productId);

        //ProductImage
        Task<ProductImageViewModel> GetImageById(int imageId);
        Task<int> AddImage(int productId, ProductImageCreateRequest request);
        Task<int> RemoveImage(int imageId);
        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);
        Task<List<ProductImageViewModel>> GetListImage(int productId);
      
    }
}
