using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Core.Logger
{
    public abstract class Logger
    {
        public object Subject;
        public abstract void Log(string message);

        public abstract void Log(string message, object subject);
        public abstract Logger Clone();
    }
}
