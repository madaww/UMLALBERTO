using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlalberto
{
    internal class Product
    {
        private int id;
        private bool visible;
        public string name;
        public string brand;
        public BitArray image;
        public string description;
        public float base_price;
        public int discount;
        public List<string> labels;
        public HighCategory highCategory;
        public MediumCategory mediumCategory;
        public LowCategory lowCategory;

        public Product(int id, bool visible, string name, string brand, BitArray image, string description, float base_price, int discount, List<string> labels, HighCategory highCategory, MediumCategory mediumCategory, LowCategory lowCategory)
        {
            this.id = id;
            this.visible = visible;
            this.name = name;
            this.brand = brand;
            this.image = image;
            this.description = description;
            this.base_price = base_price;
            this.discount = discount;
            this.labels = labels;
            this.highCategory = highCategory;
            this.mediumCategory = mediumCategory;
            this.lowCategory = lowCategory;
        }
    }
}
