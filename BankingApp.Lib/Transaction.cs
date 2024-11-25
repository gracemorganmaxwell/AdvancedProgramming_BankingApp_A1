namespace BankingApp.Lib;

public class Transaction
{
    public int TransactionId { get; private set; }
    public string TransactionType { get; private set; }
    public float Amount { get; private set; }
    public DateTime Timestamp { get; private set; }
    public float BalanceAfterTransaction { get; private set; }
    private static int transactionCount = 0;

    public Transaction(string transactionType, float amount, float balanceAfterTransaction)
    {
        TransactionId = ++transactionCount;
        TransactionType = transactionType;
        Amount = amount;
        BalanceAfterTransaction = balanceAfterTransaction;
        Timestamp = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{TransactionType}: {Amount} on {Timestamp}, Balance after: {BalanceAfterTransaction}";
    }
}