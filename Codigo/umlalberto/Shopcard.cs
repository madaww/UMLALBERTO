using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlalberto
{
    internal class Shopcard
    {
        private User user;
        private List<Product> list;

        public Shopcard(User user, List<Product> list)
        {
            this.user = user;
            this.list = list;
        }

        public void addProduct(Product product)
        {
            list.Add(product);
        }
        public void removeProduct(Product productA)
        {
            foreach(Product productB in list) 
            { 
                if(productB.Equals(productA)) 
                {
                    list.Remove(productB);
                }
            }
        }
        public void removeAllProducts()
        {
            list.Clear();
        }
        public Order buyProducts()
        {
            float precioTotal = 0;
            foreach (Product product in list)
            {
                precioTotal += product.base_price * product.discount;
            }
            Order order = new Order(0, DateTime.Now, list, precioTotal);
            removeAllProducts();
            return order;
        }
    }
}
