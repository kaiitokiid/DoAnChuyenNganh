using eShopSolution.ApiIntegration;
using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Sales;
using eShopSolution.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly ICategoryApiClient _categoryApiClient;

        public ProductController(IProductApiClient productApiClient, ICategoryApiClient categoryApiClient)
        {
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IActionResult> Detail(int id, string culture)
        {
            var product = await _productApiClient.GetById(id, culture);

            return View(new ProductDetailViewModel()
            { 
                Product = product,
                Category = await _categoryApiClient.GetById(culture, id),
                
            });
        }

        public async Task<IActionResult> Category(int id, string culture, string keyword, decimal? minPrice, decimal? maxPrice, int pageIndex = 1, int pageSize = 12)
        {
            var products = await _productApiClient.GetProductPagings(new GetManageProductPagingRequest()
            {
                CategoryId = id,
                PageIndex = pageIndex,
                LanguageId = culture,
                PageSize = pageSize,
                MinPrice = minPrice,
                MaxPrice = maxPrice,
                KeyWord = keyword,
            });

            ViewBag.Keyword = keyword;
            ViewBag.MinPrice = minPrice;
            ViewBag.MaxPrice = maxPrice;

            return View(new ProductCategoryViewModel()
            {
                Category = await _categoryApiClient.GetById(culture, id),
                Products = products
            });
        }
    }
}
