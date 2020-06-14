using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.ViewModels.System.Users
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Tên người dùng không được để trống");

            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Tên không được để trống")
                .MaximumLength(200).WithMessage("Tên không được vượt quá 200 ký tự");

            RuleFor(x => x.LastName).NotEmpty().WithMessage("Họ không được để trống")
                .MaximumLength(200).WithMessage("Họ không được vượt quá 200 ký tự");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Email không được để trống")
                .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")
                .WithMessage("Email không hợp lệ");

            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Số điện thoại không được để trống")
                .Matches(@"^((09|03|07|08|05)+([0-9]{8})\b)$")
                .WithMessage("Số điện thoại không hợp lệ");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Mật khẩu không được để trống")
                .MinimumLength(6).WithMessage("Mật khẩu không được ít hơn 6 ký tự");

            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Chưa nhập lại mật khẩu");
            RuleFor(x => x).Custom((request, context) =>
            {
                if (request.Password != request.ConfirmPassword)
                {
                    context.AddFailure("Nhập lại mật khẩu chưa đúng");
                }
            });
        }

    }
}
