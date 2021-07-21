using NUnit.Framework;
using PromotionCalculator;
using Shouldly;

namespace PromotionCalculatorTests
{
    [TestFixture]
    public class SkuTwinPromotionTests
    {
        [Test]
        public void ShouldBeAbleToCreatePromotionForSkuTwinPromotion()
        {
            var skuCountPromotion = new SkuTwinPromotion('C', 'D', 30.0m);
            skuCountPromotion.ShouldNotBeNull();
        }

        [Test]
        public void ShouldBeAbleToCalculatePromotionForSkuTwinPromotionWithOnlyTheTwoItems()
        {
            var skuCountPromotion = new SkuTwinPromotion('C', 'D', 30.0m);
            var cart = new Cart();
            cart.Add(new SKU('C') {UnitPrice = 20.0m});
            cart.Add(new SKU('D') {UnitPrice = 40.0m});
            var total = skuCountPromotion.Calculate(cart.Items);
            total.ShouldBe(30.0m);
        }

        [Test]
        public void ShouldBeAbleToCalculatePromotionForSkuTwinPromotionWithOnlyFirstItem()
        {
            var skuCountPromotion = new SkuTwinPromotion('C', 'D', 30.0m);
            var cart = new Cart();
            cart.Add(new SKU('C') { UnitPrice = 20.0m });
            var total = skuCountPromotion.Calculate(cart.Items);
            total.ShouldBe(20.0m);
        }

        [Test]
        public void ShouldBeAbleToCalculatePromotionForSkuTwinPromotionWithOnlySecondItem()
        {
            var skuCountPromotion = new SkuTwinPromotion('C', 'D', 30.0m);
            var cart = new Cart();
            cart.Add(new SKU('D') { UnitPrice = 40.0m });
            var total = skuCountPromotion.Calculate(cart.Items);
            total.ShouldBe(40.0m);
        }

        [Test]
        public void ShouldBeAbleToCalculatePromotionForSkuTwinPromotionWithNoMatches()
        {
            var skuCountPromotion = new SkuTwinPromotion('C', 'D', 30.0m);
            var cart = new Cart();
            cart.Add(new SKU('A') { UnitPrice = 10.0m });
            cart.Add(new SKU('B') { UnitPrice = 20.0m });
            var total = skuCountPromotion.Calculate(cart.Items);
            total.ShouldBe(30.0m);
        }


        [Test]
        public void ShouldBeAbleToCalculatePromotionForSkuTwinPromotionTwice()
        {
            var skuCountPromotion = new SkuTwinPromotion('C', 'D', 30.0m);
            var cart = new Cart();
            cart.Add(new SKU('C') { UnitPrice = 20.0m });
            cart.Add(new SKU('D') { UnitPrice = 40.0m });
            cart.Add(new SKU('D') { UnitPrice = 40.0m });
            cart.Add(new SKU('C') { UnitPrice = 20.0m });
            var total = skuCountPromotion.Calculate(cart.Items);
            total.ShouldBe(60.0m);
        }

        [Test]
        public void ShouldBeAbleToCalculatePromotionForSkuTwinPromotionWithOnlyTheTwoItemsReversed()
        {
            var skuCountPromotion = new SkuTwinPromotion('C', 'D', 30.0m);
            var cart = new Cart();
            cart.Add(new SKU('D') { UnitPrice = 40.0m });
            cart.Add(new SKU('C') { UnitPrice = 20.0m });
            var total = skuCountPromotion.Calculate(cart.Items);
            total.ShouldBe(30.0m);
        }
    }
}
