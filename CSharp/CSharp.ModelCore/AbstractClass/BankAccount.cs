
namespace CSharp.ModelCore
{
    using System;
    using System.Runtime.InteropServices.WindowsRuntime;

    public abstract class BankAccount
    {

        //A special type of class which cannot be instantiated.
        //Acts as a base or parent class for other classes i.e.derived classes.
        //Members can be abstract and non-abstract.
        //Members declared as abstract must be implemented by the derived classes.

        /*Suppose you want to develop a banking software. Here, a common entity is account information. 
        There can be many types of account like saving account,  current account etc.. 
        */

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
