using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Core
{
    public class Order : Logger.Subject
    {
        public int orderID;
        public int storeID;
        public List<Product> products;

        public Order(int orderID, int storeID)
        {
            this.orderID = orderID;
            this.storeID = storeID;
            products = new List<Product>();
        }

        public void addProduct(Product product)
        {
            this.message = "Added product " + product.id + " to order " + orderID;
            this.Notify();
            products.Add(product);
        }

        public float getTotalPrice()
        {
            float totalPrice = 0;
            foreach (Product product in products)
            {
                totalPrice += product.getTotalPrice();
            }
            return totalPrice;
        }

    }
}
