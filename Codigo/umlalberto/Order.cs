using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlalberto
{
    internal class Order
    {
        private int number;
        private DateTime date;
        private List<Product> products;
        private float final_price;

        public Order(int number, DateTime date, List<Product> products, float final_price)
        {
            this.number = number;
            this.date = date;
            this.products = products;
            this.final_price = final_price;
        }

        public int getQuantity(Product productA)
        {
            int numero = 0;
            foreach(Product productB in products)
            {
                if (productB.Equals(productA))
                {
                    numero++;
                }
            }
            return numero;
        }
    }
}
