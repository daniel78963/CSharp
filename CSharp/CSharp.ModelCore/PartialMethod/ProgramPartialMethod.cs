
namespace CSharp.ModelCore.PartialMethod
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class ProgramPartialMethod
    {
        static void Main(string[] args)
        {
            int num1 = 4, num2 = 2;

            Calculator calc = new Calculator();
            calc.Add(num1, num2);
        }
    }
}
