using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.CCS
{
    public class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
