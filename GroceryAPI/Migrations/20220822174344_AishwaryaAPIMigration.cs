using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroceryAPI.Migrations
{
    public partial class AishwaryaAPIMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsProductOfTheWeek = table.Column<bool>(type: "bit", nullable: false),
                    InStock = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Fruits", "Fruits are a rich source of vitamins, minerals, fibres and proteins. " },
                    { 2, "Vegetables", "Vegetables contain many vitamins and minerals that are good for your health." },
                    { 3, "Cereals", "We should eat fresh fruits to keep ourselves healthy. " },
                    { 4, "Snacks Store", "These include vitamins A (beta-carotene), C and E, magnesium, zinc, phosphorous and folic acid." },
                    { 5, "Beverages", "But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. " },
                    { 6, "Cleaning & Household", "We should eat fresh fruits to keep ourselves healthy. But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. " },
                    { 7, "Beauty & Makeup", "These include vitamins A (beta-carotene), C and E, magnesium, zinc, phosphorous and folic acid." }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Brand", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsProductOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "Unbranded", 1, "https://media.istockphoto.com/photos/red-cherry-plum-with-green-leaves-isolated-on-white-background-picture-id687478414?k=20&m=687478414&s=612x612&w=0&h=eI2g4RbgFznJDVsUvmu5JkrG16XupOLxIrT3xRxMKJ8=", "https://media.istockphoto.com/photos/plums-fresh-plums-picture-id1257344030?k=20&m=1257344030&s=612x612&w=0&h=5bzcEVyMttyc-EkEZebmu-JFOakMQoqiOTOmxVDln2s=", true, false, "Onion is a vegetable which is almost like a staple in Indian food. This is also known to be one of the essential ingredients of raw salads. They come in different colours like white, red or yellow and are quite in demand in cold salads and hot soups.", "Kiwi (3 units)", 66m, "Onion is a round vegetable with a brown skin that grows underground." },
                    { 11, "Organic", 2, "https://rukminim1.flixcart.com/image/832/832/jtsz3bk0/vegetable/k/y/d/5-onion-un-branded-no-whole-original-imafdsyg4ykqcyt4.jpeg?q=70", "https://rukminim1.flixcart.com/image/832/832/jtsz3bk0/vegetable/k/y/d/5-onion-un-branded-no-whole-original-imafdsyg4ykqcyt4.jpeg?q=70", true, false, "Onion is a vegetable which is almost like a staple in Indian food. This is also known to be one of the essential ingredients of raw salads. They come in different colours like white, red or yellow and are quite in demand in cold salads and hot soups.", "Fresh Onion (1 kg)", 26m, "Onion is a round vegetable with a brown skin that grows underground." },
                    { 12, "Organic", 2, "https://rukminim1.flixcart.com/image/832/832/jtsz3bk0/vegetable/b/8/4/2-potato-un-branded-no-whole-original-imafdsymh2aepaph.jpeg?q=70", "https://rukminim1.flixcart.com/image/832/832/jtsz3bk0/vegetable/b/8/4/2-potato-un-branded-no-whole-original-imafdsymh2aepaph.jpeg?q=70", true, false, "These are a special variant early harvest of potatoes and are easily distinguishable with their thin/ tender skin which makes them easy-to-peel off even it can be used without peeling.  ", "Fresh Potato (1 kg)", 37m, "If you are looking for soft, slightly sweet but creamy-textured potatoes. You're at right place!" },
                    { 13, "Organic", 2, "https://rukminim1.flixcart.com/image/832/832/km9ht3k0/vegetable/y/o/3/cabbage-unbranded-whole-no-original-imagf7fpazpgzcwm.jpeg?q=70", "https://rukminim1.flixcart.com/image/832/832/km9ht3k0/vegetable/y/o/3/cabbage-unbranded-whole-no-original-imagf7fpazpgzcwm.jpeg?q=70", true, false, "These are a special variant early harvest of potatoes and are easily distinguishable with their thin/ tender skin which makes them easy-to-peel off even it can be used without peeling.", "Cabbage, 1 Units  (500 – 800gm)", 26m, "If you are looking for soft, slightly sweet but creamy-textured potatoes. You're at right place!" },
                    { 15, "Organic", 2, "https://rukminim1.flixcart.com/image/832/832/kuczmvk0/vegetable/h/s/j/carrot-ooty-un-branded-no-whole-original-imag7hvnqty9v5gu.jpeg?q=70", "https://rukminim1.flixcart.com/image/832/832/kuczmvk0/vegetable/h/s/j/carrot-ooty-un-branded-no-whole-original-imag7hvnqty9v5gu.jpeg?q=70", true, false, "Carrots are a great addition to soups and stews, appetizers and hors d'oeuvres, side dishes and salads. They can be roasted in the oven or boiled on the stove top. Try using carrots in place of potato slices in soup, for a lower-carbohydrate meal.", "Carrot (500 g)", 71m, "If you are looking for soft, slightly sweet but creamy-textured potatoes. You're at right place!" },
                    { 17, "Organic", 2, "https://rukminim1.flixcart.com/image/832/832/ked56kw0/vegetable/8/h/z/100-mint-leaves-un-branded-no-whole-original-imafv2ftybhf2erb.jpeg?q=70", "https://rukminim1.flixcart.com/image/832/832/ked56kw0/vegetable/8/h/z/100-mint-leaves-un-branded-no-whole-original-imafv2ftybhf2erb.jpeg?q=70", true, false, "But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. ", "Mint Leaves (100 g)", 19m, "But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. " },
                    { 19, "Organic", 2, "https://rukminim1.flixcart.com/image/832/832/kc3p30w0/vegetable/t/m/x/250-beans-haricot-un-branded-whole-no-original-imaftauycjuhr4ay.jpeg?q=70", "https://rukminim1.flixcart.com/image/832/832/kc3p30w0/vegetable/t/m/x/250-beans-haricot-un-branded-whole-no-original-imaftauycjuhr4ay.jpeg?q=70", true, false, "But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. ", "Beans Haricot (250 g)", 22m, "But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. " },
                    { 21, "India Gate", 3, "https://rukminim1.flixcart.com/image/832/832/knqd3m80/rice/9/o/d/white-feast-rozzana-na-basmati-rice-pouch-india-gate-original-imag2c7wfzxrfwdy.jpeg?q=70", "https://rukminim1.flixcart.com/image/832/832/knqd3m80/rice/9/o/d/white-feast-rozzana-na-basmati-rice-pouch-india-gate-original-imag2c7wfzxrfwdy.jpeg?q=70", true, false, " Having this rice is truly having a feast rozzana (a daily feast); combine it with your veggies and serve a nice pulao. Without this Basmati Rice, your biryanis will seem dull and tasteless. ", "Feast Rozzana Basmati Rice", 85m, "India Gate Feast Rozzana Basmati Rice  is defined by its long grains and amazing aromatic flavour." },
                    { 22, "Aashirvaad", 3, "https://m.media-amazon.com/images/I/81l7thl5AQL._SL1500_.jpg", "https://m.media-amazon.com/images/I/81l7thl5AQL._SL1500_.jpg", true, false, "Made from the King of Wheat – Sharbati, Aashirvaad Select is a premium quality aata which is made with love in India. This sharbati wheat flour contains 100% Sharbati wheat from select regions of Madhya Pradesh. ", "Aashirvaad Select Sharbatti Atta", 85m, "Aashirvaad Select is a premium quality atta made from the King of Wheat – Sharbati wheat grains" },
                    { 23, "Aashirvaad", 3, "https://rukminim1.flixcart.com/image/832/832/l4hcx3k0/flour/0/l/1/-original-imagfd3gtdjrsxds.jpeg?q=70", "https://rukminim1.flixcart.com/image/832/832/l4hcx3k0/flour/0/l/1/-original-imagfd3gtdjrsxds.jpeg?q=70", true, false, "", "Aashirvaad Nature's Superfoods Multi Millet Mix  (500 g)", 57m, "If you are looking for soft, slightly sweet but creamy-textured potatoes. You're at right place!" },
                    { 24, "Aashirvaad", 3, "https://rukminim1.flixcart.com/image/832/832/l26hdow0/flour/4/k/s/-original-imagdkghzc9yhdtv.jpeg?q=70", "https://rukminim1.flixcart.com/image/832/832/l26hdow0/flour/4/k/s/-original-imagdkghzc9yhdtv.jpeg?q=70", true, false, "", "Aashirvaad Natures Superfoods Ragi Flour  (1 kg)", 90m, "If you are looking for soft, slightly sweet but creamy-textured potatoes. You're at right place!" },
                    { 25, "Aashirvaad", 3, "https://rukminim1.flixcart.com/image/832/832/ki96c280/flour/f/7/z/1-sugar-release-control-atta-1-whole-wheat-flour-aashirvaad-original-imafy2w5hjxwhrjy.jpeg?q=70", "https://rukminim1.flixcart.com/image/832/832/ki96c280/flour/f/7/z/1-sugar-release-control-atta-1-whole-wheat-flour-aashirvaad-original-imafy2w5hjxwhrjy.jpeg?q=70", true, false, "", "Aashirvaad Sugar Release Control Atta  (1 kg)", 80m, "If you are looking for soft, slightly sweet but creamy-textured potatoes. You're at right place!" },
                    { 27, "Fortune", 3, "https://rukminim1.flixcart.com/image/832/832/kqidx8w0/flour/a/r/d/besan-besan-fortune-original-imag4gb46e9zwps8.jpeg?q=70", "https://rukminim1.flixcart.com/image/832/832/kqidx8w0/flour/a/r/d/besan-besan-fortune-original-imag4gb46e9zwps8.jpeg?q=70", true, false, "But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. ", "Fortune Besan  (500 g)", 55m, "But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. " },
                    { 29, "", 3, "https://rukminim1.flixcart.com/image/832/832/ktx9si80/flour/c/t/e/roasted-sooji-soji-safe-harvest-original-imag762nfygx9sdc.jpeg?q=70", "https://rukminim1.flixcart.com/image/832/832/ktx9si80/flour/c/t/e/roasted-sooji-soji-safe-harvest-original-imag762nfygx9sdc.jpeg?q=70", true, false, "Britannia Bourbon is made for the people who can’t get enough of chocolate, Britannia Bourbon is made for the people who can’t get enough of chocolate", "Oiginal", 8m, "Britannia Bourbon is made for the people who can’t get enough of chocolate" },
                    { 111, "Britannia", 3, "https://m.media-amazon.com/images/I/81l7thl5AQL._SL1500_.jpg", "https://m.media-amazon.com/images/I/81l7thl5AQL._SL1500_.jpg", true, false, "A treasure for the lovers of choco packed between the surplus of crunch and sprinkled with delicate sugar crystals. Smooth, melted chocolate fills your mouth with a sweet delighted taste for a mouth-watering experience. Enjoy these chocolicious biscuits with your fun gang to add sweetness in the moments. Britannia Bourbon is made for the people who can’t get enough of chocolate. Trust of Britannia and pure ingredients have made these biscuits everyone’s favourite.", "Bourbon Chocolate Cream Biscuits (50 g)", 10m, "Britannia Bourbon is made for the people who can’t get enough of chocolate." },
                    { 112, "Haldirams", 3, "https://i.pinimg.com/736x/8b/64/45/8b6445a600bd18e708ee3c7d5ddb0353.jpg", "https://cdn.shopify.com/s/files/1/0501/5361/9606/products/1_3980ed7e-002d-4b35-828b-77586be12f11_512x720.jpg?v=1657172703", true, false, "This classic snack is made with chickpea flour, potato and some spices. This is a popular Indian snack that is originated from Rajasthan. It is a great accompaniment to savoury snacks that adds texture to classic Indian snacks.", "Aloo Bhujia Namkeen (150 g)", 33m, "Haldirams Aloo Bhujia is a authentic namkeen." },
                    { 113, "Coca-Cola ", 4, "https://rukminim1.flixcart.com/image/832/832/l3dcl8w0/aerated-drink/w/b/2/-original-imagegf8yccvrgvx.jpeg?q=70", "https://rukminim1.flixcart.com/image/832/832/l3dcl8w0/aerated-drink/w/b/2/-original-imagegf8yccvrgvx.jpeg?q=70", true, false, "This classic snack is made with chickpea flour, potato and some spices. This is a popular Indian snack that is originated from Rajasthan. It is a great accompaniment to savoury snacks that adds texture to classic Indian snacks.", "Coca-Cola Soft Drink Can", 31m, "Haldirams Aloo Bhujia is a authentic namkeen." },
                    { 114, "Sprite", 4, "https://m.media-amazon.com/images/I/81l7thl5AQL._SL1500_.jpg", "https://rukminim1.flixcart.com/image/832/832/l3dcl8w0/aerated-drink/w/b/2/-original-imagegf8yccvrgvx.jpeg?q=70", true, false, "Let the lemon-flavour of the Sprite soft drink quench your thirst and refresh your taste buds instantly. This refreshing beverage complements meals, and also, it gives you instant energy to sail through the hot summer days. Clean and Crisp Flavour", "Sprite Can", 35m, "Let the lemon - flavour of the Sprite soft drink quench your thirst and refresh your taste buds instantly." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
