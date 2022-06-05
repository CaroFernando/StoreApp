using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Core.Logger
{
    public static class GlobalLogger
    {
        public static List<Logger> loggers = new List<Logger>();
        public static bool Enable = false;

        public static int TextLoggerCont = 0;
        public static int GridLoggerCont = 0;
        public static int TextBoxLoggerCont = 0;

        static GlobalLogger()
        {
        }

        public static void addLogger(Logger l)
        {
            loggers.Add(l);
        }

        public static void addTextLogger()
        {
            Enable = true;
            loggers.Add(new TextLogger());
            TextLoggerCont++;
        }
        
        public static void addGridLogger()
        {
            Enable = true;
            loggers.Add(new TableLogger()); ;
            GridLoggerCont++;
        }

        public static void addTextBoxLogger()
        {
            Enable = true;
            loggers.Add(new TextBoxLogger());
            TextBoxLoggerCont++;
        }

        public static void Reset()
        {
            loggers.Clear();
            TextLoggerCont = 0;
            GridLoggerCont = 0;
            TextBoxLoggerCont = 0;
        }
    }
}
