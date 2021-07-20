using NUnit.Framework;
using PromotionCalculator;
using Shouldly;

namespace PromotionCalculatorTests
{
    [TestFixture]
    public class CheckOutTests
    {
        [Test]
        public void ShouldBeAbleToCreateACheckOut()
        {
            var checkOut = new CheckOut();
            checkOut.ShouldNotBeNull();
        }

        [Test]
        public void ShouldBeAbleToTotal1ItemInACart()
        {
            const decimal skuAPrice = 2.3m;
            var checkOut = new CheckOut();
            var cart = new Cart();
            var sku = new SKU('A') {UnitPrice = skuAPrice};
            cart.Add(sku);
            var total = checkOut.Total(cart.Items);
            total.ShouldBe(skuAPrice);
        }
    }
}
