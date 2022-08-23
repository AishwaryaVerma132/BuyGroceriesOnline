using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BuyGroceriesOnline.Models;

namespace BuyGroceriesOnline.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

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

            //seed products
            /*modelBuilder.Entity<Product>().HasData(new Product
           {
               ProductId = 115,
               Name = "",
               Price = ,
               ShortDescription = "",
               LongDescription =
               "",
               CategoryId = ,
               ImageUrl = "",
               InStock = true,
               ImageThumbnailUrl = "",
               Brand = "",
           });
            */

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 117,
                Name = "Papaya",
                Price = 40,
                ShortDescription = "Organically Grown, 1 pc (approx. 500 -1 kg)",
                LongDescription =
                "Papayas reduce the risk of macular degeneration, a disease that affects the eyes as people age.They prevent asthma and cancer.Mashed papayas help in wound healing and preventing infections.",
                CategoryId = 1,
                ImageUrl = "https://www.bigbasket.com/media/uploads/p/l/40022647-2_1-fresho-papaya-organically-grown.jpg",
                InStock = true,
                ImageThumbnailUrl = "https://www.bigbasket.com/media/uploads/p/l/40022647-2_1-fresho-papaya-organically-grown.jpg",
                Brand = "Fresho ",
            });


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 118,
                Name = "Watermelon",
                Price = 45,
                ShortDescription = "Organically Grown (Loose), 1 pc (approx. 1 -3 kg)",
                LongDescription = "Watermelons have excellent hydrating properties with 90% water content.Rich in anti - oxidant flavonoids that protects against prostate,breast,colon,pancreatic and lung cancers.",
                CategoryId = 1,
                ImageUrl = "https://www.bigbasket.com/media/uploads/p/l/40023482-2_1-fresho-watermelon-organically-grown.jpg",
                InStock = true,
                ImageThumbnailUrl = "https://www.bigbasket.com/media/uploads/p/l/40023482-2_1-fresho-watermelon-organically-grown.jpg",
                Brand = "Fresho ",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Kiwi (3 units)",
                Price = 66,
                ShortDescription = "One Kiwi contains a full day requirement of vitamin C.",
                LongDescription =
                    "The kiwi typically grows in the shape of an oval and is roughly around the size of a typical chicken egg. Its skin is camel-colored, fibrous, and coated in a light fuzz. Despite its fuzzy covering, the kiwi’s skin is edible and tart. The kiwi’s flesh is bright green with a unique but pleasing texture and rows of distinctive tiny black seeds, which can also be eaten. Kiwis have a sweet, tart, and bold taste — making them a popular addition to a healthy breakfast or lunch. Kiwis are high in Vitamin C  and dietary fiber and provide a variety of health benefits. This tart fruit can support heart health, digestive health, and immunity. The kiwi is a healthy choice of fruit and is rich with vitamins and antioxidants. Its tart flavor, pleasing texture, and low calorie count make it a delicious and healthy option for snacking, sides, or a unique dessert. The vitamins, fiber, and antioxidants can provide essential health benefits. The flesh is rich with vitamins that stimulate immunity and reduce the risk of disease.  Store them in a cool, dry place away from direct sunlight. Cut and serve it chilled. Blend them into thick milkshakes, smoothies, juices. Add them in salads and bake delicious pies. The nutritive value and flavour are retained even on cooking.",
                CategoryId = 1,
                ImageUrl = "https://previews.123rf.com/images/yurakp/yurakp1512/yurakp151200024/50197144-tasty-kiwis-isolated-on-the-white-background-.jpg",
                InStock = true,
                ImageThumbnailUrl = "https://previews.123rf.com/images/yurakp/yurakp1512/yurakp151200024/50197144-tasty-kiwis-isolated-on-the-white-background-.jpg",
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
                ProductId = 114,
                Name = "Sprite Soft Drink",
                Price = 35,
                ShortDescription = "Carbonated Water, Sugar, Acidity Regulator (330, 331), Preservative (211). Contains Added Flavours (Natural Flavouring Substances).",
                LongDescription =
                "Refreshing people since 1999, Sprite is known for its straightforward attitude. The brand strongly believes in removing all the unnecessary Bakwaas from your life so that you can chill for real.",
                CategoryId = 5,
                ImageUrl = "https://www.bigbasket.com/media/uploads/p/l/251006_11-sprite-soft-drink-lime-flavoured.jpg",
                InStock = true,
                ImageThumbnailUrl = "https://www.bigbasket.com/media/uploads/p/l/251006_11-sprite-soft-drink-lime-flavoured.jpg",
                Brand = "Sprite",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 115,
                Name = "Fanta Soft Drink",
                Price = 35,
                ShortDescription = "Orange Flavoured, Refreshing, 750 ml Pet Bottle",
                LongDescription =
                "Life is always fun with colourful energy, vibes and FANTA by your side. Known for its vibrant colour, tempting taste and tingling bubbles, FANTA lets your spirit free, thus encouraging you to have fun in life.",
                CategoryId =5,
                ImageUrl = "https://www.bigbasket.com/media/uploads/p/l/251019_8-fanta-soft-drink-orange-flavoured.jpg",
                InStock = true,
                ImageThumbnailUrl = "https://www.bigbasket.com/media/uploads/p/l/251019_8-fanta-soft-drink-orange-flavoured.jpg",
                Brand = "Fanta",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 116,
                Name = "Thums Up Soft Drink",
                Price = 40,
                ShortDescription = "Carbonated Water, sugar, Acidity Regulator (338), Caffeine. Contains Permitted Natural Colour (150d) and Added Flavours (Natural, Nature - identical and Artificial Flavouring Substances).",
                LongDescription =
                "Thums Up is well-known for its strong, fizzy flavor and its secure, mature and distinctively masculine attitude. This brand obviously seeks to divide the men from the boys. A glass soft drink goes well with any variety of food and any type of mood.",
                CategoryId = 5,
                ImageUrl = "https://www.bigbasket.com/media/uploads/p/l/288927_8-thums-up-soft-drink.jpg",
                InStock = true,
                ImageThumbnailUrl = "https://www.bigbasket.com/media/uploads/p/l/288927_8-thums-up-soft-drink.jpg",
                Brand = "Thums Up",
            });

        }

        public DbSet<BuyGroceriesOnline.Models.ProductMini>? ProductMini { get; set; }
    }
}
