
namespace CSharp.ModelCore.Interface
{
    using System;

    public class FileLog : ILog
    {
        public void Log(string msg)
        {
            Console.WriteLine("Logging error message into file");
            // TO DO: Write code for saving error into file
            Console.WriteLine(msg);
        }
    }
}
