using NUnit.Framework;
using PromotionCalculator;
using Shouldly;

namespace PromotionCalculatorTests
{
    [TestFixture]
    public class SkuTests
    {
        [Test]
        public void ShouldBeAbleToSetAndGetUnitPriceForSku()
        {
            var sku = new SKU('A') {UnitPrice = 10.1m};
            sku.UnitPrice.ShouldBe(10.1m);
        }
    }
}