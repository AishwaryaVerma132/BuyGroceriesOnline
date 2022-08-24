using GroceryAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroceryAPI.Controllers
{
    [ApiController]
    [Route("Category")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        [Route("AllCategories")]
        public IActionResult AllCategories()
        {
            try
            {
                var AllCategories = _categoryRepository.AllCategories;
                return Ok(AllCategories);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }

        [HttpGet]
        [Route("GetCategory")]
        public ActionResult<IEnumerable<Category>> GetCategory(int categoryId = 1)
        {
            try
            {
                var Category = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == categoryId);
                return Ok(Category);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }

        [HttpPost]
        [Route("InsertCategory")]
        public IActionResult InsertCategory(Category category)
        {
            try
            {
                var insertCategory = _categoryRepository.InsertCategory(category);
                return Ok(insertCategory);
            }

            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }

        [HttpPut]
        [Route("UpdateCategory")]
        public IActionResult UpdateCategory(Category category)
        {
            try
            {
                var updateCategory = _categoryRepository.UpdateCategory(category);
                return Ok(updateCategory);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }

        [HttpDelete]
        [Route("DeleteCategory")]
        public IActionResult DeleteCategory(int categoryId)
        {
            try
            {
                var categories = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == categoryId);
                if (categories == null)
                {
                    return BadRequest("Category ID Not Found");
                }
                var deleteCategory = _categoryRepository.DeleteCategory(categoryId);
                return Ok(deleteCategory);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
    }
}
