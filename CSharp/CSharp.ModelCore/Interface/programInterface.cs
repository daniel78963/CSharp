using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.ModelCore.Interface
{
    class programInterface
    {
        static void Main(string[] args)
        {
            // File Logger
            ILog fileLogger = new FileLog();

            // Console Logger
            ILog consoleLogger = new ConsoleLog();

            try
            {
                int x = 0, y = 4;
                int z = y % x; // throw divide by zero exception
            }
            catch (Exception ex)
            {
                fileLogger.Log(ex.Message);
                consoleLogger.Log(ex.Message);
            }
        }
    }
}
