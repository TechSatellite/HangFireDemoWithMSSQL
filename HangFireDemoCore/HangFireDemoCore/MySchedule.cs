using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HangFireDemoCore
{
    public class MySchedule
    {
        /// <summary>
        /// Write your business logic in the method which is going to be scheduled
        /// </summary>
        public void RunMyScheduledMethod()
        {
            WriteLog("My scheduled method is triggered at ");

        }
        public void WriteLog(string msg)
        {
            using (StreamWriter sw = new StreamWriter(@"E:\HangFireDemoLog.txt", true))
            {
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + " ==> " + msg);
            }
        }
    }
    
}
