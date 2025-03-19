namespace BankingApp.Lib
{
    /// <summary>
    /// Represents an Everyday Account, which does not allow overdrafts or earn interest.
    /// This type of account is meant for regular transactions with no additional fees.
    /// </summary>
    public class EverydayAccount : Account
    {
        /// <summary>
        /// Initializes a new instance of the EverydayAccount class.
        /// Sets the interest rate, overdraft limit, and failed withdrawal fee to 0.
        /// </summary>
        public EverydayAccount() : base(interestRate: 0, overdraftLimit: 0, failedWithdrawalFee: 0) { }

        /// <summary>
        /// Attempts to withdraw the specified amount from the account.
        /// An Everyday Account does not allow overdrafts, so withdrawals are restricted to available funds.
        /// </summary>
        /// <param name="amount">The amount to withdraw</param>
        /// <param name="user">The user requesting the withdrawal</param>
        /// <returns>A message indicating whether the withdrawal was successful or failed due to insufficient funds</returns>
        public override string Withdraw(float amount, User user)
        {
            // Check if the balance is sufficient for the withdrawal
            if (amount > Balance)
            {
                return "Withdrawal failed: Insufficient funds.";
            }

            // Deduct the withdrawal amount from the balance
            Balance -= amount;

            // Record the transaction in the account history
            transactions.Add(new Transaction("Withdrawal", -amount, Balance));

            return $"Withdrawal successful. New balance: {Balance}";
        }

        /// <summary>
        /// Calculates interest for the Everyday Account.
        /// Everyday accounts do not earn interest, so this method always returns 0.
        /// </summary>
        /// <returns>Returns 0 as interest is not applicable for this account type</returns>
        public override float CalculateInterest()
        {
            return 0; // Everyday accounts do not earn interest
        }
    }
}
