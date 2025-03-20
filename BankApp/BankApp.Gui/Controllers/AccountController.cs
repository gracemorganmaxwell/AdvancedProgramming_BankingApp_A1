namespace BankingApp.Gui.Controllers
{
    using System;
    using System.Collections.Generic;
    using BankingApp.Lib.Models;

    /// <summary>
    /// Manages account-related operations, including deposits, withdrawals, and transactions.
    /// Acts as a bridge between the Account model and the View.
    /// </summary>
    public class AccountController
    {
        /// <summary>
        /// Stores a list of all bank accounts.
        /// </summary>
        private List<Account> _accounts;

        /// <summary>
        /// Initializes a new instance of the AccountController.
        /// </summary>
        public AccountController()
        {
            _accounts = new List<Account>();
        }

        /// <summary>
        /// Creates a new bank account for a customer.
        /// </summary>
        /// <param name="accountType">Type of account to create (Everyday, Investment, Omni)</param>
        /// <param name="owner">User who owns the account</param>
        public void CreateAccount(string accountType, User owner)
        {
            Account newAccount = accountType.ToLower() switch
            {
                "everyday" => new EverydayAccount(),
                "investment" => new InvestmentAccount(interestRate: 0.05f, failedWithdrawalFee: 10f),
                "omni" => new OmniAccount(interestRate: 0.02f, overdraftLimit: 500f, failedWithdrawalFee: 15f),
                _ => throw new ArgumentException("Invalid account type specified.")
            };

            _accounts.Add(newAccount);
            Console.WriteLine($"{accountType} account created for {owner.FirstName} {owner.LastName}.");
        }

        /// <summary>
        /// Deposits a specified amount into an account.
        /// </summary>
        /// <param name="accountId">ID of the account</param>
        /// <param name="amount">Amount to deposit</param>
        public void Deposit(int accountId, float amount)
        {
            Account account = _accounts.Find(a => a.AccountId == accountId);
            if (account != null)
            {
                account.Deposit(amount);
                Console.WriteLine($"Deposited {amount} into Account {accountId}. New Balance: {account.Balance}");
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        /// <summary>
        /// Handles withdrawal operations, applying penalties if necessary.
        /// </summary>
        /// <param name="accountId">ID of the account</param>
        /// <param name="amount">Amount to withdraw</param>
        /// <param name="user">User making the withdrawal</param>
        public void Withdraw(int accountId, float amount, User user)
        {
            Account account = _accounts.Find(a => a.AccountId == accountId);
            if (account != null)
            {
                string result = account.Withdraw(amount, user);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        /// <summary>
        /// Retrieves and displays the transaction history of an account.
        /// </summary>
        /// <param name="accountId">ID of the account</param>
        public void DisplayTransactionHistory(int accountId)
        {
            Account account = _accounts.Find(a => a.AccountId == accountId);
            if (account != null)
            {
                foreach (var transaction in account.GetTransactionHistory())
                {
                    Console.WriteLine(transaction.ToString());
                }
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }
    }
}