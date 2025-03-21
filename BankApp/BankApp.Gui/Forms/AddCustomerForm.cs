using BankApp.Gui.Controllers;
using BankingApp.Lib.Models;

namespace BankApp.Gui.Forms
{
    public partial class AddCustomerForm : Form
    {
        private readonly CustomerController _customerController;

        public AddCustomerForm(CustomerController customerController)
        {
            InitializeComponent();
            _customerController = customerController ?? throw new ArgumentNullException(nameof(customerController));
            LoadAssets();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // === Required field validation ===
            if (string.IsNullOrWhiteSpace(TxtFirstName.Text) ||
                string.IsNullOrWhiteSpace(TxtLastName.Text) ||
                string.IsNullOrWhiteSpace(TxtEmail.Text) ||
                string.IsNullOrWhiteSpace(TxtPhone.Text) ||
                string.IsNullOrWhiteSpace(TxtAddress.Text) ||
                CmbRole.SelectedItem == null)
            {
                MessageBox.Show("All fields are required. Please fill in every field.", "Validation Error");
                return;
            }

            // === Sanitize and normalize input ===
            string firstName = Capitalize(TxtFirstName.Text.Trim());
            string lastName = Capitalize(TxtLastName.Text.Trim());
            string email = TxtEmail.Text.Trim().ToLower(); // emails are lowercase
            string phone = TxtPhone.Text.Trim();
            string address = CapitalizeEachLine(TxtAddress.Text.Trim());

            var contact = new ContactDetails(address, email, phone);

            if (!Enum.TryParse(CmbRole.SelectedItem.ToString(), out UserRole role))
            {
                MessageBox.Show("Invalid role selected.");
                return;
            }

            _customerController.AddCustomer(
                firstName,
                lastName,
                DtpDateOfBirth.Value,
                contact,
                role
            );

            MessageBox.Show("Customer added successfully.", "Success");
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // === Asset loading ===
        private void LoadAssets()
        {
            try
            {
                string basePath = Application.StartupPath;

                string iconPath = Path.Combine(basePath, "Assets", "bankicon.ico");
                if (File.Exists(iconPath))
                    Icon = new Icon(iconPath);

                string logoPath = Path.Combine(basePath, "Assets", "banklogo.png");
                if (File.Exists(logoPath))
                    Logo.Image = Image.FromFile(logoPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading assets: {ex.Message}", "Asset Load Error");
            }
        }

        // === Helpers ===

        private static string Capitalize(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }

        private static string CapitalizeEachLine(string input)
        {
            var lines = input.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = Capitalize(lines[i].Trim());
            }
            return string.Join(Environment.NewLine, lines);
        }
    }
}
