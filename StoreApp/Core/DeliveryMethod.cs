using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Core
{
    public abstract class DeliveryMethod
    {
        public int Id;
        public string Type;
        public int ProductId;
        public int Quantity;

        public DeliveryMethod(int id, string type, int productId, int quantity)
        {
            Id = id;
            Type = type;
            ProductId = productId;
            Quantity = quantity;
        }

        public abstract int Deliver(int quant);

        public abstract DeliveryMethod Clone();

        public override string ToString()
        {
            return "Id: " + Id + " Type: " + Type + " ProductId: " + ProductId + " Quantity: " + Quantity;
        }

    }
}
