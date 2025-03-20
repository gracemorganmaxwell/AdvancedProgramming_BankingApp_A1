namespace BankApp.Gui
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Reflection;
    using System.Windows.Forms;
    using System.BankApp.Gui.Assets;

    public partial class FormHomeScreen : Form
    {
        public FormHomeScreen()
        {
            InitializeComponent();
            LoadAssets(); // Call method to load icon and logo
        }

        private void LoadAssets()
        {
            try
            {
                // Load the form icon from Assets folder
                string iconPath = Path.Combine(Application.StartupPath, "Assets", "bankappicon.ico");
                if (File.Exists(iconPath))
                {
                    this.Icon = new Icon(iconPath);
                }

                // Load the PictureBox logo
                string logoPath = Path.Combine(Application.StartupPath, "Assets", "iconlogo.png");
                if (File.Exists(logoPath))
                {
                    pictureLogo.Image = Image.FromFile(logoPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading assets: {ex.Message}", "Asset Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.Show();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            SearchCustomerForm searchCustomerForm = new SearchCustomerForm();
            searchCustomerForm.Show();
        }
    }
}