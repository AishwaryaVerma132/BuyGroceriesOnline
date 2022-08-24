using Microsoft.EntityFrameworkCore;
using GroceryAPI.Models;

namespace GroceryAPI.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Fruits", Description = "Fruits are a rich source of vitamins, minerals, fibres and proteins. " });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Vegetables", Description = "Vegetables contain many vitamins and minerals that are good for your health." });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Cereals", Description = "We should eat fresh fruits to keep ourselves healthy. " });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Snacks Store", Description = "These include vitamins A (beta-carotene), C and E, magnesium, zinc, phosphorous and folic acid." });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Beverages", Description = "But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. " });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 6, CategoryName = "Cleaning & Household", Description = "We should eat fresh fruits to keep ourselves healthy. But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. " });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 7, CategoryName = "Beauty & Makeup", Description = "These include vitamins A (beta-carotene), C and E, magnesium, zinc, phosphorous and folic acid." });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Kiwi (3 units)",
                Price = 66,
                ShortDescription = "Onion is a round vegetable with a brown skin that grows underground.",
                LongDescription =
                    "Onion is a vegetable which is almost like a staple in Indian food. This is also known to be one of the essential ingredients of raw salads. They come in different colours like white, red or yellow and are quite in demand in cold salads and hot soups.",
                CategoryId = 1,
                ImageUrl = "https://media.istockphoto.com/photos/plums-fresh-plums-picture-id1257344030?k=20&m=1257344030&s=612x612&w=0&h=5bzcEVyMttyc-EkEZebmu-JFOakMQoqiOTOmxVDln2s=",
                InStock = true,
                ImageThumbnailUrl = "https://media.istockphoto.com/photos/red-cherry-plum-with-green-leaves-isolated-on-white-background-picture-id687478414?k=20&m=687478414&s=612x612&w=0&h=eI2g4RbgFznJDVsUvmu5JkrG16XupOLxIrT3xRxMKJ8=",
                Brand = "Unbranded",
            });


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 11,
                Name = "Fresh Onion (1 kg)",
                Price = 26,
                ShortDescription = "Onion is a round vegetable with a brown skin that grows underground.",
                LongDescription =
                    "Onion is a vegetable which is almost like a staple in Indian food. This is also known to be one of the essential ingredients of raw salads. They come in different colours like white, red or yellow and are quite in demand in cold salads and hot soups.",
                CategoryId = 2,
                ImageUrl = "https://rukminim1.flixcart.com/image/832/832/jtsz3bk0/vegetable/k/y/d/5-onion-un-branded-no-whole-original-imafdsyg4ykqcyt4.jpeg?q=70",
                InStock = true,
                ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/jtsz3bk0/vegetable/k/y/d/5-onion-un-branded-no-whole-original-imafdsyg4ykqcyt4.jpeg?q=70",
                Brand = "Organic",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 12,
                Name = "Fresh Potato (1 kg)",
                Price = 37,
                ShortDescription = "If you are looking for soft, slightly sweet but creamy-textured potatoes. You're at right place!",
                LongDescription =
                "These are a special variant early harvest of potatoes and are easily distinguishable with their thin/ tender skin which makes them easy-to-peel off even it can be used without peeling.  ",
                CategoryId = 2,
                ImageUrl = "https://rukminim1.flixcart.com/image/832/832/jtsz3bk0/vegetable/b/8/4/2-potato-un-branded-no-whole-original-imafdsymh2aepaph.jpeg?q=70",
                InStock = true,
                ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/jtsz3bk0/vegetable/b/8/4/2-potato-un-branded-no-whole-original-imafdsymh2aepaph.jpeg?q=70",
                Brand = "Organic",
            });

            modelBuilder.Entity<Product>().HasData(new Product //fruit
            {
                ProductId = 13,
                Name = "Cabbage, 1 Units  (500 – 800gm)",
                Price = 26,
                ShortDescription = "If you are looking for soft, slightly sweet but creamy-textured potatoes. You're at right place!",
                LongDescription =
                "These are a special variant early harvest of potatoes and are easily distinguishable with their thin/ tender skin which makes them easy-to-peel off even it can be used without peeling.",
                CategoryId = 2,
                ImageUrl = "https://rukminim1.flixcart.com/image/832/832/km9ht3k0/vegetable/y/o/3/cabbage-unbranded-whole-no-original-imagf7fpazpgzcwm.jpeg?q=70",
                InStock = true,
                ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/km9ht3k0/vegetable/y/o/3/cabbage-unbranded-whole-no-original-imagf7fpazpgzcwm.jpeg?q=70",
                Brand = "Organic",
            });


            modelBuilder.Entity<Product>().HasData(new Product //fruit
            {
                ProductId = 15,
                Name = "Carrot (500 g)",
                Price = 71,
                ShortDescription = "If you are looking for soft, slightly sweet but creamy-textured potatoes. You're at right place!",
                LongDescription =
                "Carrots are a great addition to soups and stews, appetizers and hors d'oeuvres, side dishes and salads. They can be roasted in the oven or boiled on the stove top. Try using carrots in place of potato slices in soup, for a lower-carbohydrate meal.",
                CategoryId = 2,
                ImageUrl = "https://rukminim1.flixcart.com/image/832/832/kuczmvk0/vegetable/h/s/j/carrot-ooty-un-branded-no-whole-original-imag7hvnqty9v5gu.jpeg?q=70",
                InStock = true,
                ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/kuczmvk0/vegetable/h/s/j/carrot-ooty-un-branded-no-whole-original-imag7hvnqty9v5gu.jpeg?q=70",
                Brand = "Organic",
            });

            modelBuilder.Entity<Product>().HasData(new Product //fruit
            {
                ProductId = 17,
                Name = "Mint Leaves (100 g)",
                Price = 19,
                ShortDescription = "But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. ",
                LongDescription =
                "But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. ",
                CategoryId = 2,
                ImageUrl = "https://rukminim1.flixcart.com/image/832/832/ked56kw0/vegetable/8/h/z/100-mint-leaves-un-branded-no-whole-original-imafv2ftybhf2erb.jpeg?q=70",
                InStock = true,
                ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/ked56kw0/vegetable/8/h/z/100-mint-leaves-un-branded-no-whole-original-imafv2ftybhf2erb.jpeg?q=70",
                Brand = "Organic",
            });


            modelBuilder.Entity<Product>().HasData(new Product //fruit
            {
                ProductId = 19,
                Name = "Beans Haricot (250 g)",
                Price = 22,
                ShortDescription = "But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. ",
                LongDescription =
                "But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. ",
                CategoryId = 2,
                ImageUrl = "https://rukminim1.flixcart.com/image/832/832/kc3p30w0/vegetable/t/m/x/250-beans-haricot-un-branded-whole-no-original-imaftauycjuhr4ay.jpeg?q=70",
                InStock = true,
                ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/kc3p30w0/vegetable/t/m/x/250-beans-haricot-un-branded-whole-no-original-imaftauycjuhr4ay.jpeg?q=70",
                Brand = "Organic",
            });


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 21,
                Name = "Feast Rozzana Basmati Rice",
                Price = 85,
                ShortDescription = "India Gate Feast Rozzana Basmati Rice  is defined by its long grains and amazing aromatic flavour.",
                LongDescription =
                " Having this rice is truly having a feast rozzana (a daily feast); combine it with your veggies and serve a nice pulao. Without this Basmati Rice, your biryanis will seem dull and tasteless. ",
                CategoryId = 3,
                ImageUrl = "https://rukminim1.flixcart.com/image/832/832/knqd3m80/rice/9/o/d/white-feast-rozzana-na-basmati-rice-pouch-india-gate-original-imag2c7wfzxrfwdy.jpeg?q=70",
                InStock = true,
                ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/knqd3m80/rice/9/o/d/white-feast-rozzana-na-basmati-rice-pouch-india-gate-original-imag2c7wfzxrfwdy.jpeg?q=70",
                Brand = "India Gate",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 22,
                Name = "Aashirvaad Select Sharbatti Atta",
                Price = 85,
                ShortDescription = "Aashirvaad Select is a premium quality atta made from the King of Wheat – Sharbati wheat grains",
                LongDescription =
                "Made from the King of Wheat – Sharbati, Aashirvaad Select is a premium quality aata which is made with love in India. This sharbati wheat flour contains 100% Sharbati wheat from select regions of Madhya Pradesh. ",
                CategoryId = 3,
                ImageUrl = "https://m.media-amazon.com/images/I/81l7thl5AQL._SL1500_.jpg",
                InStock = true,
                ImageThumbnailUrl = "https://m.media-amazon.com/images/I/81l7thl5AQL._SL1500_.jpg",
                Brand = "Aashirvaad",
            });

            modelBuilder.Entity<Product>().HasData(new Product //fruit
            {
                ProductId = 23,
                Name = "Aashirvaad Nature's Superfoods Multi Millet Mix  (500 g)",
                Price = 57,
                ShortDescription = "If you are looking for soft, slightly sweet but creamy-textured potatoes. You're at right place!",
                LongDescription =
                "",
                CategoryId = 3,
                ImageUrl = "https://rukminim1.flixcart.com/image/832/832/l4hcx3k0/flour/0/l/1/-original-imagfd3gtdjrsxds.jpeg?q=70",
                InStock = true,
                ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/l4hcx3k0/flour/0/l/1/-original-imagfd3gtdjrsxds.jpeg?q=70",
                Brand = "Aashirvaad",
            });

            modelBuilder.Entity<Product>().HasData(new Product //fruit
            {
                ProductId = 24,
                Name = "Aashirvaad Natures Superfoods Ragi Flour  (1 kg)",
                Price = 90,
                ShortDescription = "If you are looking for soft, slightly sweet but creamy-textured potatoes. You're at right place!",
                LongDescription =
                "",
                CategoryId = 3,
                ImageUrl = "https://rukminim1.flixcart.com/image/832/832/l26hdow0/flour/4/k/s/-original-imagdkghzc9yhdtv.jpeg?q=70",
                InStock = true,
                ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/l26hdow0/flour/4/k/s/-original-imagdkghzc9yhdtv.jpeg?q=70",
                Brand = "Aashirvaad",
            });

            modelBuilder.Entity<Product>().HasData(new Product //fruit
            {
                ProductId = 25,
                Name = "Aashirvaad Sugar Release Control Atta  (1 kg)",
                Price = 80,
                ShortDescription = "If you are looking for soft, slightly sweet but creamy-textured potatoes. You're at right place!",
                LongDescription =
                "",
                CategoryId = 3,
                ImageUrl = "https://rukminim1.flixcart.com/image/832/832/ki96c280/flour/f/7/z/1-sugar-release-control-atta-1-whole-wheat-flour-aashirvaad-original-imafy2w5hjxwhrjy.jpeg?q=70",
                InStock = true,
                ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/ki96c280/flour/f/7/z/1-sugar-release-control-atta-1-whole-wheat-flour-aashirvaad-original-imafy2w5hjxwhrjy.jpeg?q=70",
                Brand = "Aashirvaad",
            });

            modelBuilder.Entity<Product>().HasData(new Product //fruit
            {
                ProductId = 27,
                Name = "Fortune Besan  (500 g)",
                Price = 55,
                ShortDescription = "But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. ",
                LongDescription =
                "But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. ",
                CategoryId = 3,
                ImageUrl = "https://rukminim1.flixcart.com/image/832/832/kqidx8w0/flour/a/r/d/besan-besan-fortune-original-imag4gb46e9zwps8.jpeg?q=70",
                InStock = true,
                ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/kqidx8w0/flour/a/r/d/besan-besan-fortune-original-imag4gb46e9zwps8.jpeg?q=70",
                Brand = "Fortune",
            });


            modelBuilder.Entity<Product>().HasData(new Product //fruit
            {
                ProductId = 29,
                Name = "Oiginal",
                Price = 8,
                ShortDescription = "Britannia Bourbon is made for the people who can’t get enough of chocolate",
                LongDescription =
                "Britannia Bourbon is made for the people who can’t get enough of chocolate, Britannia Bourbon is made for the people who can’t get enough of chocolate",
                CategoryId = 3,
                ImageUrl = "https://rukminim1.flixcart.com/image/832/832/ktx9si80/flour/c/t/e/roasted-sooji-soji-safe-harvest-original-imag762nfygx9sdc.jpeg?q=70",
                InStock = true,
                ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/ktx9si80/flour/c/t/e/roasted-sooji-soji-safe-harvest-original-imag762nfygx9sdc.jpeg?q=70",
                Brand = "",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 111,
                Name = "Bourbon Chocolate Cream Biscuits (50 g)",
                Price = 10,
                ShortDescription = "Britannia Bourbon is made for the people who can’t get enough of chocolate.",
                LongDescription =
                "A treasure for the lovers of choco packed between the surplus of crunch and sprinkled with delicate sugar crystals. Smooth, melted chocolate fills your mouth with a sweet delighted taste for a mouth-watering experience. Enjoy these chocolicious biscuits with your fun gang to add sweetness in the moments. Britannia Bourbon is made for the people who can’t get enough of chocolate. Trust of Britannia and pure ingredients have made these biscuits everyone’s favourite.",
                CategoryId = 3,
                ImageUrl = "https://m.media-amazon.com/images/I/81l7thl5AQL._SL1500_.jpg",
                InStock = true,
                ImageThumbnailUrl = "https://m.media-amazon.com/images/I/81l7thl5AQL._SL1500_.jpg",
                Brand = "Britannia",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 112,
                Name = "Aloo Bhujia Namkeen (150 g)",
                Price = 33,
                ShortDescription = "Haldirams Aloo Bhujia is a authentic namkeen.",
                LongDescription =
                "This classic snack is made with chickpea flour, potato and some spices. This is a popular Indian snack that is originated from Rajasthan. It is a great accompaniment to savoury snacks that adds texture to classic Indian snacks.",
                CategoryId = 3,
                ImageUrl = "https://cdn.shopify.com/s/files/1/0501/5361/9606/products/1_3980ed7e-002d-4b35-828b-77586be12f11_512x720.jpg?v=1657172703",
                InStock = true,
                ImageThumbnailUrl = "https://i.pinimg.com/736x/8b/64/45/8b6445a600bd18e708ee3c7d5ddb0353.jpg",
                Brand = "Haldirams",
            });


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 113,
                Name = "Coca-Cola Soft Drink Can",
                Price = 31,
                ShortDescription = "Haldirams Aloo Bhujia is a authentic namkeen.",
                LongDescription =
                "This classic snack is made with chickpea flour, potato and some spices. This is a popular Indian snack that is originated from Rajasthan. It is a great accompaniment to savoury snacks that adds texture to classic Indian snacks.",
                CategoryId = 4,
                ImageUrl = "https://rukminim1.flixcart.com/image/832/832/l3dcl8w0/aerated-drink/w/b/2/-original-imagegf8yccvrgvx.jpeg?q=70",
                InStock = true,
                ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/l3dcl8w0/aerated-drink/w/b/2/-original-imagegf8yccvrgvx.jpeg?q=70",
                Brand = "Coca-Cola ",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 114,
                Name = "Sprite Can",
                Price = 35,
                ShortDescription = "Let the lemon - flavour of the Sprite soft drink quench your thirst and refresh your taste buds instantly.",
                LongDescription =
                "Let the lemon-flavour of the Sprite soft drink quench your thirst and refresh your taste buds instantly. This refreshing beverage complements meals, and also, it gives you instant energy to sail through the hot summer days. Clean and Crisp Flavour",
                CategoryId = 4,
                ImageUrl = "https://rukminim1.flixcart.com/image/832/832/l3dcl8w0/aerated-drink/w/b/2/-original-imagegf8yccvrgvx.jpeg?q=70",
                InStock = true,
                ImageThumbnailUrl = "https://m.media-amazon.com/images/I/81l7thl5AQL._SL1500_.jpg",
                Brand = "Sprite",
            });

        }
    }
}
