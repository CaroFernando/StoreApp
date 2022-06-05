using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Core.QR
{
    public class QRApiAdapter : Target
    {
        public StoreApp.Core.QR.QRApiCaller adaptee;
        
        public string getQR(Store s)
        {
            var a = JsonConvert.SerializeObject(s);
            string filename = s.Id + ".png";

            adaptee.getQRCall(a, filename);
            return filename;
        }
        
        public Store readQR(String qrfilelocation)
        {
            string res = adaptee.getObjCall(qrfilelocation);
            Store s = JsonConvert.DeserializeObject<Store>(res);

            return s;
        }
    }
}
