using AutoMapper;
namespace BuyGroceriesOnline.Models
{
    public class MappingProfileMVC : Profile
    {
        public MappingProfileMVC()
        {
            this.CreateMap<Product, ProductMini>();
        }
    }
}