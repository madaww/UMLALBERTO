using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlalberto
{
    internal class Review
    {
        private User user;
        public Product product;
        public int rating;
        public string coment;

        public Review(User user, Product product, int rating, string coment)
        {
            this.user = user;
            this.product = product;
            this.rating = rating;
            this.coment = coment;
        }
    }
}
