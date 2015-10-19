using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Core
{
    class Logger
    {
        public static void Info(String message)
        {
            Console.Out.WriteLine("INFO: " + message);
        }

        public static void Warning(String message)
        {
            Console.Out.WriteLine("WARNING: " + message);
        }
    }
}
