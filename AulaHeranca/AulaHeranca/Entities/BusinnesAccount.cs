
namespace AulaHeranca.Entities
{
    internal class BusinnesAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinnesAccount()
        {
        }
        public BusinnesAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
