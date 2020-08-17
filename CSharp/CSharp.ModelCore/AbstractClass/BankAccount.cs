
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

        public string AccountNo { get; set; }
        public decimal AccountBalance { get; set; }
        public decimal ServiceCharge { get; set; } = 10;
        public int WithdrawCount { get; set; } = 0;


        public string Deposit(decimal money)
        {
            AccountBalance += money;
            return "Deposit transaction done sucessfully!";
        }

        public abstract string Withdraw(decimal money);
    }
}
