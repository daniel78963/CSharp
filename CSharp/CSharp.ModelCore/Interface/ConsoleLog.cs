
namespace CSharp.ModelCore.Interface
{
    using System;

    public class ConsoleLog : ILog
    {
        public void Log(string msg)
        {
            Console.WriteLine("Logging error message into console");
            Console.WriteLine(msg);
        }
    }
}
