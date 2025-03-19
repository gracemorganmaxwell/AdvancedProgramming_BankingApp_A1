namespace BankingApp.Lib
{
    using System;

    /// <summary>
    /// Represents a financial transaction within the banking system.
    /// Transactions include deposits, withdrawals, interest additions, and penalty fees.
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Unique identifier for each transaction.
        /// </summary>
        public int TransactionId { get; private set; }

        /// <summary>
        /// The type of transaction (e.g., "Deposit", "Withdrawal", "Interest Added").
        /// </summary>
        public string TransactionType { get; private set; }

        /// <summary>
        /// The monetary amount involved in the transaction.
        /// </summary>
        public float Amount { get; private set; }

        /// <summary>
        /// The timestamp when the transaction was executed.
        /// </summary>
        public DateTime Timestamp { get; private set; }

        /// <summary>
        /// The account balance after the transaction has been processed.
        /// </summary>
        public float BalanceAfterTransaction { get; private set; }

        /// <summary>
        /// Static counter to generate unique transaction IDs.
        /// </summary>
        private static int transactionCount = 0;

        /// <summary>
        /// Initializes a new instance of the Transaction class.
        /// Automatically assigns a unique transaction ID and records the transaction time.
        /// </summary>
        /// <param name="transactionType">Type of the transaction (e.g., Deposit, Withdrawal)</param>
        /// <param name="amount">Amount of money involved in the transaction</param>
        /// <param name="balanceAfterTransaction">The resulting balance after the transaction is completed</param>
        public Transaction(string transactionType, float amount, float balanceAfterTransaction)
        {
            TransactionId = ++transactionCount;
            TransactionType = transactionType;
            Amount = amount;
            BalanceAfterTransaction = balanceAfterTransaction;
            Timestamp = DateTime.Now;
        }

        /// <summary>
        /// Returns a string representation of the transaction details.
        /// </summary>
        /// <returns>A formatted string displaying the transaction details.</returns>
        public override string ToString()
        {
            return $"{TransactionType}: {Amount} on {Timestamp}, Balance after: {BalanceAfterTransaction}";
        }
    }
}
