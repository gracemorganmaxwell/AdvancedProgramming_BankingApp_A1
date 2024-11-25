namespace BankingApp.Lib
{
    public class EverydayAccount : Account
    {
        public EverydayAccount() : base(interestRate: 0, overdraftLimit: 0, failedWithdrawalFee: 0) {}

        public override string Withdraw(float amount, User user)
        {
            if (amount > Balance)
            {
                return "Withdrawal failed: Insufficient funds.";
            }
            Balance -= amount;
            transactions.Add(new Transaction("Withdrawal", -amount, Balance));
            return $"Withdrawal successful. New balance: {Balance}";
        }

        public override float CalculateInterest()
        {
            return 0; // No interest for EverydayAccount
        }
    }
}