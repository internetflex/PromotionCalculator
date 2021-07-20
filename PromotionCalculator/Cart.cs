namespace PromotionCalculator
{
    public class Cart
    {
        public SKU items { get; set; }
        public object ItemCount { get; set; }

        public void Add(SKU sku)
        {
            items = sku;
            ItemCount = 2;
        }
    }
}
