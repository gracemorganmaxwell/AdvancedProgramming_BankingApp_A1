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
            Logo = new PictureBox();
            pnlStaffFields = new Panel();
            ComboBoxPosition = new ComboBox();
            ComboBoxDepartments = new ComboBox();
            LabelPosition = new Label();
            LabelDepartment = new Label();
            LabelFooter = new Label();
            LabelFormMessage = new Label();
            LabelRole = new Label();
            LabelTitle = new Label();
            LabelAddress = new Label();
            LabelPhone = new Label();
            LabelEmail = new Label();
            LabelDOB = new Label();
            LabelLastName = new Label();
            LabelFirstName = new Label();
            BtnCancel = new Button();
            BtnSubmit = new Button();
            CmbRole = new ComboBox();
            TxtAddress = new TextBox();
            TxtPhone = new TextBox();
            DtpDateOfBirth = new DateTimePicker();
            TxtEmail = new TextBox();
            TxtLastName = new TextBox();
            TxtFirstName = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            pnlStaffFields.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(DtpDateOfBirth);
            panel1.Controls.Add(Logo);
            panel1.Controls.Add(pnlStaffFields);
            panel1.Controls.Add(LabelFooter);
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
            panel1.Controls.Add(TxtEmail);
            panel1.Controls.Add(TxtLastName);
            panel1.Controls.Add(TxtFirstName);
            panel1.Font = new Font("Segoe UI", 12F);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 446);
            panel1.TabIndex = 0;
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.banklogo;
            Logo.Location = new Point(515, 3);
            Logo.Name = "Logo";
            Logo.Size = new Size(143, 151);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 2;
            Logo.TabStop = false;
            // 
            // pnlStaffFields
            // 
            pnlStaffFields.Controls.Add(ComboBoxPosition);
            pnlStaffFields.Controls.Add(ComboBoxDepartments);
            pnlStaffFields.Controls.Add(LabelPosition);
            pnlStaffFields.Controls.Add(LabelDepartment);
            pnlStaffFields.Location = new Point(356, 208);
            pnlStaffFields.Name = "pnlStaffFields";
            pnlStaffFields.Size = new Size(308, 218);
            pnlStaffFields.TabIndex = 17;
            // 
            // ComboBoxPosition
            // 
            ComboBoxPosition.FormattingEnabled = true;
            ComboBoxPosition.Items.AddRange(new object[] { "Teller", "Customer Service Representative", "Branch Manager", "Assistant Branch Manager", "Loan Officer", "Mortgage Advisor", "Business Banker", "Financial Advisor", "Investment Consultant", "Risk Analyst", "Compliance Officer", "Internal Auditor", "IT Support Specialist", "Cybersecurity Analyst", "Software Developer", "Treasury Analyst", "FX Trader", "Accountant", "Finance Analyst", "HR Coordinator", "Recruitment Officer", "Marketing Coordinator", "Fraud Investigator", "Operations Assistant", "Product Manager", "Data Analyst" });
            ComboBoxPosition.Location = new Point(3, 25);
            ComboBoxPosition.Name = "ComboBoxPosition";
            ComboBoxPosition.Size = new Size(291, 29);
            ComboBoxPosition.TabIndex = 3;
            // 
            // ComboBoxDepartments
            // 
            ComboBoxDepartments.FormattingEnabled = true;
            ComboBoxDepartments.Items.AddRange(new object[] { "Retail Banking", "Business Banking", "Loans & Mortgages", "Customer Service", "Wealth Management", "Risk & Compliance", "IT & Digital Banking", "Finance & Accountin", "Operations", "Human Resources", "Marketing", "Fraud Prevention & Security", "Audit & Internal Controls", "Foreign Exchange (FX)", "Treasury" });
            ComboBoxDepartments.Location = new Point(0, 95);
            ComboBoxDepartments.Name = "ComboBoxDepartments";
            ComboBoxDepartments.Size = new Size(294, 29);
            ComboBoxDepartments.TabIndex = 2;
            // 
            // LabelPosition
            // 
            LabelPosition.AutoSize = true;
            LabelPosition.Location = new Point(0, 1);
            LabelPosition.Name = "LabelPosition";
            LabelPosition.Size = new Size(68, 21);
            LabelPosition.TabIndex = 1;
            LabelPosition.Text = "Position:";
            // 
            // LabelDepartment
            // 
            LabelDepartment.AutoSize = true;
            LabelDepartment.Location = new Point(3, 71);
            LabelDepartment.Name = "LabelDepartment";
            LabelDepartment.Size = new Size(96, 21);
            LabelDepartment.TabIndex = 0;
            LabelDepartment.Text = "Department:";
            // 
            // LabelFooter
            // 
            LabelFooter.AutoSize = true;
            LabelFooter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelFooter.Location = new Point(515, 429);
            LabelFooter.Name = "LabelFooter";
            LabelFooter.Size = new Size(143, 15);
            LabelFooter.TabIndex = 3;
            LabelFooter.Text = "Hawkins Bank NZ (2025)";
            // 
            // LabelFormMessage
            // 
            LabelFormMessage.AutoSize = true;
            LabelFormMessage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelFormMessage.Location = new Point(207, 61);
            LabelFormMessage.Name = "LabelFormMessage";
            LabelFormMessage.Size = new Size(137, 17);
            LabelFormMessage.TabIndex = 16;
            LabelFormMessage.Text = "All fields are required.";
            // 
            // LabelRole
            // 
            LabelRole.AutoSize = true;
            LabelRole.Font = new Font("Segoe UI", 12F);
            LabelRole.Location = new Point(73, 334);
            LabelRole.Name = "LabelRole";
            LabelRole.Size = new Size(44, 21);
            LabelRole.TabIndex = 15;
            LabelRole.Text = "Role:";
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
            // LabelAddress
            // 
            LabelAddress.AutoSize = true;
            LabelAddress.Font = new Font("Segoe UI", 12F);
            LabelAddress.Location = new Point(41, 292);
            LabelAddress.Name = "LabelAddress";
            LabelAddress.Size = new Size(78, 21);
            LabelAddress.TabIndex = 14;
            LabelAddress.Text = "Adddress:";
            // 
            // LabelPhone
            // 
            LabelPhone.AutoSize = true;
            LabelPhone.Font = new Font("Segoe UI", 12F);
            LabelPhone.Location = new Point(62, 251);
            LabelPhone.Name = "LabelPhone";
            LabelPhone.Size = new Size(57, 21);
            LabelPhone.TabIndex = 13;
            LabelPhone.Text = "Phone:";
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Font = new Font("Segoe UI", 12F);
            LabelEmail.Location = new Point(66, 208);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(51, 21);
            LabelEmail.TabIndex = 12;
            LabelEmail.Text = "Email:";
            // 
            // LabelDOB
            // 
            LabelDOB.AutoSize = true;
            LabelDOB.Font = new Font("Segoe UI", 12F);
            LabelDOB.Location = new Point(68, 165);
            LabelDOB.Name = "LabelDOB";
            LabelDOB.Size = new Size(51, 21);
            LabelDOB.TabIndex = 11;
            LabelDOB.Text = "D.O.B:";
            // 
            // LabelLastName
            // 
            LabelLastName.AutoSize = true;
            LabelLastName.Font = new Font("Segoe UI", 12F);
            LabelLastName.Location = new Point(33, 125);
            LabelLastName.Name = "LabelLastName";
            LabelLastName.Size = new Size(84, 21);
            LabelLastName.TabIndex = 10;
            LabelLastName.Text = "Last name:";
            // 
            // LabelFirstName
            // 
            LabelFirstName.AutoSize = true;
            LabelFirstName.Font = new Font("Segoe UI", 12F);
            LabelFirstName.Location = new Point(33, 81);
            LabelFirstName.Name = "LabelFirstName";
            LabelFirstName.Size = new Size(86, 21);
            LabelFirstName.TabIndex = 9;
            LabelFirstName.Text = "First name:";
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.LightGray;
            BtnCancel.FlatStyle = FlatStyle.Popup;
            BtnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancel.Location = new Point(249, 389);
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
            BtnSubmit.Location = new Point(124, 389);
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
            CmbRole.Location = new Point(126, 334);
            CmbRole.Name = "CmbRole";
            CmbRole.Size = new Size(219, 29);
            CmbRole.TabIndex = 6;
            CmbRole.SelectedIndexChanged += CmbRole_SelectedIndexChanged;
            // 
            // TxtAddress
            // 
            TxtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TxtAddress.Location = new Point(125, 292);
            TxtAddress.Name = "TxtAddress";
            TxtAddress.PlaceholderText = "Address";
            TxtAddress.Size = new Size(220, 29);
            TxtAddress.TabIndex = 5;
            // 
            // TxtPhone
            // 
            TxtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TxtPhone.Location = new Point(125, 251);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.PlaceholderText = "Phone";
            TxtPhone.Size = new Size(220, 29);
            TxtPhone.TabIndex = 4;
            TxtPhone.TextChanged += TxtPhone_TextChanged;
            // 
            // DtpDateOfBirth
            // 
            DtpDateOfBirth.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            DtpDateOfBirth.Location = new Point(124, 165);
            DtpDateOfBirth.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            DtpDateOfBirth.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            DtpDateOfBirth.Name = "DtpDateOfBirth";
            DtpDateOfBirth.Size = new Size(286, 29);
            DtpDateOfBirth.TabIndex = 3;
            // 
            // TxtEmail
            // 
            TxtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TxtEmail.Location = new Point(124, 208);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.PlaceholderText = "Email";
            TxtEmail.Size = new Size(219, 29);
            TxtEmail.TabIndex = 2;
            TxtEmail.TextChanged += TxtEmail_TextChanged;
            // 
            // TxtLastName
            // 
            TxtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TxtLastName.Location = new Point(125, 125);
            TxtLastName.Name = "TxtLastName";
            TxtLastName.PlaceholderText = "Last Name";
            TxtLastName.Size = new Size(218, 29);
            TxtLastName.TabIndex = 1;
            // 
            // TxtFirstName
            // 
            TxtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TxtFirstName.Location = new Point(125, 81);
            TxtFirstName.Name = "TxtFirstName";
            TxtFirstName.PlaceholderText = "First Name";
            TxtFirstName.Size = new Size(219, 29);
            TxtFirstName.TabIndex = 0;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(665, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hawkins Bank - Add New Customer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            pnlStaffFields.ResumeLayout(false);
            pnlStaffFields.PerformLayout();
            ResumeLayout(false);
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
        private Panel pnlStaffFields;
        private ComboBox ComboBoxPosition;
        private ComboBox ComboBoxDepartments;
        private Label LabelPosition;
        private Label LabelDepartment;
    }
}