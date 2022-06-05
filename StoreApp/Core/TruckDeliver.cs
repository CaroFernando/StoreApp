using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Core
{
    public class TruckDeliver : DeliveryMethod
    {
        public TruckDeliver(int id, int prodid, int quant) 
            : base(id, "Truck", prodid, quant)
        { 
        }

        public override DeliveryMethod Clone()
        {
            return this.MemberwiseClone() as TruckDeliver;
        }

        public override int Deliver(int quant)
        {
            if (quant > Quantity)
            {
                Quantity = 0;
                return quant - Quantity;
            }

            Quantity -= quant;
            return 0;
        }
    }
}
