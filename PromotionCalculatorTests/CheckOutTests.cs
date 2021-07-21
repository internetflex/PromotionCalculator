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
            var checkOut = new CheckOut(null);
            checkOut.ShouldNotBeNull();
        }

        [Test]
        public void ShouldBeAbleToTotal1ItemInACart()
        {
            const decimal skuAPrice = 2.3m;
            var checkOut = new CheckOut(null);
            var cart = new Cart();
            var sku = new SKU('A') {UnitPrice = skuAPrice};
            cart.Add(sku);
            var total = checkOut.Total(cart.Items);
            total.ShouldBe(skuAPrice);
        }

        [Test]
        public void ShouldBeAbleToTotal2ItemsInACart()
        {
            const decimal skuAPrice = 2.3m;
            const decimal skuBPrice = 1.7m;
            var checkOut = new CheckOut(null);
            var cart = new Cart();
            cart.Add(new SKU('A') {UnitPrice = skuAPrice});
            cart.Add(new SKU('B') {UnitPrice = skuBPrice});
            var total = checkOut.Total(cart.Items);
            total.ShouldBe(skuAPrice+skuBPrice);
        }

        [Test]
        public void ShouldBeAbleToTotalEmptyCart()
        {
            var checkOut = new CheckOut(null);
            var cart = new Cart();
            var total = checkOut.Total(cart.Items);
            total.ShouldBe(0);
        }

        [Test]
        public void ShouldBeAbleAddSkuPromotionBasedTotal()
        {
            var checkOut = new CheckOut(new SkuCountPromotion('A', 2, 10.0m));
            var cart = new Cart();
            cart.Add(new SKU('A') { UnitPrice = 20 });
            cart.Add(new SKU('A') { UnitPrice = 20 });
            var total = checkOut.Total(cart.Items);
            total.ShouldBe(10);
        }

        [Test]
        public void ShouldBeAbleAddTwinPromotionBasedTotal()
        {
            var checkOut = new CheckOut(new SkuTwinPromotion('C','D', 30.0m));
            var cart = new Cart();
            cart.Add(new SKU('C') { UnitPrice = 20 });
            cart.Add(new SKU('D') { UnitPrice = 20 });
            var total = checkOut.Total(cart.Items);
            total.ShouldBe(30);
        }
    }
}
