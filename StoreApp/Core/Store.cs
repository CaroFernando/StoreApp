using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Core
{
    public class Store : Logger.Subject
    {
        public Order currentOrder;
        public int Id;
        public string Name;
        
        public Store(int _id, string _name)
        {
            this.Id = _id;
            this.Name = _name;
        }

        public void SetOrder(Order o)
        {
            this.currentOrder = o;
            message = "New order placed from store " + this.Name;
            Notify();
        }

        public float getTotalPrice()
        {
            return currentOrder.getTotalPrice();
        }

        public string toString()
        {
            return "Store: " + this.Name + " " + this.Id;
        }
    }
}
