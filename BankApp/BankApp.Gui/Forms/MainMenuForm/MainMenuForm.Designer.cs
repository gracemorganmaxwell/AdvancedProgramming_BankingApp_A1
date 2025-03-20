namespace MainMenuForm
{
    partial class FormHomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomeScreen));
            labelHomeMenuTitle = new Label();
            btnAddCustomer = new Button();
            btnSearchCustomer = new Button();
            pictureLogo = new PictureBox();
            labelHomeMenuBankName = new Label();
            panelHomeScreen = new Panel();
            labelHomeScreenFooter = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            panelHomeScreen.SuspendLayout();
            SuspendLayout();
            // 
            // labelHomeMenuTitle
            // 
            labelHomeMenuTitle.AutoSize = true;
            labelHomeMenuTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHomeMenuTitle.Location = new Point(22, 31);
            labelHomeMenuTitle.Name = "labelHomeMenuTitle";
            labelHomeMenuTitle.Size = new Size(513, 47);
            labelHomeMenuTitle.TabIndex = 0;
            labelHomeMenuTitle.Text = "Customer Management Menu";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.Honeydew;
            btnAddCustomer.FlatStyle = FlatStyle.Popup;
            btnAddCustomer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCustomer.Location = new Point(22, 121);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(220, 39);
            btnAddCustomer.TabIndex = 1;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = false;
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.BackColor = Color.Honeydew;
            btnSearchCustomer.FlatStyle = FlatStyle.Popup;
            btnSearchCustomer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchCustomer.Location = new Point(315, 121);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(220, 39);
            btnSearchCustomer.TabIndex = 2;
            btnSearchCustomer.Text = "Search Customer";
            btnSearchCustomer.UseVisualStyleBackColor = false;
            // 
            // pictureLogo
            // 
            pictureLogo.AccessibleDescription = "Hawkins Bank Logo: green icon";
            pictureLogo.BackgroundImageLayout = ImageLayout.Center;
            pictureLogo.Image = Properties.Resources.banklogo;
            pictureLogo.Location = new Point(415, 24);
            pictureLogo.MaximumSize = new Size(100, 100);
            pictureLogo.MinimumSize = new Size(150, 150);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(150, 150);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 3;
            pictureLogo.TabStop = false;
            // 
            // labelHomeMenuBankName
            // 
            labelHomeMenuBankName.AutoSize = true;
            labelHomeMenuBankName.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHomeMenuBankName.Location = new Point(372, 166);
            labelHomeMenuBankName.Name = "labelHomeMenuBankName";
            labelHomeMenuBankName.Size = new Size(252, 47);
            labelHomeMenuBankName.TabIndex = 4;
            labelHomeMenuBankName.Text = "Hawkins Bank";
            // 
            // panelHomeScreen
            // 
            panelHomeScreen.BackColor = Color.White;
            panelHomeScreen.Controls.Add(btnSearchCustomer);
            panelHomeScreen.Controls.Add(btnAddCustomer);
            panelHomeScreen.Controls.Add(labelHomeMenuTitle);
            panelHomeScreen.Location = new Point(211, 285);
            panelHomeScreen.Name = "panelHomeScreen";
            panelHomeScreen.Size = new Size(560, 226);
            panelHomeScreen.TabIndex = 5;
            // 
            // labelHomeScreenFooter
            // 
            labelHomeScreenFooter.AutoSize = true;
            labelHomeScreenFooter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHomeScreenFooter.Location = new Point(12, 617);
            labelHomeScreenFooter.Name = "labelHomeScreenFooter";
            labelHomeScreenFooter.Size = new Size(146, 15);
            labelHomeScreenFooter.TabIndex = 6;
            labelHomeScreenFooter.Text = "Hawkins Bank NZ (2025) ";
            // 
            // FormHomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(219, 219, 217);
            ClientSize = new Size(1006, 640);
            Controls.Add(labelHomeScreenFooter);
            Controls.Add(panelHomeScreen);
            Controls.Add(labelHomeMenuBankName);
            Controls.Add(pictureLogo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormHomeScreen";
            Text = "Customer Management Menu";
            Load += FormHomeScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            panelHomeScreen.ResumeLayout(false);
            panelHomeScreen.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHomeMenuTitle;
        private Button btnAddCustomer;
        private Button btnSearchCustomer;
        private PictureBox pictureLogo;
        private Label labelHomeMenuBankName;
        private Panel panelHomeScreen;
        private Label labelHomeScreenFooter;
    }
}
