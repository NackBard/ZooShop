using System.Collections.Generic;

namespace MyEShop.Models
{
    public class Cart
    {
        public Cart()
        {
            CartLines = new List<Products>();
        }
        public List<Products> CartLines { get; set; }
        public int finalPrice
        {
            get
            {
                int sum = 0;
                foreach (Products products in CartLines)
                {
                    sum += products.Price;
                }
                return sum;
            }
        }
    }
}
