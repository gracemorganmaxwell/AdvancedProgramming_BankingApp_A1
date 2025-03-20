namespace BankingApp.Forms.Views.Customers
{
    partial class AddCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomerForm));
            labelFirstName = new Label();
            labelLastName = new Label();
            labelEmail = new Label();
            labelPhone = new Label();
            labelAddress = new Label();
            labelDateOfBirth = new Label();
            labelRole = new Label();
            btnSaveCustomer = new Button();
            btnCancel = new Button();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            cmbRole = new ComboBox();
            dtpDateOfBirth = new DateTimePicker();
            labelTitle = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            btnBack = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelFirstName.Location = new Point(39, 100);
            labelFirstName.Margin = new Padding(4, 0, 4, 0);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(93, 21);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "First name:";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelLastName.Location = new Point(39, 157);
            labelLastName.Margin = new Padding(4, 0, 4, 0);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(91, 21);
            labelLastName.TabIndex = 1;
            labelLastName.Text = "Last name:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelEmail.Location = new Point(485, 100);
            labelEmail.Margin = new Padding(4, 0, 4, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(57, 21);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelPhone.Location = new Point(485, 153);
            labelPhone.Margin = new Padding(4, 0, 4, 0);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(63, 21);
            labelPhone.TabIndex = 3;
            labelPhone.Text = "Phone:";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelAddress.Location = new Point(39, 216);
            labelAddress.Margin = new Padding(4, 0, 4, 0);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(74, 21);
            labelAddress.TabIndex = 4;
            labelAddress.Text = "Address:";
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelDateOfBirth.Location = new Point(39, 271);
            labelDateOfBirth.Margin = new Padding(4, 0, 4, 0);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(111, 21);
            labelDateOfBirth.TabIndex = 5;
            labelDateOfBirth.Text = "Date of birth:";
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelRole.Location = new Point(500, 271);
            labelRole.Margin = new Padding(4, 0, 4, 0);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(48, 21);
            labelRole.TabIndex = 6;
            labelRole.Text = "Role:";
            // 
            // btnSaveCustomer
            // 
            btnSaveCustomer.BackColor = Color.Honeydew;
            btnSaveCustomer.FlatStyle = FlatStyle.Popup;
            btnSaveCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveCustomer.Location = new Point(555, 368);
            btnSaveCustomer.Margin = new Padding(4, 4, 4, 4);
            btnSaveCustomer.Name = "btnSaveCustomer";
            btnSaveCustomer.Size = new Size(109, 55);
            btnSaveCustomer.TabIndex = 8;
            btnSaveCustomer.Text = "Save";
            btnSaveCustomer.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonFace;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(692, 368);
            btnCancel.Margin = new Padding(4, 4, 4, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(109, 55);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.White;
            txtFirstName.Location = new Point(137, 100);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(252, 29);
            txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(549, 100);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(252, 29);
            txtLastName.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(137, 157);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(252, 29);
            txtEmail.TabIndex = 12;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(549, 153);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(252, 29);
            txtPhone.TabIndex = 13;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(137, 216);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(664, 29);
            txtAddress.TabIndex = 14;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Customer", "Staff", "Both" });
            cmbRole.Location = new Point(555, 271);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(246, 29);
            cmbRole.TabIndex = 15;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(157, 271);
            dtpDateOfBirth.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            dtpDateOfBirth.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(293, 29);
            dtpDateOfBirth.TabIndex = 16;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(33, 17);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(260, 32);
            labelTitle.TabIndex = 17;
            labelTitle.Text = "+ Add New Customer";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dtpDateOfBirth);
            panel1.Controls.Add(btnSaveCustomer);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(labelTitle);
            panel1.Controls.Add(cmbRole);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(labelRole);
            panel1.Controls.Add(labelDateOfBirth);
            panel1.Controls.Add(labelAddress);
            panel1.Controls.Add(labelPhone);
            panel1.Controls.Add(labelEmail);
            panel1.Controls.Add(labelLastName);
            panel1.Controls.Add(labelFirstName);
            panel1.Location = new Point(53, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(869, 482);
            panel1.TabIndex = 18;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(219, 219, 217);
            panel2.Location = new Point(33, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(768, 8);
            panel2.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(219, 219, 217);
            panel3.Location = new Point(42, 340);
            panel3.Name = "panel3";
            panel3.Size = new Size(768, 8);
            panel3.TabIndex = 20;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.WhiteSmoke;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Location = new Point(53, 54);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(190, 37);
            btnBack.TabIndex = 19;
            btnBack.Text = "⬅️ Back to Main Menu";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(219, 219, 217);
            ClientSize = new Size(1001, 746);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "AddCustomerForm";
            Text = "Hawkins Bank - Add Customer Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelFirstName;
        private Label labelLastName;
        private Label labelEmail;
        private Label labelPhone;
        private Label labelAddress;
        private Label labelDateOfBirth;
        private Label labelRole;
        private Button btnSaveCustomer;
        private Button btnCancel;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private ComboBox cmbRole;
        private DateTimePicker dtpDateOfBirth;
        private Label labelTitle;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnBack;
    }
}
