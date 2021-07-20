namespace PromotionCalculator
{
    public class Cart
    {
        public SKU item { get; set; }

        public void Add(SKU sku)
        {
            item = sku;
        }
    }
}
