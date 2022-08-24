using System.ComponentModel.DataAnnotations;

namespace BuyGroceriesOnline.Models
{
    public class ProductMini
    {
        [Key]
        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Display(Name = "Price in INR")]
        public decimal Price { get; set; }

        [Display(Name = "Take A look")]
        public string ImageThumbnailUrl { get; set; }

    }
}
