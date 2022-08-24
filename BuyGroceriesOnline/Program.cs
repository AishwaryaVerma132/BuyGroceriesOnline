using BuyGroceriesOnline.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

string connString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(connString);

});

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AppDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IFeedbackRepository, FeedbackRepository>();
builder.Services.AddScoped<ICouponRepository, CouponRepository>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddAuthentication().AddFacebook(options =>
{
    options.AppId = "442257214517899";
    options.AppSecret = "1c14cdf96bd5adb59cbe47dc7c270c81";
});
builder.Services.AddAuthentication().AddGoogle(options =>
{
    options.ClientId = "1014626721841-jbf72b5q80drfmtqrc1aluaqmf723l87.apps.googleusercontent.com";
    options.ClientSecret = "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";
});
builder.Services.AddAuthentication().AddTwitter(options =>
{
    options.ConsumerKey = "VHp3ajZfeFRYa1JLRHdUMVVjWWE6MTpjaQ";
    options.ConsumerSecret = "uOHGB_jIyTOIGVmP9B95OpPHAupBx3-bdh86x4XwvU2HXTotvo";

});
builder.Services.AddRazorPages();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));

builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();