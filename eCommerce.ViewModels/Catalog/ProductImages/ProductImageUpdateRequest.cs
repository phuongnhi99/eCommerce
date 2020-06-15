using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.ViewModels.Catalog.ProductImages
{
    public class ProductImageUpdateRequest
    {
        public string Caption { get; set; }
        public bool IsDefault { get; set; }
        public int SortOrder { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
