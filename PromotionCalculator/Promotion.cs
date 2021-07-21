using System.Collections.Generic;

namespace PromotionCalculator
{
    public class SkuCountPromotion
    {
        private readonly char _skuId;
        private readonly uint _skuCount;
        private readonly decimal _fixedPrice;

        public SkuCountPromotion(char skuId, uint skuCount, decimal fixedPrice)
        {
            _skuId = skuId;
            _skuCount = skuCount;
            _fixedPrice = fixedPrice;
        }

        public decimal Calculate(IEnumerable<SKU> cartItems)
        {
            var total = 0.0m;
            var idItemCount = 0;
            var idItemSubTotal = 0.0m;

            foreach (var item in cartItems)
            {
                if (item.Id == _skuId)
                {
                    idItemCount++;
                    if (idItemCount == _skuCount)
                    {
                        total += _fixedPrice;
                        idItemSubTotal = 0;
                        idItemCount = 0;
                    }
                    else
                    {
                        idItemSubTotal += item.UnitPrice;
                    }
                }
                else
                    total += item.UnitPrice;
            }

            return total + idItemSubTotal;
        }
    }
}
