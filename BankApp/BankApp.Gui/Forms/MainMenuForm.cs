using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp.Gui.Forms
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            LoadAssets();
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.Show();
        }



        private void LoadAssets()
        {
            try
            {
                string iconPath = Path.Combine(Application.StartupPath, "Assets", "bankappicon.ico");
                if (File.Exists(iconPath)) this.Icon = new Icon(iconPath);

                string logoPath = Path.Combine(Application.StartupPath, "Assets", "iconlogo.png");
                if (File.Exists(logoPath)) pictureLogo.Image = Image.FromFile(logoPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading assets: {ex.Message}", "Asset Load Error");
            }
        }

        private void BtnSearchCustomer_Click(object sender, EventArgs e)
        {
            SearchCustomerForm searchCustomerForm = new SearchCustomerForm();
            searchCustomerForm.Show();
        }
    }
}
