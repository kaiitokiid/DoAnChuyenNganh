using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class ProductCreateRequestValidator : AbstractValidator<ProductCreateRequest>
    {
        public ProductCreateRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Tên sản phẩm không được để trống");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Giá bán không được để trống");

            RuleFor(x => x.OriginalPrice).NotEmpty().WithMessage("Giá nhập không được để trống");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Mô tả không được để trống");

            RuleFor(x => x.Details).NotEmpty().WithMessage("Chi tiết sản phẩm không được để trống");

            RuleFor(x => x.Stock).NotEmpty().WithMessage("Số lượng không được để trống");

            RuleFor(x => x.SeoAlias).NotEmpty().WithMessage("Không được để trống mục này");

            RuleFor(x => x.SeoTitle).NotEmpty().WithMessage("Không được để trống mục này");

            RuleFor(x => x.SeoDescription).NotEmpty().WithMessage("Không được để trống mục này");
        }
    }
}
