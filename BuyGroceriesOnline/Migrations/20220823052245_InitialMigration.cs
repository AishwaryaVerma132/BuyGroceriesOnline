using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuyGroceriesOnline.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "Coupons",
                columns: table => new
                {
                    CouponId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CouponName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.CouponId);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    FeedbackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    City = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FeedBack = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.FeedbackId);
                });

            migrationBuilder.CreateTable(
                name: "ProductMini",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMini", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OrderTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderPlaced = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CouponId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Coupons_CouponId",
                        column: x => x.CouponId,
                        principalTable: "Coupons",
                        principalColumn: "CouponId");
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
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
                    { 1, "Unbranded", 1, "https://previews.123rf.com/images/yurakp/yurakp1512/yurakp151200024/50197144-tasty-kiwis-isolated-on-the-white-background-.jpg", "https://previews.123rf.com/images/yurakp/yurakp1512/yurakp151200024/50197144-tasty-kiwis-isolated-on-the-white-background-.jpg", true, false, "The kiwi typically grows in the shape of an oval and is roughly around the size of a typical chicken egg. Its skin is camel-colored, fibrous, and coated in a light fuzz. Despite its fuzzy covering, the kiwi’s skin is edible and tart. The kiwi’s flesh is bright green with a unique but pleasing texture and rows of distinctive tiny black seeds, which can also be eaten. Kiwis have a sweet, tart, and bold taste — making them a popular addition to a healthy breakfast or lunch. Kiwis are high in Vitamin C  and dietary fiber and provide a variety of health benefits. This tart fruit can support heart health, digestive health, and immunity. The kiwi is a healthy choice of fruit and is rich with vitamins and antioxidants. Its tart flavor, pleasing texture, and low calorie count make it a delicious and healthy option for snacking, sides, or a unique dessert. The vitamins, fiber, and antioxidants can provide essential health benefits. The flesh is rich with vitamins that stimulate immunity and reduce the risk of disease.  Store them in a cool, dry place away from direct sunlight. Cut and serve it chilled. Blend them into thick milkshakes, smoothies, juices. Add them in salads and bake delicious pies. The nutritive value and flavour are retained even on cooking.", "Kiwi (3 units)", 66m, "One Kiwi contains a full day requirement of vitamin C." },
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
                    { 114, "Sprite", 5, "https://www.bigbasket.com/media/uploads/p/l/251006_11-sprite-soft-drink-lime-flavoured.jpg", "https://www.bigbasket.com/media/uploads/p/l/251006_11-sprite-soft-drink-lime-flavoured.jpg", true, false, "Refreshing people since 1999, Sprite is known for its straightforward attitude. The brand strongly believes in removing all the unnecessary Bakwaas from your life so that you can chill for real.", "Sprite Soft Drink", 35m, "Carbonated Water, Sugar, Acidity Regulator (330, 331), Preservative (211). Contains Added Flavours (Natural Flavouring Substances)." },
                    { 115, "Fanta", 5, "https://www.bigbasket.com/media/uploads/p/l/251019_8-fanta-soft-drink-orange-flavoured.jpg", "https://www.bigbasket.com/media/uploads/p/l/251019_8-fanta-soft-drink-orange-flavoured.jpg", true, false, "Life is always fun with colourful energy, vibes and FANTA by your side. Known for its vibrant colour, tempting taste and tingling bubbles, FANTA lets your spirit free, thus encouraging you to have fun in life.", "Fanta Soft Drink", 35m, "Orange Flavoured, Refreshing, 750 ml Pet Bottle" },
                    { 116, "Thums Up", 5, "https://www.bigbasket.com/media/uploads/p/l/288927_8-thums-up-soft-drink.jpg", "https://www.bigbasket.com/media/uploads/p/l/288927_8-thums-up-soft-drink.jpg", true, false, "Thums Up is well-known for its strong, fizzy flavor and its secure, mature and distinctively masculine attitude. This brand obviously seeks to divide the men from the boys. A glass soft drink goes well with any variety of food and any type of mood.", "Thums Up Soft Drink", 40m, "Carbonated Water, sugar, Acidity Regulator (338), Caffeine. Contains Permitted Natural Colour (150d) and Added Flavours (Natural, Nature - identical and Artificial Flavouring Substances)." },
                    { 117, "Fresho ", 1, "https://www.bigbasket.com/media/uploads/p/l/40022647-2_1-fresho-papaya-organically-grown.jpg", "https://www.bigbasket.com/media/uploads/p/l/40022647-2_1-fresho-papaya-organically-grown.jpg", true, false, "Papayas reduce the risk of macular degeneration, a disease that affects the eyes as people age.They prevent asthma and cancer.Mashed papayas help in wound healing and preventing infections.", "Papaya", 40m, "Organically Grown, 1 pc (approx. 500 -1 kg)" },
                    { 118, "Fresho ", 1, "https://www.bigbasket.com/media/uploads/p/l/40023482-2_1-fresho-watermelon-organically-grown.jpg", "https://www.bigbasket.com/media/uploads/p/l/40023482-2_1-fresho-watermelon-organically-grown.jpg", true, false, "Watermelons have excellent hydrating properties with 90% water content.Rich in anti - oxidant flavonoids that protects against prostate,breast,colon,pancreatic and lung cancers.", "Watermelon", 45m, "Organically Grown (Loose), 1 pc (approx. 1 -3 kg)" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CouponId",
                table: "Orders",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductMini");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
