namespace BuyGroceriesOnline.Models
{
    public class Coupon
    {
        public int CouponId { get; set; }
        public string CouponName { get; set; }
        public int Discount { get; set; }
        public List<Order> Orders { get; set; }
    }
}
