using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Core.Logger
{
    public class TextLogger : Logger
    {
        public override Logger Clone()
        {
            return this.MemberwiseClone() as Logger;
        }

        public override void Log(string message)
        {
            string path = "log.txt";
            string logmessage = String.Format("Time: {0} Message: {1} From: {2}", DateTime.Now, message, this.Subject.ToString());

            // create file if not exists, write message and close
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
            {
                file.WriteLine(logmessage);
            }

        }

        public override void Log(string message, object subject)
        {
            string path = "log.txt";
            string logmessage = String.Format("Time: {0} Message: {1} From: {2}", DateTime.Now, message, subject.ToString());

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
            {
                file.WriteLine(logmessage);
            }
        }
    }
}
