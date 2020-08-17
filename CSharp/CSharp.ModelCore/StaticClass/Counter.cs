
namespace CSharp.ModelCore.StaticClass
{
    using System;
    static class Counter
    {
        static int count;
        static Counter()
        {
            count++;
        }

        public static void Display()
        {
            Console.WriteLine("Count ={0}", count);
            Console.WriteLine("Hi, I am static method, called directly by class name!");
        }

    }
}
