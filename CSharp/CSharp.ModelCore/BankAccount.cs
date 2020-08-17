
namespace CSharp.ModelCore
{
    using System;
    using System.Runtime.InteropServices.WindowsRuntime;

    public abstract class BankAccount
    {
          public double AccountBalance { get; set; }
        public double AccountNo { get; set; }
        public double ServiceCharge { get; set; }
        public int WithDrawCount { get; set; }


        public double Deposit(double n)
        {
            return n;
        }

        public abstract double WithDraw(double n);
    }
}
