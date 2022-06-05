using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Core.Logger
{
    public class TableLogger : Logger
    {
        public override Logger Clone()
        {
            return this.MemberwiseClone() as TableLogger;
        }

        public override void Log(string message)
        {
            LogMenu.Instance.UpdateTable(this.Subject.ToString(), message, DateTime.Now.ToString());
        }

        public override void Log(string message, object subject)
        {
            LogMenu.Instance.UpdateTable(subject.ToString(), message, DateTime.Now.ToString());
        }
    }
}
