using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.ViewModels.Catalog.Products
{
    public class CreateRequestValidator : AbstractValidator<ProductCreateRequest>
    {
        public CreateRequestValidator()
        {
            RuleFor(x => x.Price).NotEmpty().WithMessage("Giá bán không được để trống");
            RuleFor(x => x.OriginalPrice).NotEmpty().WithMessage("Giá nhập không được để trống");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Số lượng không được để trống");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Tên sản phẩm không được để trống");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Thông tin sản phẩm không được để trống");
        }
    }
}
