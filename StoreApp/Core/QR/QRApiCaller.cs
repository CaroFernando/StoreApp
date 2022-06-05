using System.Net;
using System.IO;
using System;
using System.Drawing.Imaging;
using System.Drawing;
using IronBarCode;

namespace StoreApp.Core.QR
{
    public class QRApiCaller : Logger.Subject
    {
        public void getQRCall(string obj, string fileName)
        {
            string url = "https://api.qrserver.com/v1/create-qr-code/?size=150x150&data=" + obj;
            WebRequest request = WebRequest.Create(url);
            request.Method = "GET";
            HttpWebResponse response = null;
            response = (HttpWebResponse)request.GetResponse();
            var stream = response.GetResponseStream();
            
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            
            Bitmap img = new Bitmap(stream);
            using (MemoryStream memory = new MemoryStream())
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite))
                {
                    img.Save(memory, ImageFormat.Bmp);
                    byte[] bytes = memory.ToArray();
                    fs.Write(bytes, 0, bytes.Length);
                    fs.Dispose();
                }
            }

            this.message = "Creating qr in file" + fileName;
            this.Notify();            
        }

        public string getObjCall(string location)
        {
            BarcodeResult Result = BarcodeReader.QuicklyReadOneBarcode(location, BarcodeEncoding.QRCode);
            string content = Result.Text;
            return content;
        }
    }
}
