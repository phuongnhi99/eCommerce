using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eCommerce.ViewModels.Catalog.Products
{
    public class ProductViewModel
    {
        public int Id { set; get; }
        [Display(Name = "Giá bán")]
        public decimal Price { set; get; }
        [Display(Name = "Giá nhập")]
        public decimal OriginalPrice { set; get; }
        [Display(Name = "Số lượng nhập")]
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        [Display(Name = "Tên sản phẩm")]
        public string Name { set; get; }
        [Display(Name = "Thông tin sản phẩm")]
        public string Description { set; get; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { get; set; }
        public string LanguageId { set; get; }
    }
}
