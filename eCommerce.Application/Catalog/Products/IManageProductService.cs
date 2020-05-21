using eCommerce.Application.Catalog.Products.Dtos;
using eCommerce.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductEditRequest request);
        Task<int> Delete(int productID);
        Task<List<ProductViewModel>> GetAll();
        Task<PagedViewModel<ProductViewModel>> GetAllPaging(string Keyword, int pageIndex, int pageSize);
    }
}
