using System.Windows.Forms;

namespace BankingApp.Gui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            logo = new PictureBox();
            Tagline = new Label();
            UserNameLabel = new Label();
            AccountTypeComboBox = new ComboBox();
            AccountTypeLabel = new Label();
            label1 = new Label();
            AccountBalanceTextBox = new TextBox();
            Transactions = new Panel();
            TextboxAmount = new TextBox();
            LabelAmount = new Label();
            LabelTransactionPanel = new Label();
            BtnCalculateInterest = new Button();
            BtnWithdraw = new Button();
            BtnDeposit = new Button();
            BtnAccountInformation = new Button();
            ListboxLastTransactions = new ListBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            Transactions.SuspendLayout();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = Properties.Resources.ND;
            logo.Location = new Point(1, 3);
            logo.Name = "logo";
            logo.Size = new Size(418, 252);
            logo.SizeMode = PictureBoxSizeMode.CenterImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // Tagline
            // 
            Tagline.AutoSize = true;
            Tagline.BackColor = Color.Gold;
            Tagline.Font = new Font("Calibri Light", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Tagline.Location = new Point(99, 190);
            Tagline.Name = "Tagline";
            Tagline.Size = new Size(253, 21);
            Tagline.TabIndex = 1;
            Tagline.Text = " Because every cent counts… to us!";
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Location = new Point(463, 39);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(0, 20);
            UserNameLabel.TabIndex = 2;
            // 
            // AccountTypeComboBox
            // 
            AccountTypeComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Everyday", "Investment", "Omni" });
            AccountTypeComboBox.FormattingEnabled = true;
            AccountTypeComboBox.Location = new Point(606, 92);
            AccountTypeComboBox.Name = "AccountTypeComboBox";
            AccountTypeComboBox.Size = new Size(151, 28);
            AccountTypeComboBox.TabIndex = 3;
            // 
            // AccountTypeLabel
            // 
            AccountTypeLabel.AutoSize = true;
            AccountTypeLabel.Location = new Point(466, 95);
            AccountTypeLabel.Name = "AccountTypeLabel";
            AccountTypeLabel.Size = new Size(98, 20);
            AccountTypeLabel.TabIndex = 4;
            AccountTypeLabel.Text = "Account Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(463, 141);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 5;
            label1.Text = "Account Balance";
            // 
            // AccountBalanceTextBox
            // 
            AccountBalanceTextBox.Location = new Point(606, 138);
            AccountBalanceTextBox.Name = "AccountBalanceTextBox";
            AccountBalanceTextBox.Size = new Size(151, 27);
            AccountBalanceTextBox.TabIndex = 6;
            // 
            // Transactions
            // 
            Transactions.Controls.Add(TextboxAmount);
            Transactions.Controls.Add(LabelAmount);
            Transactions.Controls.Add(LabelTransactionPanel);
            Transactions.Controls.Add(BtnCalculateInterest);
            Transactions.Controls.Add(BtnWithdraw);
            Transactions.Controls.Add(BtnDeposit);
            Transactions.Location = new Point(463, 206);
            Transactions.Name = "Transactions";
            Transactions.Size = new Size(373, 297);
            Transactions.TabIndex = 7;
            // 
            // TextboxAmount
            // 
            TextboxAmount.Location = new Point(204, 28);
            TextboxAmount.Name = "TextboxAmount";
            TextboxAmount.Size = new Size(90, 27);
            TextboxAmount.TabIndex = 8;
            // 
            // LabelAmount
            // 
            LabelAmount.AutoSize = true;
            LabelAmount.Location = new Point(125, 31);
            LabelAmount.Name = "LabelAmount";
            LabelAmount.Size = new Size(62, 20);
            LabelAmount.TabIndex = 9;
            LabelAmount.Text = "Amount";
            // 
            // LabelTransactionPanel
            // 
            LabelTransactionPanel.AutoSize = true;
            LabelTransactionPanel.Location = new Point(3, 0);
            LabelTransactionPanel.Name = "LabelTransactionPanel";
            LabelTransactionPanel.Size = new Size(90, 20);
            LabelTransactionPanel.TabIndex = 3;
            LabelTransactionPanel.Text = "Transactions";
            // 
            // BtnCalculateInterest
            // 
            BtnCalculateInterest.Location = new Point(174, 147);
            BtnCalculateInterest.Name = "BtnCalculateInterest";
            BtnCalculateInterest.Size = new Size(144, 29);
            BtnCalculateInterest.TabIndex = 2;
            BtnCalculateInterest.Text = "Calculate Interest";
            BtnCalculateInterest.UseVisualStyleBackColor = true;
            BtnCalculateInterest.Click += BtnCalculateInterest_Click;
            // 
            // BtnWithdraw
            // 
            BtnWithdraw.Location = new Point(200, 112);
            BtnWithdraw.Name = "BtnWithdraw";
            BtnWithdraw.Size = new Size(94, 29);
            BtnWithdraw.TabIndex = 1;
            BtnWithdraw.Text = "Withdraw";
            BtnWithdraw.UseVisualStyleBackColor = true;
            BtnWithdraw.Click += btnWithdraw_Click;
            // 
            // BtnDeposit
            // 
            BtnDeposit.Location = new Point(200, 77);
            BtnDeposit.Name = "BtnDeposit";
            BtnDeposit.Size = new Size(94, 29);
            BtnDeposit.TabIndex = 0;
            BtnDeposit.Text = "Deposit";
            BtnDeposit.UseVisualStyleBackColor = true;
            BtnDeposit.Click += BtnDeposit_Click;
            // 
            // BtnAccountInformation
            // 
            BtnAccountInformation.Location = new Point(819, 91);
            BtnAccountInformation.Name = "BtnAccountInformation";
            BtnAccountInformation.Size = new Size(156, 29);
            BtnAccountInformation.TabIndex = 4;
            BtnAccountInformation.Text = "Account Information";
            BtnAccountInformation.UseVisualStyleBackColor = true;
            BtnAccountInformation.Click += BtnAccountInfo_Click;
            // 
            // ListboxLastTransactions
            // 
            ListboxLastTransactions.FormattingEnabled = true;
            ListboxLastTransactions.Location = new Point(886, 223);
            ListboxLastTransactions.Name = "ListboxLastTransactions";
            ListboxLastTransactions.Size = new Size(150, 104);
            ListboxLastTransactions.TabIndex = 8;
            ListboxLastTransactions.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1368, 508);
            Controls.Add(ListboxLastTransactions);
            Controls.Add(Transactions);
            Controls.Add(AccountBalanceTextBox);
            Controls.Add(BtnAccountInformation);
            Controls.Add(label1);
            Controls.Add(AccountTypeLabel);
            Controls.Add(AccountTypeComboBox);
            Controls.Add(UserNameLabel);
            Controls.Add(Tagline);
            Controls.Add(logo);
            Name = "Form1";
            Text = "Nickel & Dime - Banking Simplified";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            Transactions.ResumeLayout(false);
            Transactions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void CalcInterestButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox logo;
        private Label Tagline;
        private Label UserNameLabel;
        private ComboBox AccountTypeComboBox;
        private Label AccountTypeLabel;
        private Label label1;
        private TextBox AccountBalanceTextBox;
        private Panel Transactions;
        private Button BtnCalculateInterest;
        private Button BtnWithdraw;
        private Button BtnDeposit;
        private Button BtnAccountInformation;
        private Label LabelTransactionPanel;
        private TextBox TextboxAmount;
        private Label LabelAmount;
        private ListBox ListboxLastTransactions;
    }
}
