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
        public void ShouldBeAbleToCreateSKUWithId()
        {
            var sku = new SKU('A');
            sku.ShouldNotBeNull();
        }

        [Test]
        public void ShouldBeAbleToReadSKUId()
        {
            var sku = new SKU('A');
            var id = sku.Id;
            id.ShouldBe('A');
        }

        [Test]
        public void ShouldBeAbleToAddSKUToCartAddGetASkuItemBack()
        {
            var cart = new Cart();
            var sku = new SKU('A');
            cart.Add(sku);
            var skuItem = cart.item;
            skuItem.ShouldBeOfType(typeof(SKU));
        }

        [Test]
        public void ShouldBeAbleToAddSKUToCartAddGetSameItemBack()
        {
            var cart = new Cart();
            var sku = new SKU('A');
            cart.Add(sku);
            var skuItem = cart.item;
            skuItem.Id.ShouldBe('A');
        }
    }
}