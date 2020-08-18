
namespace CSharp.ModelCore.ExtensionMethod
{
    using System;

    class ProgramExtensionMethod
    {
        static void Main(string[] args)
        {
            string content = "This is Extension Method example.";

            //calling Extension Method WordCount  
            int totalWords = content.WordCount();
            Console.WriteLine("Total number of words  are : " + totalWords);
        }
    }
}
