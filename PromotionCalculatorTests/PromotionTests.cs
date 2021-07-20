using NUnit.Framework;
using PromotionCalculator;
using Shouldly;

namespace PromotionCalculatorTests
{
    [TestFixture]
    public class PromotionTests
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
    }
}