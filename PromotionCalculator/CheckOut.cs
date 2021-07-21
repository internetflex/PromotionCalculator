using System.Collections.Generic;
using System.Linq;

namespace PromotionCalculator
{
    public class CheckOut
    {
        private readonly IPromotion _promotion;

        public CheckOut(IPromotion promotion)
        {
            _promotion = promotion;
        }

        public decimal Total(IEnumerable<SKU> items)
        {
            var cartItems = items.ToList();
            return _promotion?.Calculate(cartItems) ?? cartItems.Sum(item => item.UnitPrice);
        }
    }
}