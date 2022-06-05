using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Core.Logger
{
    public class TextBoxLogger : Logger
    {
        public override Logger Clone()
        {
            return this.MemberwiseClone() as Logger;
        }

        public override void Log(string message)
        {
            LogMenu.Instance.UpdateText(this.GetType().Name, message, DateTime.Now.ToString());
        }

        public override void Log(string message, object subject)
        {
            LogMenu.Instance.UpdateText(subject.GetType().Name, message, DateTime.Now.ToString());
        }
    }
}
