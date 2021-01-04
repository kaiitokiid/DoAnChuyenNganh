using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ViewModels.System.Users
{
    public class ChangePasswordRequestValidatior : AbstractValidator<ChangePasswordRequest>
    {
        public ChangePasswordRequestValidatior()
        {
            RuleFor(x => x.OldPassWord).NotEmpty().WithMessage("Mật khẩu không được để trống")
                .MinimumLength(6).WithMessage("Mật khẩu dài hơn 5 kí tự");

            RuleFor(x => x.NewPassWord).NotEmpty().WithMessage("Mật khẩu không được để trống")
                .MinimumLength(6).WithMessage("Mật khẩu dài hơn 5 kí tự");

            RuleFor(x => x).Custom((request, context) =>
            {
                if (request.NewPassWord != request.ConfirmNewPassWord)
                {
                    context.AddFailure("Xác nhận mật khẩu chưa đúng");
                }
            });
        }
    }
}
