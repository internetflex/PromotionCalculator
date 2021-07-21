using System.Collections.Generic;

namespace PromotionCalculator
{
    public class SkuTwinPromotion
    {
        private readonly char _id1;
        private readonly char _id2;
        private readonly decimal _price;

        public SkuTwinPromotion(char id1, char id2, decimal price)
        {
            _id1 = id1;
            _id2 = id2;
            _price = price;
        }

        public decimal Calculate(IEnumerable<SKU> cartItems)
        {
            decimal total = 0;
            var haveId1 = false;
            var haveId2 = false;
            var idSubTotal = 0m;

            foreach (var item in cartItems)
            {
                if (item.Id == _id1 || item.Id == _id2)
                {
                    if (item.Id == _id1)
                    {
                        haveId1 = true;
                        idSubTotal += item.UnitPrice;
                    }
                    else
                    {
                        haveId2 = true;
                        idSubTotal += item.UnitPrice;
                    }
                }
                else
                {
                    total += item.UnitPrice;
                }

                if (haveId1 && haveId2)
                {
                    total += _price;
                    haveId1 = false;
                    haveId2 = false;
                    idSubTotal = 0;
                }
            }

            return total + idSubTotal;
        }
    }
}