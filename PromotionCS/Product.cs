using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PromotionCS
{
    public class Product
    {
        public Product(string sku, string style, string name, double price)
        {
            Sku = sku;
            Name = name;
            Price = price;
            Style = style;
        }

        public string Sku { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Style { get; set; }
    }
}
