using NUnit.Framework;
using PromotionCalculator;
using Shouldly;

namespace PromotionCalculatorTests
{
    public class CartTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldBeAbleToCreateACart()
        {
            var cart = new Cart();
            cart.ShouldNotBeNull();
        }

        [Test]
        public void ShouldBeAbleToCreateASKU()
        {
            var cart = new SKU();
            cart.ShouldNotBeNull();
        }
    }
}