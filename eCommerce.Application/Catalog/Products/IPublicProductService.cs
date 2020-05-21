using eCommerce.Application.Catalog.Products.Dtos;
using eCommerce.Application.Catalog.Products.Dtos.Public;
using eCommerce.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PagedResult<ProductViewModel> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
