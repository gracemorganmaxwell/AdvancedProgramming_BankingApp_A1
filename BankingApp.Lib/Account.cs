namespace BankingApp.Lib;

public abstract class Account
{
    public int AccountId { get; private set; }
    public float Balance { get; protected set; }
    public float InterestRate { get; protected set; }
    public float OverdraftLimit { get; protected set; }
    public float FailedWithdrawalFee { get; protected set; }
    private static int accountCount = 0;
    protected List<Transaction> transactions;

    public Account(float interestRate, float overdraftLimit, float failedWithdrawalFee)
    {
        AccountId = ++accountCount;
        InterestRate = interestRate;
        OverdraftLimit = overdraftLimit;
        FailedWithdrawalFee = failedWithdrawalFee;
        transactions = new List<Transaction>();
    }

    public virtual void Deposit(float amount)
    {
        Balance += amount;
        transactions.Add(new Transaction("Deposit", amount, Balance));
    }

    public abstract string Withdraw(float amount, User user);

    public abstract float CalculateInterest();

    public string GetLastTransaction()
    {
        return transactions.Count > 0 ? transactions[^1].ToString() : "No transactions available.";
    }
}