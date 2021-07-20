using System.Collections.Generic;
using System.Linq;

namespace PromotionCalculator
{
    public class CheckOut
    {
        public decimal Total(IEnumerable<SKU> items)
        {
            return items.Sum(item => item.UnitPrice);
        }
    }
}