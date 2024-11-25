using BankingApp.Lib;
using Microsoft.VisualBasic.ApplicationServices;
using User = BankingApp.Lib.User;
using Transaction = BankingApp.Lib.Transaction;
using EverydayAccount = BankingApp.Lib.EverydayAccount;
using InvestmentAccount = BankingApp.Lib.InvestmentAccount;
using OmniAccount = BankingApp.Lib.OmniAccount;

namespace BankingApp.Gui;

public partial class Form1 : Form
{
    private User user;
    private EverydayAccount everydayAccount;
    private InvestmentAccount investmentAccount;
    private OmniAccount omniAccount;

    public Form1()
    {
        InitializeComponent();

        // Initialize user and accounts
        user = new User("John", "Doe", DateTime.Parse("1990-01-01"), new ContactDetails("123 Main St", "johndoe@example.com", "555-1234"), "BOTH");
        everydayAccount = new EverydayAccount();
        investmentAccount = new InvestmentAccount(0.05f, 10.0f);
        omniAccount = new OmniAccount(0.04f, 500, 10.0f);

        // Populate ComboBox
        AccountTypeComboBox.Items.Add("Everyday Account");
        AccountTypeComboBox.Items.Add("Investment Account");
        AccountTypeComboBox.Items.Add("Omni Account");
    }

    private void BtnAccountInfo_Click(object sender, EventArgs e)
    {
        switch (AccountTypeComboBox.SelectedItem.ToString())
        {
            case "Everyday Account":
                AccountBalanceTextBox.Text = everydayAccount.Balance.ToString("C");
                break;
            case "Investment Account":
                AccountBalanceTextBox.Text = investmentAccount.Balance.ToString("C");
                break;
            case "Omni Account":
                AccountBalanceTextBox.Text = omniAccount.Balance.ToString("C");
                break;
            default:
                MessageBox.Show("Please select an account type.");
                break;
        }
    }

    private void BtnDeposit_Click(object sender, EventArgs e)
    {
        if (!float.TryParse(TextboxAmount.Text, out float amount) || amount <= 0)
        {
            MessageBox.Show("Please enter a valid amount.");
            return;
        }

        switch (AccountTypeComboBox.SelectedItem.ToString())
        {
            case "Everyday Account":
                everydayAccount.Deposit(amount);
                AccountBalanceTextBox.Text = everydayAccount.Balance.ToString("C");
                ListboxLastTransactions.Items.Add("Deposit: " + amount.ToString("C"));
                break;
            case "Investment Account":
                investmentAccount.Deposit(amount);
                AccountBalanceTextBox.Text = investmentAccount.Balance.ToString("C");
                ListboxLastTransactions.Items.Add("Deposit: " + amount.ToString("C"));
                break;
            case "Omni Account":
                omniAccount.Deposit(amount);
                AccountBalanceTextBox.Text = omniAccount.Balance.ToString("C");
                ListboxLastTransactions.Items.Add("Deposit: " + amount.ToString("C"));
                break;
        }
    }

    private void btnWithdraw_Click(object sender, EventArgs e)
    {
        if (!float.TryParse(AccountBalanceTextBox.Text, out float amount) || amount <= 0)
        {
            MessageBox.Show("Please enter a valid amount.");
            return;
        }

        string result;
        switch (AccountTypeComboBox.SelectedItem.ToString())
        {
            case "Everyday Account":
                result = everydayAccount.Withdraw(amount, user);
                AccountBalanceTextBox.Text = everydayAccount.Balance.ToString("C");
                ListboxLastTransactions.Items.Add(result);
                break;
            case "Investment Account":
                result = investmentAccount.Withdraw(amount, user);
                AccountBalanceTextBox.Text = investmentAccount.Balance.ToString("C");
                ListboxLastTransactions.Items.Add(result);
                break;
            case "Omni Account":
                result = omniAccount.Withdraw(amount, user);
                AccountBalanceTextBox.Text = omniAccount.Balance.ToString("C");
                ListboxLastTransactions.Items.Add(result);
                break;
        }
    }

    private void BtnCalculateInterest_Click(object sender, EventArgs e)
    {
        float interest;
        switch (AccountTypeComboBox.SelectedItem.ToString())
        {
            case "Investment Account":
                interest = investmentAccount.CalculateInterest();
                AccountBalanceTextBox.Text = investmentAccount.Balance.ToString("C");
                ListboxLastTransactions.Items.Add("Interest Added: " + interest.ToString("C"));
                break;
            case "Omni Account":
                interest = omniAccount.CalculateInterest();
                AccountBalanceTextBox.Text = omniAccount.Balance.ToString("C");
                ListboxLastTransactions.Items.Add("Interest Added: " + interest.ToString("C"));
                break;
            default:
                MessageBox.Show("This account type does not accrue interest.");
                break;
        }
    }
}
