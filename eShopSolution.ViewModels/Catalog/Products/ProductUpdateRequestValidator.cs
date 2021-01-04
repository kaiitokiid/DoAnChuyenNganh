using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class ProductUpdateRequestValidator : AbstractValidator<ProductUpdateRequest>
    {
        public ProductUpdateRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Tên sản phẩm không được để trống");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Mô tả không được để trống");

            RuleFor(x => x.Details).NotEmpty().WithMessage("Chi tiết sản phẩm không được để trống");

            RuleFor(x => x.SeoAlias).NotEmpty().WithMessage("Không được để trống mục này");

            RuleFor(x => x.SeoTitle).NotEmpty().WithMessage("Không được để trống mục này");

            RuleFor(x => x.SeoDescription).NotEmpty().WithMessage("Không được để trống mục này");
        }
    }
}
