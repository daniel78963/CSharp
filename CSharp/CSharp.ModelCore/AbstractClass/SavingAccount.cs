
namespace CSharp.ModelCore
{
    public class SavingAccount : BankAccount
    {
        public override double WithDraw(double n)
        {
            return n;
        }
    }
}
