using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace GroceryAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Display(Name = "Brand Name")]
        public string Brand { get; set; }

        [Display(Name = "Short Description")]
        public string ShortDescription { get; set; }

        [Display(Name = "Long Description")]
        public string LongDescription { get; set; }

        [Display(Name = "Price in INR")]
        public decimal Price { get; set; }
        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [Display(Name = "Take A look")]
        public string ImageThumbnailUrl { get; set; }

        [Display(Name = "Best Seller ")]
        public bool IsProductOfTheWeek { get; set; }

        [Display(Name = "In Stock")]
        public bool InStock { get; set; }
        [Display(Name = "Category Id")]
        public int CategoryId { get; set; }
        [BindNever]
        [ValidateNever]
        public Category Category { get; set; }
    }
}
