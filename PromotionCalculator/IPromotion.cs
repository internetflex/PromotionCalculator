using System.Collections.Generic;

namespace PromotionCalculator
{
    public interface IPromotion
    {
        decimal Calculate(IEnumerable<SKU> cartItems);
    }
}