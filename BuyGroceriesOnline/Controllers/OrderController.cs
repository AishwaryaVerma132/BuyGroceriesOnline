using BuyGroceriesOnline.Models;
using BuyGroceriesOnline.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BuyGroceriesOnline.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly IFeedbackRepository _FeedbackRepository;
        private readonly IProductRepository _productRepository;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart, IFeedbackRepository FeedbackRepository , IProductRepository productRepository, IHttpContextAccessor contextAccessor)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
            this._FeedbackRepository = FeedbackRepository;
            _productRepository = productRepository;
            _contextAccessor = contextAccessor;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, add some products first");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thank You for your order. Hope your experience was Good!";
            return View();
        }
        public IActionResult DisplayOrder()
        {
            var user = _contextAccessor.HttpContext.User.Identity.Name; 
            var details = _orderRepository.OrderDetails.Where(o => o.Order.Email == user); 

            if (user == "manager@gmail.com")
            {
                return View(_orderRepository.OrderDetails);
            }

            return View(details);
        }
        
        public IActionResult CancelOrder(int id)
        {
            var selectedOrder = _orderRepository.OrderDetails.FirstOrDefault(p => p.OrderDetailId == id);
            return View(selectedOrder);
        }
        [HttpPost]
        public IActionResult CancelOrderItem(int id)
        {
            var selectedOrder = _orderRepository.OrderDetails.FirstOrDefault(p => p.OrderDetailId == id);

            if (selectedOrder != null)
            {
                TempData["error"] = "Item Cancelled!";
                _orderRepository.CancelOrder(selectedOrder);
            }
            return RedirectToAction("DisplayOrder");

        }
        public ViewResult FeedBack()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateFeedBack(Feedback feed)
        {           
            _FeedbackRepository.InsertFeedback(feed);
            return RedirectToAction("Index", "Home", new { area = "" });            
        }

        public ViewResult AllFeedback()
        {
            var allFeedback =  _FeedbackRepository.GetAllFeedback();
            return View(allFeedback);
        }

        public IActionResult FeedbackDetails(int id)
        {
            return View(_FeedbackRepository.GetAllFeedback().FirstOrDefault(f => f.FeedbackId == id));
        }

        public ViewResult DeleteFeedback(int id)
        {
            var deleteFeedback = _FeedbackRepository.GetAllFeedback().FirstOrDefault(f => f.FeedbackId == id);
            return View(deleteFeedback);
        }

        [HttpPost]
        public IActionResult RemoveFeedback(int feedbackId)
        {
            _FeedbackRepository.DeleteFeedback(feedbackId);
            return RedirectToAction("AllFeedback");
        }
    }
}
