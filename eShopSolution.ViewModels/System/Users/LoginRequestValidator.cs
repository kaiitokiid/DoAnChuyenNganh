using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ViewModels.System.Users
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Tài khoản không được để trống");


            RuleFor(x => x.PassWord).NotEmpty().WithMessage("Mật khẩu không được để trống");
                //;.MinimumLength(6).WithMessage("Mật khẩu dài hơn 5 kí tự")
        }
    }
}
