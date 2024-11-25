namespace BankingApp.Lib;

public class InvestmentAccount : Account
{
    public InvestmentAccount(float interestRate, float failedWithdrawalFee) 
        : base(interestRate, overdraftLimit: 0, failedWithdrawalFee) {}

    public override string Withdraw(float amount, User user)
    {
        if (amount > Balance)
        {
            Balance -= FailedWithdrawalFee * user.GetFeeDiscount();
            transactions.Add(new Transaction("Failed Withdrawal", -FailedWithdrawalFee, Balance));
            return "Withdrawal failed: Insufficient funds. Fee applied.";
        }
        Balance -= amount;
        transactions.Add(new Transaction("Withdrawal", -amount, Balance));
        return $"Withdrawal successful. New balance: {Balance}";
    }

    public override float CalculateInterest()
    {
        float interest = Balance * InterestRate;
        Balance += interest;
        transactions.Add(new Transaction("Interest Added", interest, Balance));
        return interest;
    }
}