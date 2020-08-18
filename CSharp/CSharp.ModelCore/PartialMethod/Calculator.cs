 
namespace CSharp.ModelCore.PartialMethod
{
    using System;

    // Partial Class Part1
    partial class Calculator
    {
        partial void PartialAdd(int x, int y); //declaration
    }

    // Partial Class Part2
    partial class Calculator
    {
        public void Add(int x, int y)
        {
            PartialAdd(x, y);
        }

        partial void PartialAdd(int x, int y) //implementation
        {
            int sum = x + y;
            Console.WriteLine("Sum of {0} and {1} is : {2}", x, y, sum);
        }
    }
}
