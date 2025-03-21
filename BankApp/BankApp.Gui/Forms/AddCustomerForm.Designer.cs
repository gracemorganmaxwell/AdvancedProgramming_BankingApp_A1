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
            BtnCancel = new Button();
            BtnSubmit = new Button();
            CmbRole = new ComboBox();
            TxtAddress = new TextBox();
            TxtPhone = new TextBox();
            DtpDateOfBirth = new DateTimePicker();
            TxtEmail = new TextBox();
            TxtLastName = new TextBox();
            TxtFirstName = new TextBox();
            LabelTitle = new Label();
            Logo = new PictureBox();
            LabelFirstName = new Label();
            LabelLastName = new Label();
            LabelDOB = new Label();
            LabelEmail = new Label();
            LabelPhone = new Label();
            LabelAddress = new Label();
            LabelRole = new Label();
            LabelFormMessage = new Label();
            LabelFooter = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(LabelFormMessage);
            panel1.Controls.Add(LabelRole);
            panel1.Controls.Add(LabelTitle);
            panel1.Controls.Add(LabelAddress);
            panel1.Controls.Add(LabelPhone);
            panel1.Controls.Add(LabelEmail);
            panel1.Controls.Add(LabelDOB);
            panel1.Controls.Add(LabelLastName);
            panel1.Controls.Add(LabelFirstName);
            panel1.Controls.Add(BtnCancel);
            panel1.Controls.Add(BtnSubmit);
            panel1.Controls.Add(CmbRole);
            panel1.Controls.Add(TxtAddress);
            panel1.Controls.Add(TxtPhone);
            panel1.Controls.Add(DtpDateOfBirth);
            panel1.Controls.Add(TxtEmail);
            panel1.Controls.Add(TxtLastName);
            panel1.Controls.Add(TxtFirstName);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(351, 446);
            panel1.TabIndex = 0;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.LightGray;
            BtnCancel.FlatStyle = FlatStyle.Popup;
            BtnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancel.Location = new Point(200, 389);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 37);
            BtnCancel.TabIndex = 8;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnSubmit
            // 
            BtnSubmit.BackColor = Color.LightGreen;
            BtnSubmit.FlatStyle = FlatStyle.Popup;
            BtnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSubmit.Location = new Point(97, 389);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(87, 37);
            BtnSubmit.TabIndex = 7;
            BtnSubmit.Text = "Submit";
            BtnSubmit.UseVisualStyleBackColor = false;
            BtnSubmit.Click += BtnSubmit_Click;
            // 
            // CmbRole
            // 
            CmbRole.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CmbRole.FormattingEnabled = true;
            CmbRole.Items.AddRange(new object[] { "Customer", "Staff", "Both" });
            CmbRole.Location = new Point(85, 337);
            CmbRole.Name = "CmbRole";
            CmbRole.Size = new Size(219, 29);
            CmbRole.TabIndex = 6;
            // 
            // TxtAddress
            // 
            TxtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TxtAddress.Location = new Point(85, 292);
            TxtAddress.Name = "TxtAddress";
            TxtAddress.PlaceholderText = "Address";
            TxtAddress.Size = new Size(220, 29);
            TxtAddress.TabIndex = 5;
            // 
            // TxtPhone
            // 
            TxtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TxtPhone.Location = new Point(85, 251);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.PlaceholderText = "Phone";
            TxtPhone.Size = new Size(220, 29);
            TxtPhone.TabIndex = 4;
            // 
            // DtpDateOfBirth
            // 
            DtpDateOfBirth.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            DtpDateOfBirth.Location = new Point(85, 165);
            DtpDateOfBirth.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            DtpDateOfBirth.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            DtpDateOfBirth.Name = "DtpDateOfBirth";
            DtpDateOfBirth.Size = new Size(219, 29);
            DtpDateOfBirth.TabIndex = 3;
            // 
            // TxtEmail
            // 
            TxtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TxtEmail.Location = new Point(86, 208);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.PlaceholderText = "Email";
            TxtEmail.Size = new Size(219, 29);
            TxtEmail.TabIndex = 2;
            // 
            // TxtLastName
            // 
            TxtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TxtLastName.Location = new Point(86, 122);
            TxtLastName.Name = "TxtLastName";
            TxtLastName.PlaceholderText = "Last Name";
            TxtLastName.Size = new Size(218, 29);
            TxtLastName.TabIndex = 1;
            // 
            // TxtFirstName
            // 
            TxtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TxtFirstName.Location = new Point(85, 81);
            TxtFirstName.Name = "TxtFirstName";
            TxtFirstName.PlaceholderText = "First Name";
            TxtFirstName.Size = new Size(219, 29);
            TxtFirstName.TabIndex = 0;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelTitle.ForeColor = Color.DimGray;
            LabelTitle.Location = new Point(16, 8);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(313, 45);
            LabelTitle.TabIndex = 1;
            LabelTitle.Text = "Add New Customer";
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.banklogo;
            Logo.Location = new Point(356, 1);
            Logo.Name = "Logo";
            Logo.Size = new Size(143, 151);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 2;
            Logo.TabStop = false;
            // 
            // LabelFirstName
            // 
            LabelFirstName.AutoSize = true;
            LabelFirstName.Location = new Point(14, 81);
            LabelFirstName.Name = "LabelFirstName";
            LabelFirstName.Size = new Size(65, 15);
            LabelFirstName.TabIndex = 9;
            LabelFirstName.Text = "First name:";
            // 
            // LabelLastName
            // 
            LabelLastName.AutoSize = true;
            LabelLastName.Location = new Point(15, 122);
            LabelLastName.Name = "LabelLastName";
            LabelLastName.Size = new Size(64, 15);
            LabelLastName.TabIndex = 10;
            LabelLastName.Text = "Last name:";
            // 
            // LabelDOB
            // 
            LabelDOB.AutoSize = true;
            LabelDOB.Location = new Point(15, 165);
            LabelDOB.Name = "LabelDOB";
            LabelDOB.Size = new Size(40, 15);
            LabelDOB.TabIndex = 11;
            LabelDOB.Text = "D.O.B:";
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Location = new Point(16, 208);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(39, 15);
            LabelEmail.TabIndex = 12;
            LabelEmail.Text = "Email:";
            // 
            // LabelPhone
            // 
            LabelPhone.AutoSize = true;
            LabelPhone.Location = new Point(18, 251);
            LabelPhone.Name = "LabelPhone";
            LabelPhone.Size = new Size(44, 15);
            LabelPhone.TabIndex = 13;
            LabelPhone.Text = "Phone:";
            // 
            // LabelAddress
            // 
            LabelAddress.AutoSize = true;
            LabelAddress.Location = new Point(18, 292);
            LabelAddress.Name = "LabelAddress";
            LabelAddress.Size = new Size(59, 15);
            LabelAddress.TabIndex = 14;
            LabelAddress.Text = "Adddress:";
            // 
            // LabelRole
            // 
            LabelRole.AutoSize = true;
            LabelRole.Location = new Point(18, 337);
            LabelRole.Name = "LabelRole";
            LabelRole.Size = new Size(33, 15);
            LabelRole.TabIndex = 15;
            LabelRole.Text = "Role:";
            // 
            // LabelFormMessage
            // 
            LabelFormMessage.AutoSize = true;
            LabelFormMessage.Location = new Point(183, 53);
            LabelFormMessage.Name = "LabelFormMessage";
            LabelFormMessage.Size = new Size(121, 15);
            LabelFormMessage.TabIndex = 16;
            LabelFormMessage.Text = "All fields are required.";
            // 
            // LabelFooter
            // 
            LabelFooter.AutoSize = true;
            LabelFooter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelFooter.Location = new Point(356, 432);
            LabelFooter.Name = "LabelFooter";
            LabelFooter.Size = new Size(143, 15);
            LabelFooter.TabIndex = 3;
            LabelFooter.Text = "Hawkins Bank NZ (2025)";
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(498, 450);
            Controls.Add(LabelFooter);
            Controls.Add(Logo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hawkins Bank - Add New Customer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox TxtFirstName;
        private TextBox TxtPhone;
        private DateTimePicker DtpDateOfBirth;
        private TextBox TxtEmail;
        private TextBox TxtLastName;
        private Button BtnSubmit;
        private ComboBox CmbRole;
        private TextBox TxtAddress;
        private Button BtnCancel;
        private Label LabelTitle;
        private PictureBox Logo;
        private Label LabelPhone;
        private Label LabelEmail;
        private Label LabelDOB;
        private Label LabelLastName;
        private Label LabelFirstName;
        private Label LabelFormMessage;
        private Label LabelRole;
        private Label LabelAddress;
        private Label LabelFooter;
    }
}