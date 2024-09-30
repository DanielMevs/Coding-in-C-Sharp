namespace Events.Exercises
{
    public delegate void OnBalanceDecreased(decimal balance);

    public class BankAccount
    {
        public decimal Balance { get; private set; }
        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }
        public event OnBalanceDecreased OnBalanceDecreased;

        public void DecreaseBalance(decimal price)
        {
            if (Balance >= price)
            {
                Balance -= price;
                OnBalanceDecreased?.Invoke(price);
            }
            else
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
        }
    }

    public class User
    {
        public decimal Funds { get; private set; }

        public User(decimal cash, decimal moneyInBank)
        {
            Funds = cash + moneyInBank;
        }

        public void ReduceFunds(decimal balanceReduced)
        {
            Funds -= balanceReduced;
        }
    }
}
