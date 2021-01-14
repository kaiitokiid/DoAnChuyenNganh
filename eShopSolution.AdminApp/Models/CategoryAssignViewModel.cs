using eShopSolution.ViewModels.Catalog.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.AdminApp.Models
{
    public class CategoryAssignViewModel
    {
        public CategoryAssignRequest CategoryAssign { get; set; }

        public string ProductName { get; set; }
    }
}
