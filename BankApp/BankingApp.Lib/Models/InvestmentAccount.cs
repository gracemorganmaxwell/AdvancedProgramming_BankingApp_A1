namespace BankingApp.Lib.Models
{
    /// <summary>
    /// Represents an Investment Account that accrues interest on the balance.
    /// This account does not allow overdrafts but applies a fee for failed withdrawals.
    /// </summary>
    public class InvestmentAccount : Account
    {
        /// <summary>
        /// Initializes an Investment Account with a specified interest rate and failed withdrawal fee.
        /// </summary>
        /// <param name="interestRate">Interest rate applied to the account</param>
        /// <param name="failedWithdrawalFee">Penalty fee applied for failed withdrawals</param>
        public InvestmentAccount(float interestRate, float failedWithdrawalFee)
            : base(interestRate, overdraftLimit: 0, failedWithdrawalFee) { }

        /// <summary>
        /// Attempts to withdraw the specified amount. 
        /// If funds are insufficient, penalty logic from the base class is applied.
        /// </summary>
        /// <param name="amount">Amount to withdraw</param>
        /// <param name="user">User attempting the withdrawal</param>
        /// <returns>A message indicating whether the withdrawal was successful or failed</returns>
        public override string Withdraw(float amount, User user)
        {
            return base.Withdraw(amount, user); // Uses the penalty logic from `Account`
        }

        /// <summary>
        /// Calculates and applies interest to the account balance.
        /// </summary>
        /// <returns>The interest amount that was added</returns>
        public override float CalculateInterest()
        {
            float interest = Balance * InterestRate;
            Balance += interest;
            transactions.Add(new Transaction("Interest Added", interest, Balance));
            return interest;
        }
    }
}