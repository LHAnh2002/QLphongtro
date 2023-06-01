using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro.BUS
{
    class Log
    {
        private static string logName = "Log_";
        private static string logExtendtion = ".log";

        public static void WriteLog(string content)
        {
            string logNameToWrite = logName + DateTime.Now.ToLongDateString() + logExtendtion;
            StreamWriter sw = new StreamWriter(logNameToWrite, true);
            sw.WriteLine(DateTime.Now + " ## " + content);
            sw.Close();
        }
    }
}
