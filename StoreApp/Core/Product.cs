using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Core
{
    public class Product
    {
        public int id;
        public string name;
        public float price;
        public float quantity;

        public Product(int _id, string _name, float _price, float _quantity)
        {
            this.id = _id;
            this.name = _name;
            this.price = _price;
            this.quantity = _quantity;
        }

        public float getTotalPrice()
        {
            return this.price * this.quantity;
        }
    }
}
