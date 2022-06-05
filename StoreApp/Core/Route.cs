using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Core
{
    public class Route : Core.Logger.Subject
    {
        public List<Store> stores;
        public List<DeliveryMethod> deliveries;

        private Dictionary<int, double> productsTotalItems = new Dictionary<int, double>();
        private Dictionary<int, double> deliveryCapacity = new Dictionary<int, double>();

        public bool Validated = false;

        public Route()
        {
            stores = new List<Store>();
            deliveries = new List<DeliveryMethod>();
        }

        public void addStore(Store store)
        {
            stores.Add(store);
            Validated = false;
        }

        public void removeStore(Store s)
        {
            // remove store from list
            stores.Remove(s);
            Validated = false;
        }

        public void removeStore(int id)
        {
            // remove store from list
            stores.Remove(stores.Find(x => x.Id == id));
            Validated = false;
        }

        public void Deliver(Store s)
        {
            removeStore(s.Id);
        }

        public bool addDelivery(DeliveryMethod delivery)
        {
            if(deliveries.Count < 5)
            {
                this.message = "Adding delivery method " + delivery.ToString();
                this.Notify();
                deliveries.Add(delivery);
                Validated = false;
                return true;
            }
            return false;
        }

        public void printStores()
        {
            foreach (Store s in stores)
            {
                Console.WriteLine(s.ToString());
            }
        }

        public void resetDeliveries()
        {
            deliveries.Clear();
            Validated = false;
        }

        public bool ValidateRoute()
        {
            this.message = "Simulating route...";
            this.Notify();
            
            foreach (Store s in stores)
            {
                if (s.currentOrder == null) continue;
                foreach (Product p in s.currentOrder.products)
                {
                    if (productsTotalItems.ContainsKey(p.id))
                    {
                        productsTotalItems[p.id] += p.quantity;
                    }
                    else
                    {
                        productsTotalItems.Add(p.id, p.quantity);
                    }
                }
            }

            foreach (DeliveryMethod dm in deliveries)
            {
                if (deliveryCapacity.ContainsKey(dm.ProductId))
                {
                    deliveryCapacity[dm.ProductId] += dm.Quantity;
                }
                else
                {
                    deliveryCapacity.Add(dm.ProductId, dm.Quantity);
                }
            }

            List<int> keys = new List<int>();
            foreach (int key in deliveryCapacity.Keys) keys.Add(key);

            this.message = "Simulating completed with invalid route.";

            foreach (int key in keys)
            {
                if (productsTotalItems.ContainsKey(key))
                {
                    if (productsTotalItems[key] > deliveryCapacity[key])
                    {
                        productsTotalItems[key] -= deliveryCapacity[key];
                        deliveryCapacity[key] = 0;
                    }
                    else
                    {
                        deliveryCapacity[key] -= productsTotalItems[key];
                        productsTotalItems[key] = 0;
                    }
                }
                else
                {
                    this.Notify();
                    return false;
                }
            }

            foreach (KeyValuePair<int, double> d in productsTotalItems)
            {
                if (d.Value > 0)
                {
                    this.Notify();
                    return false;
                }
            }

            Validated = true;

            this.message = "Simulating completed with valid route.";
            this.Notify();

            return true;
        }

        public List<Store> GenerateRoute()
        {
            if (Validated)
            {
                //Console.WriteLine("Validated... Generating Route...");
                List<Store> sortedList = new List<Store>();
                foreach (Store s in stores)
                {
                    if(s.currentOrder != null) sortedList.Add(s);
                }

                List<Store> SortedList = sortedList.OrderBy(s => -s.getTotalPrice()).ToList();

                return SortedList;
            }

            return new List<Store>();
        }

    }
}
