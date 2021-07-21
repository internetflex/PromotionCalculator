using System;

namespace PromotionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Promotion Calculator");
            Console.ForegroundColor = ConsoleColor.White;

            var checkOut = new CheckOut(new SkuTwinPromotion('C', 'D', 30.0m));
            Console.WriteLine($"Creating Promotion C + D = £30.00");

            var cart = new Cart();

            var sku = new SKU('C') { UnitPrice = 20 };
            cart.Add(sku);
            Console.WriteLine($"Adding SKU {sku.Id} with unit price £{sku.UnitPrice:0.00}");

            sku = new SKU('D') {UnitPrice = 20};
            cart.Add(sku);
            Console.WriteLine($"Adding SKU {sku.Id} with unit price £{sku.UnitPrice:0.00}");

            var total = checkOut.Total(cart.Items);
            Console.WriteLine($"Cart Total = £{total:0.00}\n");

            Console.Write("Press return to Exit");
            Console.ReadKey();
        }
    }
}
