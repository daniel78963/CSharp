
namespace CSharp.ModelCore
{
    public class CurrentAccount : BankAccount
    {
        public override string Withdraw(decimal money)
        {
            if (AccountBalance > money)
            {
                AccountBalance -= money;
                WithdrawCount++;
                return "Withdraw transaction done sucessfully!";
            }
            else
            {
                return "Withdraw transaction can't be done. Since, you have low account balance!";
            }
        }
    }
}
