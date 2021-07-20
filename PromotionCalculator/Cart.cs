using System.Collections.Generic;

namespace PromotionCalculator
{
    public class Cart
    {
        public Cart()
        {
            Items = new List<SKU>();
        }

        public List<SKU> Items { get; set; }
        public int ItemCount { get; set; }

        public void Add(SKU sku)
        {
            Items.Add(sku);;
            ItemCount++;
        }
    }
}
