using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Core
{
    public class Manager
    {
        // singleton 
        private static Manager instance;
        private Manager() { }
        public static Manager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Manager();
                }
                return instance;
            }
        }

        public Route CurrentRoute;

        public void AddStore(Store store)
        {
            if (CurrentRoute == null)
            {
                CurrentRoute = new Route();
            }
            CurrentRoute.addStore(store);
        }

        public bool ValidateRoute()
        {
            return CurrentRoute.ValidateRoute();
        }

        public void DeliverCurrentRoute()
        {
            if (CurrentRoute == null || !CurrentRoute.ValidateRoute())
            {
                throw new Exception("Invalid Route");
            }
            
            List<Store> route = CurrentRoute.GenerateRoute();

            foreach (Store store in route)
            {
                Console.WriteLine("Delivering to " + store.Name);
                CurrentRoute.removeStore(store);

                Console.Write("Reading tomorrow order");
                
            }

            
        }
    }
}
