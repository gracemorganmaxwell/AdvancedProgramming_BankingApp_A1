namespace BankingApp.Lib;

public class OmniAccount : Account
{
    public OmniAccount(float interestRate, float overdraftLimit, float failedWithdrawalFee) 
        : base(interestRate, overdraftLimit, failedWithdrawalFee) {}

    public override string Withdraw(float amount, User user)
    {
        if (amount > Balance + OverdraftLimit)
        {
            Balance -= FailedWithdrawalFee * user.GetFeeDiscount();
            transactions.Add(new Transaction("Failed Withdrawal", -FailedWithdrawalFee, Balance));
            return "Withdrawal failed: Overdraft limit exceeded. Fee applied.";
        }
        Balance -= amount;
        transactions.Add(new Transaction("Withdrawal", -amount, Balance));
        return $"Withdrawal successful. New balance: {Balance}";
    }

    public override float CalculateInterest()
    {
        if (Balance > 1000)
        {
            float interest = Balance * InterestRate;
            Balance += interest;
            transactions.Add(new Transaction("Interest Added", interest, Balance));
            return interest;
        }
        return 0;
    }
}