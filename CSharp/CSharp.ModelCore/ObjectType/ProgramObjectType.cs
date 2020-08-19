
namespace CSharp.ModelCore.ObjectType
{
    using System;

    class ProgramObjectType
    {
        public static void Main()
        {
            Utility util = new Utility(); 

            //string result
            object result1 = util.Add("Shailendra", "Chauhan");
            Console.WriteLine(result1);

            //integer result
            object result2 = util.Add(3, 2);
            if (result2 is int)
                Console.WriteLine("Sum of numbers is : {0}", result2);

            //string error message
            object result3 = util.Add("Hello", 0);
            Console.WriteLine(result3);
        }
    }
}
