using System.Collections.Generic;
using System.Linq;
using PromotionCalculator;

namespace PromotionCalculatorTests
{
    public class CheckOut
    {
        public decimal Total(IEnumerable<SKU> items)
        {
            var total = 0m;

            foreach (var item in items)
            {
                total += item.UnitPrice;
            }

            return total;
        }
    }
}