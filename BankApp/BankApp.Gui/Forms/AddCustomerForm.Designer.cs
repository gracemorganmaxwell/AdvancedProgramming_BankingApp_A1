namespace BankApp.Gui.Forms
{
    partial class AddCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomerForm));
            panel1 = new Panel();
            LabelFullName = new Label();
            LabelEmail = new Label();
            LabelPhoneNumber = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(LabelPhoneNumber);
            panel1.Controls.Add(LabelEmail);
            panel1.Controls.Add(LabelFullName);
            panel1.Location = new Point(110, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 379);
            panel1.TabIndex = 0;
            // 
            // LabelFullName
            // 
            LabelFullName.AutoSize = true;
            LabelFullName.Location = new Point(18, 20);
            LabelFullName.Name = "LabelFullName";
            LabelFullName.Size = new Size(64, 15);
            LabelFullName.TabIndex = 0;
            LabelFullName.Text = "Full Name:";
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Location = new Point(18, 58);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(39, 15);
            LabelEmail.TabIndex = 1;
            LabelEmail.Text = "Email:";
            // 
            // LabelPhoneNumber
            // 
            LabelPhoneNumber.AutoSize = true;
            LabelPhoneNumber.Location = new Point(19, 95);
            LabelPhoneNumber.Name = "LabelPhoneNumber";
            LabelPhoneNumber.Size = new Size(44, 15);
            LabelPhoneNumber.TabIndex = 2;
            LabelPhoneNumber.Text = "Phone:";
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hawkins Bank - Add New Customer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LabelEmail;
        private Label LabelFullName;
        private Label LabelPhoneNumber;
    }
}