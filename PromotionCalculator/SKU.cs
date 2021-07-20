namespace PromotionCalculator
{
    public class SKU
    {
        public SKU(char id)
        {
            Id = id;
        }

        public char Id { get; }
        public decimal UnitPrice { get; set; }
    }
}
