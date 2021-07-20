using System.Collections.Generic;

namespace PromotionCalculator
{
    public class SkuCountPromotion
    {
        public SkuCountPromotion(char skuId, uint skuCount, decimal fixedPrice)
        {
        }

        public decimal Calculate(IEnumerable<SKU> cartItems)
        {
            throw new System.NotImplementedException();
        }
    }
}
