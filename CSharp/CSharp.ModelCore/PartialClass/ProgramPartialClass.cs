
namespace CSharp.ModelCore.ExtensionMethod
{
    using System;

    class ProgramPartialClass
    {
        static void Main(string[] args)
        {
            int num1 = 4, num2 = 2;
            Calculator calc = new Calculator();

            int sum = calc.Add(num1, num2);
            Console.WriteLine("Sum of {0} and {1} is : {2}", num1, num2, sum);

            int subtract = calc.Subtract(num1, num2);
            Console.WriteLine("Subtraction of {0} and {1} is : {2}", num1, num2, subtract);
        }
    }
}
