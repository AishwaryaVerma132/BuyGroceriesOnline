using AutoMapper;
using BuyGroceriesOnline.Models;
using BuyGroceriesOnline.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace BuyGroceriesOnline.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }


        private IEnumerable<Product> GetAllProduct()
        {
            return _productRepository.AllProduct;
        }

        public IActionResult List(int id)
        {
            IEnumerable<Product> product;
            CustomClass customClass = new CustomClass();
            if (id > 0)
            {
                product = GetAllProduct().Where(p => p.CategoryId == id);
                var category = _categoryRepository.AllCategories.Where(c => c.CategoryId == id).FirstOrDefault();
                customClass.CurrentCategory = category.CategoryName;
                customClass.CategoryDescription = category.Description ;
            }
            else
            {
                product = GetAllProduct();
                customClass.CurrentCategory = "List Of Products";
                customClass.CategoryDescription = "";
            }

            customClass.Products = product;
            return View(customClass);
        }

        public IActionResult ListCategory()
        {
            var categoryList = _categoryRepository.AllCategories;
            return View(categoryList);
        }

        public IActionResult SearchButton(string Name)
        {
            IEnumerable<Product> product = new List<Product>();
            product = _productRepository.AllProduct.Where(s => s.Name.ToUpper().Contains(Name.ToUpper()));

            if (String.IsNullOrEmpty(Name))
            {
                TempData["error"] = "Enter Product Name!";
                return RedirectToAction("List");
            }
            else if (product != null)
            {
                return View(product);
                
            }
            TempData["error"] = "No such Product exists!";
            return RedirectToAction("List");
        }

        public IActionResult ProductOfWeek()
        {
            return View(_productRepository.ProductOfTheWeek);
        }

        [Authorize]
        public IActionResult Details(int id)
        {
            return View(GetAllProduct().FirstOrDefault(p => p.ProductId == id));
        }

        public IActionResult ListMini() //invoking this method from url
        {
            var products = _productRepository.AllProduct;
            var miniProduct = _mapper.Map<ProductMini[]>(products);

            return View(miniProduct);
        }

        // Crud Operations

        public void CategoryItem()
        {
            var categories = _categoryRepository.AllCategories;
            List<SelectListItem> categoryItems = new List<SelectListItem>();
            foreach (var category in categories)
            {
                categoryItems.Add(new SelectListItem { Text = category.CategoryName, Value = category.CategoryId.ToString() });
            }
            ViewBag.categoryItems = categoryItems;
        }

        public ViewResult Create()
        {
            CategoryItem();
            return View();
        }

        [HttpPost]
        public IActionResult InsertItem(Product product)
        {
            _productRepository.InsertProduct(product);
            return RedirectToAction("List");
        }

        public ViewResult Edit(int id)
        {
            CategoryItem();
            var product = GetAllProduct().FirstOrDefault(p => p.ProductId == id);
            return View(product);
        }

        [HttpPost]
        public IActionResult UpdateItem(Product product)
        {
            _productRepository.UpdateProduct(product);
            return RedirectToAction("List");
        }

        public ViewResult Delete(int id)
        {
            var product = GetAllProduct().FirstOrDefault(p => p.ProductId == id);
            return View(product);
        }

        [HttpPost]
        public IActionResult DeleteItem(int productId)
        {
            _productRepository.DeleteProduct(productId);
            return RedirectToAction("List");
        }      

    }
}
