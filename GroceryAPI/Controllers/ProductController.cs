using GroceryAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroceryAPI.Controllers
{
    [ApiController]
    [Route("Product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        [Route("List")]
        public IActionResult List()      
        {
            try
            {
                var product = _productRepository.AllProduct;
                return Ok(product);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }

        [HttpGet]
        [Route("ProductOfTheWeek")]
        public IActionResult ProductOfTheWeek()
        {
            try
            {
                var ProductOfWeek = _productRepository.ProductOfTheWeek;
                return Ok(ProductOfWeek);
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }

        }

        [HttpGet("{id}", Name = "Details")]
        public IActionResult Details(int id)
        {
            try
            {
                var GetProductById = _productRepository.GetProductById(id);
                if (GetProductById == null)
                {
                    return NotFound("Product Not Found");
                }
                return Ok(GetProductById);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
        
        [HttpPost]
        [Route("InsertProduct")] 
        public IActionResult InsertProduct(Product product)
        {
            try
            {
                var insertProduct = _productRepository.InsertProduct(product);
                return Ok(insertProduct);
            }

            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }

        [HttpPut]
        [Route("UpdateProduct")]
        public IActionResult UpdateProduct(Product product)
        {
            try
            {
                var updateProduct = _productRepository.UpdateProduct(product);
                return Ok(updateProduct);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }

        [HttpDelete]
        [Route("DeleteProduct")]
        public IActionResult DeleteProduct(int productId)
        {
            try
            {
                var products = _productRepository.AllProduct.FirstOrDefault(p => p.ProductId == productId);
                if (products == null)
                {
                    return BadRequest("Product ID Not Found");
                }
                var deleteProduct = _productRepository.DeleteProduct(productId);
                return Ok(deleteProduct);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
    }
}
