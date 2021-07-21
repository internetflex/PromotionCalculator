using NUnit.Framework;
using PromotionCalculator;
using Shouldly;

namespace PromotionCalculatorTests
{
    [TestFixture]
    public class SkuCountPromotionTests
    {
        [Test]
        public void ShouldBeAbleToCreatePromotionForFixedNumberofSKUs()
        {
            var skuCountPromotion = new SkuCountPromotion('A', 3, 130.0m);
            skuCountPromotion.ShouldNotBeNull();
        }

        [Test]
        public void ShouldBeAbleToCalculateSkuCountPromotionTotalForCartItems()
        {
            var skuCountPromotion = new SkuCountPromotion('A', 3, 130.0m);
            var cart = new Cart();
            cart.Add(new SKU('A') {UnitPrice = 50.0m});
            cart.Add(new SKU('A') {UnitPrice = 50.0m});
            cart.Add(new SKU('A') {UnitPrice = 50.0m});
            var total = skuCountPromotion.Calculate(cart.Items);
            total.ShouldBe(130.0m);
        }

        [Test]
        public void ShouldBeAbleToCalculateSkuCountPromotionIfNotEnoughForPromotion()
        {
            var skuCountPromotion = new SkuCountPromotion('A', 3, 130.0m);
            var cart = new Cart();
            cart.Add(new SKU('A') {UnitPrice = 50.0m});
            cart.Add(new SKU('A') {UnitPrice = 50.0m});
            var total = skuCountPromotion.Calculate(cart.Items);
            total.ShouldBe(100.0m);
        }

        [Test]
        public void ShouldBeAbleToCalculateSkuCountPromotionNoIdMatches()
        {
            var skuCountPromotion = new SkuCountPromotion('A', 3, 130.0m);
            var cart = new Cart();
            cart.Add(new SKU('B') {UnitPrice = 10.0m});
            cart.Add(new SKU('C') {UnitPrice = 20.0m});
            cart.Add(new SKU('D') {UnitPrice = 30.0m});
            cart.Add(new SKU('E') {UnitPrice = 40.0m});
            var total = skuCountPromotion.Calculate(cart.Items);
            total.ShouldBe(100.0m);
        }

        [Test]
        public void ShouldBeAbleToCalculateSkuCountPromotionWhenAppliesTwice()
        {
            var skuCountPromotion = new SkuCountPromotion('A', 3, 130.0m);
            var cart = new Cart();
            cart.Add(new SKU('A') { UnitPrice = 50.0m });
            cart.Add(new SKU('A') { UnitPrice = 50.0m });
            cart.Add(new SKU('A') { UnitPrice = 50.0m });
            cart.Add(new SKU('A') { UnitPrice = 50.0m });
            cart.Add(new SKU('A') { UnitPrice = 50.0m });
            cart.Add(new SKU('A') { UnitPrice = 50.0m });
            var total = skuCountPromotion.Calculate(cart.Items);
            total.ShouldBe(260.0m);
        }
    }
}