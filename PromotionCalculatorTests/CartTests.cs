using System.Linq;
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
            var skuItem = cart.Items;
            skuItem.ToList()[0].ShouldBeOfType(typeof(SKU));
        }

        [Test]
        public void ShouldBeAbleToAddSKUToCartAddGetSameItemBack()
        {
            var cart = new Cart();
            var sku = new SKU('A');
            cart.Add(sku);
            var skuItem = cart.Items;
            skuItem.ToList()[0].Id.ShouldBe('A');
        }

        [Test]
        public void ShouldBeAbleToAdd2SKUToCart_ThenItemCountShouldBe2()
        {
            var cart = new Cart();
            cart.Add(new SKU('A'));
            cart.Add(new SKU('B'));
            cart.ItemCount.ShouldBe(2);
        }

        [Test]
        public void ShouldBeAbleToAdd1SKUToCart_ThenItemCountShouldBe1()
        {
            var cart = new Cart();
            cart.Add(new SKU('A'));
            cart.ItemCount.ShouldBe(1);
        }


        [Test]
        public void ShouldBeAbleToAdd2SKUToCart_ThenItemShouldBeSameAsThoseAdded()
        {
            var cart = new Cart();
            cart.Add(new SKU('A'));
            cart.Add(new SKU('B'));
            var itemList = cart.Items.ToList();
            itemList[0].Id.ShouldBe('A');
            itemList[1].Id.ShouldBe('B');
        }
    }
}