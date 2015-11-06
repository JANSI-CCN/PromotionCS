using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionCS
{
    public class DiscountCalculator
    {

        private double discountRate = 0;
        public DiscountCalculator(Promotion promotion)
        {
            discountRate = promotion.DiscountRate;
        }

        public Order CalculateDiscount(Order order)
        {
            for (int i=0; i < order.Items.Count; i++ )
            {
                if (i==1)
                {
                    order.Items[i].Product.Price = order.Items[i].Product.Price * discountRate;
                }
            }

                return order;
        }
    }

}
