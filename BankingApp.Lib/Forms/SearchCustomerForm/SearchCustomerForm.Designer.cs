namespace SearchCustomerForm
{
    partial class SearchCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCustomerForm));
            labelTitle = new Label();
            textBox1 = new TextBox();
            button = new Button();
            dgvCustomers = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            btnEditCustomer = new Button();
            button1 = new Button();
            btnBack = new Button();
            label = new Label();
            label1 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(27, 23);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(247, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "🔍 Search Customer";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(295, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 29);
            textBox1.TabIndex = 2;
            textBox1.Text = "enter customers name here";
            // 
            // button
            // 
            button.BackColor = Color.Honeydew;
            button.FlatStyle = FlatStyle.Popup;
            button.Location = new Point(604, 27);
            button.Name = "button";
            button.Size = new Size(105, 31);
            button.TabIndex = 3;
            button.Text = "Search";
            button.UseVisualStyleBackColor = false;
            // 
            // dgvCustomers
            // 
            dgvCustomers.BorderStyle = BorderStyle.Fixed3D;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { ID, FirstName, LastName, Role });
            dgvCustomers.Location = new Point(154, 130);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.Size = new Size(444, 203);
            dgvCustomers.TabIndex = 4;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // FirstName
            // 
            FirstName.HeaderText = "First Name";
            FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            LastName.HeaderText = "Last Name";
            LastName.Name = "LastName";
            // 
            // Role
            // 
            Role.HeaderText = "Role";
            Role.Name = "Role";
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.BackColor = Color.Honeydew;
            btnEditCustomer.FlatStyle = FlatStyle.Popup;
            btnEditCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditCustomer.Location = new Point(27, 196);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(83, 39);
            btnEditCustomer.TabIndex = 5;
            btnEditCustomer.Text = "Edit";
            btnEditCustomer.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(27, 263);
            button1.Name = "button1";
            button1.Size = new Size(83, 39);
            button1.TabIndex = 6;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.WhiteSmoke;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Location = new Point(95, 33);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(190, 37);
            btnBack.TabIndex = 7;
            btnBack.Text = "⬅️ Back to Main Menu";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(27, 405);
            label.Name = "label";
            label.Size = new Size(0, 21);
            label.TabIndex = 8;
            label.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(159, 100);
            label1.Name = "label1";
            label1.Size = new Size(381, 21);
            label1.TabIndex = 9;
            label1.Text = "select the record you would like to view, edit or delete";
            // 
            // button2
            // 
            button2.BackColor = Color.Honeydew;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(27, 130);
            button2.Name = "button2";
            button2.Size = new Size(83, 39);
            button2.TabIndex = 10;
            button2.Text = "View";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnEditCustomer);
            panel1.Controls.Add(dgvCustomers);
            panel1.Controls.Add(button);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(labelTitle);
            panel1.Location = new Point(95, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 485);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(219, 219, 217);
            panel2.Location = new Point(27, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(682, 8);
            panel2.TabIndex = 20;
            // 
            // SearchCustomerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(219, 219, 217);
            ClientSize = new Size(1143, 630);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "SearchCustomerForm";
            Text = "Hawkins Bank - Search Customer Form";
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private TextBox textBox1;
        private Button button;
        private DataGridView dgvCustomers;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Role;
        private Button btnEditCustomer;
        private Button button1;
        private Button btnBack;
        private Label label;
        private Label label1;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
    }
}
