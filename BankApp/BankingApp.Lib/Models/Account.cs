namespace BankingApp.Lib.Models
{
    using System.Collections.Generic;
    using Lib.Models;

    /// <summary>
    /// Represents a generic bank account with basic financial operations.
    /// This class serves as a base for specific account types (e.g., EverydayAccount, InvestmentAccount, OmniAccount).
    /// </summary>
    public abstract class Account
    {
        /// <summary>
        /// Unique identifier for each account.
        /// </summary>
        public int AccountId { get; private set; }

        /// <summary>
        /// Current balance in the account.
        /// </summary>
        public float Balance { get; protected set; }

        /// <summary>
        /// Interest rate applicable to the account (if any).
        /// </summary>
        public float InterestRate { get; protected set; }

        /// <summary>
        /// Maximum overdraft limit allowed for this account.
        /// </summary>
        public float OverdraftLimit { get; protected set; }

        /// <summary>
        /// Fee applied for failed withdrawal attempts due to insufficient funds.
        /// </summary>
        public float FailedWithdrawalFee { get; protected set; }

        /// <summary>
        /// Static counter to generate unique account IDs.
        /// </summary>
        private static int accountCount = 0;

        /// <summary>
        /// List to maintain the history of transactions for this account.
        /// </summary>
        protected List<Transaction> transactions;

        /// <summary>
        /// Initializes a new instance of an account with specified financial parameters.
        /// </summary>
        /// <param name="interestRate">Interest rate applied to the account</param>
        /// <param name="overdraftLimit">Overdraft limit allowed for this account</param>
        /// <param name="failedWithdrawalFee">Penalty fee for failed withdrawals</param>
        public Account(float interestRate, float overdraftLimit, float failedWithdrawalFee)
        {
            // Assign unique account ID
            AccountId = ++accountCount;

            // Assign provided values
            InterestRate = interestRate;
            OverdraftLimit = overdraftLimit;
            FailedWithdrawalFee = failedWithdrawalFee;

            // Initialize transaction history list
            transactions = new List<Transaction>();
        }

        /// <summary>
        /// Deposits a specified amount into the account and records the transaction.
        /// </summary>
        /// <param name="amount">Amount to deposit</param>
        public virtual void Deposit(float amount)
        {
            Balance += amount;
            transactions.Add(new Transaction("Deposit", amount, Balance));
        }

        /// <summary>
        /// Attempts to withdraw a specified amount from the account.
        /// If the withdrawal fails due to insufficient funds, a penalty fee is applied.
        /// </summary>
        /// <param name="amount">Amount to withdraw</param>
        /// <param name="user">User performing the transaction</param>
        /// <returns>A message indicating success or failure of the withdrawal</returns>
        public virtual string Withdraw(float amount, User user)
        {
            // Check if the withdrawal exceeds the available balance plus overdraft limit
            if (amount > Balance + OverdraftLimit)
            {
                // Calculate and apply penalty
                float penalty = FailedWithdrawalFee * user.GetFeeDiscount();
                Balance -= penalty;

                // Log penalty transaction
                transactions.Add(new Transaction("Failed Withdrawal - Penalty Applied", -penalty, Balance));

                return $"Withdrawal failed: Overdraft limit exceeded. Penalty of {penalty} applied.";
            }

            // Deduct the withdrawal amount from the balance
            Balance -= amount;

            // Log withdrawal transaction
            transactions.Add(new Transaction("Withdrawal", -amount, Balance));

            return $"Withdrawal successful. New balance: {Balance}";
        }

        /// <summary>
        /// Abstract method for calculating interest, to be implemented by specific account types.
        /// </summary>
        /// <returns>The calculated interest amount</returns>
        public abstract float CalculateInterest();

        /// <summary>
        /// Retrieves the most recent transaction for the account.
        /// </summary>
        /// <returns>String representation of the last transaction or a message if no transactions exist</returns>
        public string GetLastTransaction()
        {
            return transactions.Count > 0 ? transactions[^1].ToString() : "No transactions available.";
        }

        /// <summary>
        /// Retrieves a list of all transactions made on the account.
        /// </summary>
        /// <returns>A formatted string containing all transaction records</returns>
        public string GetTransactionHistory()
        {
            if (transactions.Count == 0)
                return "No transactions available.";

            string history = "Transaction History:\n";
            foreach (var transaction in transactions)
            {
                history += transaction.ToString() + "\n";
            }
            return history;
        }
    }
}
