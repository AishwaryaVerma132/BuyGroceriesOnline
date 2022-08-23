using BuyGroceriesOnline.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BuyGroceriesOnline.Controllers
{
    public class FilterController : Controller
    {
        private readonly IProductRepository _productRepository;
        public FilterController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        private IEnumerable<Product> GetAllProduct()
        {
            return _productRepository.AllProduct;
        }
        public ViewResult FilterPriceUp()
        {
            var product = GetAllProduct().OrderBy(p => p.Price);
            return View(product);
        }

        public ViewResult FilterPriceDown()
        {
            var product = GetAllProduct().OrderByDescending(p => p.Price);
            return View(product);
        }

        public ViewResult FilterStock()
        {
            var product = GetAllProduct().Where(p => p.InStock);
            return View(product);
        }
        public ViewResult FilterBrand()
        {
            var product = GetAllProduct().OrderBy(p=>p.Brand);
            return View(product);
        }
    }
}
