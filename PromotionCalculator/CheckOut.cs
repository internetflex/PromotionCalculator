using System.Collections.Generic;
using System.Linq;
using PromotionCalculator;

namespace PromotionCalculatorTests
{
    public class CheckOut
    {
        public decimal Total(IEnumerable<SKU> items)
        {
            var itemList = items.ToList();
            return itemList[0].UnitPrice;
        }
    }
}