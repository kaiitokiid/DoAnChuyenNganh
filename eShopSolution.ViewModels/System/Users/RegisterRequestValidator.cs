using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ViewModels.System.Users
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Tên không được để trống")
                .MaximumLength(200).WithMessage("Không được dài quá 200 kí tự");

            RuleFor(x => x.LastName).NotEmpty().WithMessage("Họ không được để trống")
                .MaximumLength(200).WithMessage("Không được dài quá 200 kí tự");

            RuleFor(x => x.Dob).GreaterThan(DateTime.Now.AddYears(-100)).WithMessage("Ngày sinh chưa đúng định dạng");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Email không được để trống")
                .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").WithMessage("Email chưa đúng định dạng");

            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Số điện thoại không được để trống");

            RuleFor(x => x.UserName).NotEmpty().WithMessage("Tài khoản không được để trống");

            RuleFor(x => x.PassWord).NotEmpty().WithMessage("Mật khẩu không được để trống")
                .MinimumLength(6).WithMessage("Mật khẩu dài hơn 5 kí tự");

            RuleFor(x => x).Custom((request, context) =>
            {
                if(request.PassWord != request.ConfirmPassWord)
                {
                    context.AddFailure("Xác nhận mật khẩu chưa đúng");
                }
            });
        }
    }
}
