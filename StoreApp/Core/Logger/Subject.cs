using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Core.Logger
{
    public abstract class Subject
    {
        private List<Logger> loggers = new List<Logger>();
        public string message = "";

        public void Attach(Logger logger)
        {
            loggers.Add(logger);
        }

        public void Detach(Logger logger)
        {
            loggers.Remove(logger);
        }

        public void Notify()
        {
            if (GlobalLogger.Enable)
            {
                foreach (Logger l in GlobalLogger.loggers)
                {
                    l.Log(message, this);
                }
            }
            
            foreach (Logger logger in loggers)
            {
                logger.Log(message);
            }
        }
    }
}
