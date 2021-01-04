using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class ProductDeleteRequest
    {
        [Display(Name = "Mã sản phẩm")]
        public int Id { get; set; }

        [Display(Name="Tên sản phẩm")]
        public string Name { get; set; }

        public int MyProperty { get; set; }
    }
}
