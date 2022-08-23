using Microsoft.EntityFrameworkCore;

namespace BuyGroceriesOnline.Models
{
    public class CouponRepository : ICouponRepository
    {
        public readonly AppDbContext _appDbContext;
        public CouponRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Coupon> AllCoupon => _appDbContext.Coupons.Include(c => c.Orders );
        public Coupon DeleteCoupon(int couponId)
        {
            var Coupon = GetCouponById(couponId);
            var entry = _appDbContext.Coupons.Remove(Coupon);
            _appDbContext.SaveChanges();
            return entry.Entity;
        }

        public Coupon GetCouponById(int couponId)
        {
            return AllCoupon.FirstOrDefault(coupon => coupon.CouponId == couponId);
        }

        public Coupon InsertCoupon(Coupon coupons)
        {
            var entry = _appDbContext.Coupons.Add(coupons);
            _appDbContext.SaveChanges();
            return entry.Entity;
        }

        public Coupon UpdateCoupon(Coupon coupons)
        {
            var entry = _appDbContext.Coupons.Update(coupons);
            _appDbContext.SaveChanges();
            return entry.Entity;
        }
    }
}
