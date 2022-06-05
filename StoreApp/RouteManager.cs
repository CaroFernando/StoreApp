using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp
{
    public static class RouteManager
    {
        public static Core.Route route = new Core.Route();
        private static int currId = 0;
        private static int currOrderId = 0;

        public static void addStore(Core.Store s)
        {
            route.addStore(s);
        }

        public static void removeStore(Core.Store s)
        {
            route.removeStore(s);
        }

        public static void removeStore(int id)
        {
            route.removeStore(id);
        }

        public static int getNextId()
        {
            return currId++;
        }

        public static int getNextOrderId()
        {
            return currOrderId++;
        }
        
        public static bool addDelivery(Core.DeliveryMethod d){
            return route.addDelivery(d);
        }
    }
}
