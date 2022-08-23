using Microsoft.AspNetCore.Mvc;

namespace BuyGroceriesOnline.Models
{
    public class CouponController : Controller
    {
        private readonly ICouponRepository _couponRepository;
        public CouponController(ICouponRepository couponRepository)
        {
            _couponRepository = couponRepository;
        }
        private IEnumerable<Coupon> GetAllCoupon()
        {
            return _couponRepository.AllCoupon;
        }

        public IActionResult ListCoupons()
        {
            return View(GetAllCoupon());
        }







        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertCoupon(Coupon coupon)
        {
            _couponRepository.InsertCoupon(coupon);
            return RedirectToAction("ListCoupons");
        }

        public ViewResult Edit(int id)
        {
            var coupon = GetAllCoupon().FirstOrDefault(p => p.CouponId == id);
            return View(coupon);
        }

        [HttpPost]
        public IActionResult UpdateCoupon(Coupon coupon)
        {
            _couponRepository.UpdateCoupon(coupon);
            return RedirectToAction("ListCoupons");
        }

        public ViewResult Delete(int id)
        {
            var coupon = GetAllCoupon().FirstOrDefault(p => p.CouponId == id);
            return View(coupon);
        }

        [HttpPost]
        public IActionResult DeleteCoupon(int couponId)
        {
            _couponRepository.DeleteCoupon(couponId);
            return RedirectToAction("ListCoupons");
        }
    }

}
