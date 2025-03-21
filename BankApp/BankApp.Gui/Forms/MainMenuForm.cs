using BankApp.Gui.Controllers;

namespace BankApp.Gui.Forms
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            LoadAssets();
            DateTimeTimer.Start();
        }

        private readonly CustomerController _customerController = new CustomerController();


        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            var addForm = new AddCustomerForm(_customerController);
            addForm.ShowDialog();
        }

        private void LoadAssets()
        {
            try
            {
                string iconPath = Path.Combine(Application.StartupPath, "Assets", "bankicon.ico");
                if (File.Exists(iconPath)) Icon = new Icon(iconPath);

                string logoPath = Path.Combine(Application.StartupPath, "Assets", "banklogo.png");
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

        private void DateTimeTimer_Tick(object sender, EventArgs e)
        {
            LabelTimeDate.Text = DateTime.Now.ToLongDateString();
        }
    }
}
