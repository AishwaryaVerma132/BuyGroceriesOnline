namespace BuyGroceriesOnline.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProduct { get; }
        IEnumerable<Product> ProductOfTheWeek { get; }
        Product GetProductById(int productId);
        public Product InsertProduct(Product products);
        public Product UpdateProduct(Product products);
        public Product DeleteProduct(int productId);
    }
}
