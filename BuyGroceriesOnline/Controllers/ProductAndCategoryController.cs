using BuyGroceriesOnline.Models;
using BuyGroceriesOnline.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BuyGroceriesOnline.Controllers
{
    public class ProductAndCategoryController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IConfiguration configuration;
        string baseAddress;

        public ProductAndCategoryController(IProductRepository productRepository, IConfiguration configuration, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            this.configuration = configuration;
            this.baseAddress = configuration.GetValue<string>("BaseAddress");
            _categoryRepository = categoryRepository;
        }

        private IEnumerable<Product> GetAllProducts()
        {
            var products = ProductAPIData.GetApiData(baseAddress + "List");
            return products.Result;
        }

        public IActionResult ListAPI(int id)
        {
            IEnumerable<Product> product;
            CustomClass customClass = new CustomClass();
            if (id > 0)
            {
                product = GetAllProducts().Where(p => p.CategoryId == id);
                var category = _categoryRepository.AllCategories.Where(c => c.CategoryId == id).FirstOrDefault();
                customClass.CurrentCategory = category.CategoryName;
                customClass.CategoryDescription = category.Description;
            }
            else
            {
                product = GetAllProducts();
                customClass.CurrentCategory = "List Of Products";
                customClass.CategoryDescription = "";
            }

            customClass.Products = product;
            return View(customClass);
        }

        public async Task<IActionResult> ProductOfTheWeekAPI()
        {
           

            var products = ProductAPIData.GetApiData(baseAddress + "ProductOfTheWeek");
            CustomClass CustomModel = new CustomClass();
            CustomModel.Products = products.Result;

            return View(CustomModel);
        }

        public IActionResult DetailsAPI(int id)
        {
            var GetProductById = ProductAPIData.GetApiData(baseAddress + "List").Result.FirstOrDefault(p => p.ProductId == id);
            return View(GetProductById);
        }

        public IActionResult AllCategoriesAPI()
        {
            var categories = ProductAPIData.GetCategoryApiData("https://localhost:7013/Category/AllCategories");
            return View(categories.Result);
        }
    }
}
 