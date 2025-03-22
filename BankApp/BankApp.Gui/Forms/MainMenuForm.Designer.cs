namespace BankApp.Gui.Forms
{
    partial class MainMenuForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            pictureLogo = new PictureBox();
            labelHomeMenuTitle = new Label();
            BtnAddCustomer = new Button();
            BtnSearchCustomer = new Button();
            labelHomeScreenFooter = new Label();
            panelHomeScreen = new Panel();
            BtnImportCustomers = new Button();
            BtnExportCustomers = new Button();
            LabelTimeDate = new Label();
            DateTimeTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            panelHomeScreen.SuspendLayout();
            SuspendLayout();
            // 
            // pictureLogo
            // 
            pictureLogo.Image = Properties.Resources.banklogo;
            pictureLogo.Location = new Point(548, 0);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(120, 120);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 0;
            pictureLogo.TabStop = false;
            // 
            // labelHomeMenuTitle
            // 
            labelHomeMenuTitle.AutoSize = true;
            labelHomeMenuTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHomeMenuTitle.ForeColor = Color.DimGray;
            labelHomeMenuTitle.Location = new Point(10, 10);
            labelHomeMenuTitle.Name = "labelHomeMenuTitle";
            labelHomeMenuTitle.Size = new Size(513, 47);
            labelHomeMenuTitle.TabIndex = 1;
            labelHomeMenuTitle.Text = "Customer Management Menu";
            // 
            // BtnAddCustomer
            // 
            BtnAddCustomer.BackColor = Color.Honeydew;
            BtnAddCustomer.FlatStyle = FlatStyle.Popup;
            BtnAddCustomer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAddCustomer.Location = new Point(10, 83);
            BtnAddCustomer.Name = "BtnAddCustomer";
            BtnAddCustomer.Size = new Size(184, 40);
            BtnAddCustomer.TabIndex = 2;
            BtnAddCustomer.Text = "Add Customer";
            BtnAddCustomer.UseVisualStyleBackColor = false;
            BtnAddCustomer.Click += BtnAddCustomer_Click;
            // 
            // BtnSearchCustomer
            // 
            BtnSearchCustomer.BackColor = Color.Honeydew;
            BtnSearchCustomer.FlatStyle = FlatStyle.Popup;
            BtnSearchCustomer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSearchCustomer.Location = new Point(10, 129);
            BtnSearchCustomer.Name = "BtnSearchCustomer";
            BtnSearchCustomer.Size = new Size(184, 40);
            BtnSearchCustomer.TabIndex = 3;
            BtnSearchCustomer.Text = "Search Customer";
            BtnSearchCustomer.UseVisualStyleBackColor = false;
            BtnSearchCustomer.Click += BtnSearchCustomer_Click;
            // 
            // labelHomeScreenFooter
            // 
            labelHomeScreenFooter.AutoSize = true;
            labelHomeScreenFooter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHomeScreenFooter.Location = new Point(525, 231);
            labelHomeScreenFooter.Name = "labelHomeScreenFooter";
            labelHomeScreenFooter.Size = new Size(143, 15);
            labelHomeScreenFooter.TabIndex = 4;
            labelHomeScreenFooter.Text = "Hawkins Bank NZ (2025)";
            // 
            // panelHomeScreen
            // 
            panelHomeScreen.BackColor = Color.White;
            panelHomeScreen.Controls.Add(BtnImportCustomers);
            panelHomeScreen.Controls.Add(BtnExportCustomers);
            panelHomeScreen.Controls.Add(LabelTimeDate);
            panelHomeScreen.Controls.Add(BtnAddCustomer);
            panelHomeScreen.Controls.Add(labelHomeScreenFooter);
            panelHomeScreen.Controls.Add(BtnSearchCustomer);
            panelHomeScreen.Controls.Add(pictureLogo);
            panelHomeScreen.Controls.Add(labelHomeMenuTitle);
            panelHomeScreen.Location = new Point(2, -1);
            panelHomeScreen.Name = "panelHomeScreen";
            panelHomeScreen.Size = new Size(668, 251);
            panelHomeScreen.TabIndex = 5;
            // 
            // BtnImportCustomers
            // 
            BtnImportCustomers.BackColor = Color.Honeydew;
            BtnImportCustomers.FlatStyle = FlatStyle.Popup;
            BtnImportCustomers.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnImportCustomers.Location = new Point(205, 83);
            BtnImportCustomers.Name = "BtnImportCustomers";
            BtnImportCustomers.Size = new Size(184, 40);
            BtnImportCustomers.TabIndex = 8;
            BtnImportCustomers.Text = "Import Customers";
            BtnImportCustomers.UseVisualStyleBackColor = false;
            BtnImportCustomers.Click += BtnImportCustomers_Click;
            // 
            // BtnExportCustomers
            // 
            BtnExportCustomers.BackColor = Color.Honeydew;
            BtnExportCustomers.FlatStyle = FlatStyle.Popup;
            BtnExportCustomers.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExportCustomers.Location = new Point(205, 129);
            BtnExportCustomers.Name = "BtnExportCustomers";
            BtnExportCustomers.Size = new Size(184, 40);
            BtnExportCustomers.TabIndex = 7;
            BtnExportCustomers.Text = "Export Customers";
            BtnExportCustomers.UseVisualStyleBackColor = false;
            BtnExportCustomers.Click += BtnExportCustomers_Click;
            // 
            // LabelTimeDate
            // 
            LabelTimeDate.AutoSize = true;
            LabelTimeDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelTimeDate.Location = new Point(10, 226);
            LabelTimeDate.Name = "LabelTimeDate";
            LabelTimeDate.Size = new Size(0, 20);
            LabelTimeDate.TabIndex = 5;
            // 
            // DateTimeTimer
            // 
            DateTimeTimer.Enabled = true;
            DateTimeTimer.Interval = 1000;
            DateTimeTimer.Tick += DateTimeTimer_Tick;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(682, 254);
            Controls.Add(panelHomeScreen);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenuForm";
            Text = "Hawkins Bank - Customer Management Menu";
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            panelHomeScreen.ResumeLayout(false);
            panelHomeScreen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureLogo;
        private Label labelHomeMenuTitle;
        private Button BtnAddCustomer;
        private Button BtnSearchCustomer;
        private Label labelHomeScreenFooter;
        private Panel panelHomeScreen;
        private Label LabelTimeDate;
        private System.Windows.Forms.Timer DateTimeTimer;
        private Button BtnImportCustomers;
        private Button BtnExportCustomers;
    }
}