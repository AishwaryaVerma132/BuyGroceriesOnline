using BuyGroceriesOnline.Models;
using BuyGroceriesOnline.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace BuyGroceriesOnline.Controllers
{
    [Authorize]
    public class ShoppingCartController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICouponRepository _couponRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IProductRepository productRepository, ShoppingCart shoppingCart, ICouponRepository couponRepository)
        {
            _productRepository = productRepository;
            _shoppingCart = shoppingCart;
            _couponRepository = couponRepository;
        }
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        public ViewResult ApplyCoupon()
        {        
            return View(_couponRepository.AllCoupon);
        }

        public RedirectToActionResult CalculateDiscount(int id)
        {
            var discount = _couponRepository.AllCoupon.Where(n => n.CouponId == id).Select(a => a.Discount).FirstOrDefault();

            ShoppingCart.DiscountAmt = Convert.ToDecimal(discount);

            return RedirectToAction("Index");
        }

        public ViewResult NotInStock()
        {
            return View();
        }
        public RedirectToActionResult AddToShoppingCart(int productId)
        {
            var selectedProduct = _productRepository.AllProduct.FirstOrDefault(p => p.ProductId == productId);
            if (!selectedProduct.InStock)
            {
                TempData["error"] = "Not in stock!";
            }else if (selectedProduct != null)
            {
                TempData["success"] = "Item Added to Cart";
                _shoppingCart.AddToCart(selectedProduct, 1);
            }
            return RedirectToAction("Index");
        }
        public RedirectToActionResult RemoveFromShoppingCart(int productId)
        {
            var selectedProduct = _productRepository.AllProduct.FirstOrDefault(p => p.ProductId == productId);

            if (selectedProduct != null)
            {
                TempData["error"] = "Item Removed!";
                _shoppingCart.RemoveFromCart(selectedProduct);
            }
            return RedirectToAction("Index");
        
        }

        public RedirectToActionResult ClearCart()
        {
            _shoppingCart.ClearCart();
            TempData["warning"] = "Cart Cleared";
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveItem(int productId)
        {
            var selectedProduct = _productRepository.AllProduct.FirstOrDefault(p => p.ProductId == productId);
            if (selectedProduct != null)
            {
                TempData["error"] = "Item Removed!";
                _shoppingCart.RemoveItem(selectedProduct);
            }
            return RedirectToAction("Index");
        }
    }
}
