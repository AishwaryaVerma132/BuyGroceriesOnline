using Microsoft.EntityFrameworkCore;

namespace GroceryAPI.Models
{
    public class ProductRepository : IProductRepository
    {
        public readonly AppDbContext _appDbContext;
        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Product> AllProduct => _appDbContext.Products;
        public IEnumerable<Product> ProductOfTheWeek => _appDbContext.Products.Where(product => product.IsProductOfTheWeek);

        public Product GetProductById(int productId)
        {
            return AllProduct.FirstOrDefault(product => product.ProductId == productId);
        }

        public Product InsertProduct(Product product)
        {
            var insertProduct = _appDbContext.Products.Add(product);
            _appDbContext.SaveChanges();
            return insertProduct.Entity;
        }

        public Product UpdateProduct(Product product)
        {
            var updateProduct = _appDbContext.Products.Update(product);
            _appDbContext.SaveChanges();
            return updateProduct.Entity;
        }

        public Product DeleteProduct(int productId)
        {
            var deleteProduct = AllProduct.FirstOrDefault(product => product.ProductId == productId);
            var delete = _appDbContext.Products.Remove(deleteProduct);
            _appDbContext.SaveChanges();
            return delete.Entity;
        }
    }
}