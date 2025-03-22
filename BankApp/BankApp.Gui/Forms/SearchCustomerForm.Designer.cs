namespace BankApp.Gui.Forms
{
    partial class SearchCustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCustomerForm));
            panel1 = new Panel();
            BtnBackMainMenu = new Button();
            LblSearchTitle = new Label();
            BtnReset = new Button();
            BtnDeleteCustomer = new Button();
            BtnEditCustomer = new Button();
            DataGridResults = new DataGridView();
            BtnSearch = new Button();
            TxtSearchQuery = new TextBox();
            labelHomeScreenFooter = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridResults).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(BtnBackMainMenu);
            panel1.Controls.Add(LblSearchTitle);
            panel1.Controls.Add(BtnReset);
            panel1.Controls.Add(BtnDeleteCustomer);
            panel1.Controls.Add(BtnEditCustomer);
            panel1.Controls.Add(DataGridResults);
            panel1.Controls.Add(BtnSearch);
            panel1.Controls.Add(TxtSearchQuery);
            panel1.Controls.Add(labelHomeScreenFooter);
            panel1.Controls.Add(pictureBox1);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 456);
            panel1.TabIndex = 0;
            // 
            // BtnBackMainMenu
            // 
            BtnBackMainMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnBackMainMenu.Location = new Point(24, 405);
            BtnBackMainMenu.Name = "BtnBackMainMenu";
            BtnBackMainMenu.Size = new Size(181, 33);
            BtnBackMainMenu.TabIndex = 13;
            BtnBackMainMenu.Text = "Back to Main Menu";
            BtnBackMainMenu.UseVisualStyleBackColor = true;
            BtnBackMainMenu.Click += BtnBackMainMenu_Click;
            // 
            // LblSearchTitle
            // 
            LblSearchTitle.AutoSize = true;
            LblSearchTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSearchTitle.ForeColor = Color.Gray;
            LblSearchTitle.Location = new Point(12, 9);
            LblSearchTitle.Name = "LblSearchTitle";
            LblSearchTitle.Size = new Size(286, 45);
            LblSearchTitle.TabIndex = 12;
            LblSearchTitle.Text = "Search Customers";
            // 
            // BtnReset
            // 
            BtnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnReset.Location = new Point(141, 352);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(75, 33);
            BtnReset.TabIndex = 11;
            BtnReset.Text = "Reset";
            BtnReset.UseVisualStyleBackColor = true;
            BtnReset.Click += BtnReset_Click;
            // 
            // BtnDeleteCustomer
            // 
            BtnDeleteCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnDeleteCustomer.Location = new Point(263, 352);
            BtnDeleteCustomer.Name = "BtnDeleteCustomer";
            BtnDeleteCustomer.Size = new Size(75, 33);
            BtnDeleteCustomer.TabIndex = 10;
            BtnDeleteCustomer.Text = "Delete";
            BtnDeleteCustomer.UseVisualStyleBackColor = true;
            BtnDeleteCustomer.Click += BtnDeleteCustomer_Click;
            // 
            // BtnEditCustomer
            // 
            BtnEditCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnEditCustomer.Location = new Point(24, 352);
            BtnEditCustomer.Name = "BtnEditCustomer";
            BtnEditCustomer.Size = new Size(75, 33);
            BtnEditCustomer.TabIndex = 9;
            BtnEditCustomer.Text = "Edit";
            BtnEditCustomer.UseVisualStyleBackColor = true;
            BtnEditCustomer.Click += BtnEditCustomer_Click;
            // 
            // DataGridResults
            // 
            DataGridResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridResults.Location = new Point(24, 104);
            DataGridResults.Name = "DataGridResults";
            DataGridResults.Size = new Size(592, 232);
            DataGridResults.TabIndex = 8;
            // 
            // BtnSearch
            // 
            BtnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnSearch.Location = new Point(293, 56);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(75, 33);
            BtnSearch.TabIndex = 7;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // TxtSearchQuery
            // 
            TxtSearchQuery.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TxtSearchQuery.Location = new Point(24, 60);
            TxtSearchQuery.Name = "TxtSearchQuery";
            TxtSearchQuery.PlaceholderText = "Enter name...";
            TxtSearchQuery.Size = new Size(263, 29);
            TxtSearchQuery.TabIndex = 6;
            // 
            // labelHomeScreenFooter
            // 
            labelHomeScreenFooter.AutoSize = true;
            labelHomeScreenFooter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHomeScreenFooter.Location = new Point(609, 433);
            labelHomeScreenFooter.Name = "labelHomeScreenFooter";
            labelHomeScreenFooter.Size = new Size(143, 15);
            labelHomeScreenFooter.TabIndex = 5;
            labelHomeScreenFooter.Text = "Hawkins Bank NZ (2025)";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.banklogo;
            pictureBox1.Location = new Point(633, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(368, 433);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // SearchCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SearchCustomerForm";
            Text = "Hawkins Bank - Search Customer Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridResults).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label labelHomeScreenFooter;
        private DataGridView DataGridResults;
        private Button BtnSearch;
        private TextBox TxtSearchQuery;
        private Button BtnEditCustomer;
        private Button BtnReset;
        private Button BtnDeleteCustomer;
        private Label LblSearchTitle;
        private Button BtnBackMainMenu;
    }
}