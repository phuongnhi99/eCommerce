using eCommerce.Application.Catalog.Products.Dtos;
using eCommerce.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PagedViewModel<ProductViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pageSize);
    }
}
