namespace BuyGroceriesOnline.Models
{
    public interface ICouponRepository
    {
        IEnumerable<Coupon> AllCoupon { get; }
        Coupon GetCouponById(int couponId);
        public Coupon InsertCoupon(Coupon coupons);
        public Coupon UpdateCoupon(Coupon coupons);
        public Coupon DeleteCoupon(int couponId);
    }
}
