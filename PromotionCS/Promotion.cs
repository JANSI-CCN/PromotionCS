using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionCS
{
    public class Promotion
    {
  
        public double DiscountRate
        {
            get;
            set; 
        }

        public void setPromo (double promo)
        {
            DiscountRate = promo;
        }
    }
}
