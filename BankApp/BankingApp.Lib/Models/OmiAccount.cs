namespace BankingApp.Lib.Models
{
    /// <summary>
    /// Represents an Omni Account, which allows overdrafts up to a specified limit.
    /// This account also accrues interest if the balance exceeds $1000.
    /// </summary>
    public class OmniAccount : Account
    {
        /// <summary>
        /// Initializes an Omni Account with an interest rate, overdraft limit, and failed withdrawal fee.
        /// </summary>
        /// <param name="interestRate">Interest rate applied when balance exceeds $1000</param>
        /// <param name="overdraftLimit">The maximum overdraft allowed</param>
        /// <param name="failedWithdrawalFee">The fee charged for failed withdrawal attempts</param>
        public OmniAccount(float interestRate, float overdraftLimit, float failedWithdrawalFee)
            : base(interestRate, overdraftLimit, failedWithdrawalFee) { }

        /// <summary>
        /// Attempts to withdraw the specified amount.
        /// OmniAccounts allow overdrafts within the allowed limit.
        /// If the withdrawal exceeds the overdraft limit, a penalty fee is applied.
        /// </summary>
        /// <param name="amount">Amount to withdraw</param>
        /// <param name="user">User attempting the withdrawal</param>
        /// <returns>A message indicating whether the withdrawal was successful or failed</returns>
        public override string Withdraw(float amount, User user)
        {
            return base.Withdraw(amount, user); // Uses base class logic, which applies penalties if necessary
        }

        /// <summary>
        /// Calculates and applies interest to the account if the balance exceeds $1000.
        /// </summary>
        /// <returns>The interest amount added to the balance, or 0 if balance is below the threshold</returns>
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
}
