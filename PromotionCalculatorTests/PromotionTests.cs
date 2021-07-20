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
    }
}