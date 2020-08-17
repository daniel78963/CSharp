
namespace CSharp.ModelCore.AbstractClass
{
    using System;

    class ProgramAbstract
    {
        static void Main(string[] args)
        {
            // Saving Account
            SavingAccount objSavingsAccount = new SavingAccount();
            objSavingsAccount.AccountNo = "0110124567854326";

            Console.WriteLine("Saving Account Number: " + objSavingsAccount.AccountNo);
            string msg = objSavingsAccount.Deposit(5000);
            Console.WriteLine(msg);

            msg = objSavingsAccount.Withdraw(100);
            Console.WriteLine(msg);

            // Current Account
            CurrentAccount objCurrentAccount = new CurrentAccount();
            objCurrentAccount.AccountNo = "01206514265001245";

            Console.WriteLine("\nCurrent Account Number: " + objCurrentAccount.AccountNo);
            msg = objCurrentAccount.Deposit(10000);
            Console.WriteLine(msg);

            msg = objCurrentAccount.Withdraw(5000);
            Console.WriteLine(msg);
        }
    }
}
