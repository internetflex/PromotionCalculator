using System.Collections.Generic;
using System.Linq;

namespace PromotionCalculator
{
    public class Cart
    {
        private readonly List<SKU> _items;

        public Cart()
        {
            _items = new List<SKU>();
        }

        public IEnumerable<SKU> Items => _items;
        public int ItemCount => Items.Count();

        public void Add(SKU sku)
        {
            _items.Add(sku);;
        }
    }
}
