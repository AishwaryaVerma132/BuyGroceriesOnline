using BuyGroceriesOnline.Models;
using Microsoft.AspNetCore.Mvc;

namespace BuyGroceriesOnline.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        private IEnumerable<Category> AllCategories()
        {
            return _categoryRepository.AllCategories;
        }
        public IActionResult CategoryList()
        {
            return View(AllCategories());
        }

        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertItem(Category category)
        {
            _categoryRepository.InsertCategory(category);
            return RedirectToAction("CategoryList");
        }

        public ViewResult Edit(int id)
        {
            var category = AllCategories().FirstOrDefault(p => p.CategoryId == id);
            return View(category);
        }

        [HttpPost]
        public IActionResult UpdateItem(Category category)
        {
            _categoryRepository.UpdateCategory(category);
            return RedirectToAction("CategoryList");
        }

        public ViewResult Delete(int id)
        {
            var category = AllCategories().FirstOrDefault(p => p.CategoryId == id);
            return View(category);
        }

        [HttpPost]
        public IActionResult DeleteItem(int categoryId)
        {
            _categoryRepository.DeleteCategory(categoryId);
            return RedirectToAction("CategoryList");
        }
    }
}
