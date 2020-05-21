using eCommerce.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Application.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int CategoryId { get; set; }
    }
}
