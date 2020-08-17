
namespace CSharp.ModelCore
{
    public class SavingAccount : BankAccount
    {
        public override string Withdraw(decimal money)
        {
            if (AccountBalance > money)
            {
                if (WithdrawCount > 5)
                {
                    AccountBalance -= (money + ServiceCharge);
                    WithdrawCount += 1;
                    return "Withdraw transaction done sucessfully!";
                }
                else
                {
                    AccountBalance -= money;
                    WithdrawCount += 1;
                    return "Withdraw transaction done sucessfully!";
                }
            }
            else
            {
                return "Withdraw transaction can't be done. Since, you have low account balance!";
            }
        }
    }
}
