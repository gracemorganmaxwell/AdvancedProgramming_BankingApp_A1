using BankApp.Gui.Controllers;
using BankingApp.Lib.Models;
using System.Text.RegularExpressions;

namespace BankApp.Gui.Forms
{
    /// <summary>
    /// Represents the form used to add a new customer or staff member.
    /// </summary>
    public partial class AddCustomerForm : Form
    {
        private readonly CustomerController _customerController;
        private readonly CsvController _csvController = new CsvController();

        /// <summary>
        /// Constructor with required dependency injection.
        /// </summary>
        /// <param name="customerController">Reference to the central customer controller.</param>
        public AddCustomerForm(CustomerController customerController)
        {
            InitializeComponent();
            _customerController = customerController ?? throw new ArgumentNullException(nameof(customerController));

            // Load icons and assets
            LoadAssets();

            // Populate role dropdown and default it to CUSTOMER
            CmbRole.DataSource = Enum.GetValues(typeof(UserRole));
            CmbRole.SelectedItem = UserRole.CUSTOMER;

            // Set up live validation
            TxtEmail.TextChanged += TxtEmail_TextChanged;
            TxtPhone.TextChanged += TxtPhone_TextChanged;
            CmbRole.SelectedIndexChanged += CmbRole_SelectedIndexChanged;
        }

        /// <summary>
        /// Handles the Submit button click event — validates and adds a new customer.
        /// </summary>
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // === Validate required fields ===
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

            // === Sanitize inputs ===
            string firstName = Capitalize(TxtFirstName.Text.Trim());
            string lastName = Capitalize(TxtLastName.Text.Trim());
            string email = TxtEmail.Text.Trim().ToLower(); // standard email formatting
            string phone = TxtPhone.Text.Trim();
            string address = CapitalizeEachLine(TxtAddress.Text.Trim());

            var contact = new ContactDetails(address, email, phone);

            if (CmbRole.SelectedItem is not UserRole role)
            {
                MessageBox.Show("Invalid role selected.");
                return;
            }

            // === Add new user ===
            _customerController.AddCustomer(firstName, lastName, DtpDateOfBirth.Value, contact, role);

            // === Save updated user list to CSV ===
            string csvPath = Path.Combine(Application.StartupPath, "Assets", "customers.csv");
            _csvController.SaveUsers(csvPath, _customerController.Users);

            MessageBox.Show("Customer added successfully.", "Success");
            Close();
        }

        /// <summary>
        /// Handles the Cancel button click — closes the form.
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Loads icon and logo assets into the form from the Assets directory.
        /// </summary>
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

        // === Helper Functions ===

        /// <summary>
        /// Capitalizes the first letter of a string, lowers the rest.
        /// </summary>
        private static string Capitalize(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }

        /// <summary>
        /// Capitalizes each non-empty line individually.
        /// </summary>
        private static string CapitalizeEachLine(string input)
        {
            var lines = input.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = Capitalize(lines[i].Trim());
            }
            return string.Join(Environment.NewLine, lines);
        }

        /// <summary>
        /// Live validation for email field using regex.
        /// </summary>
        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            var email = TxtEmail.Text.Trim();
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                TxtEmail.BackColor = Color.MistyRose;
            else
                TxtEmail.BackColor = Color.White;
        }

        /// <summary>
        /// Live validation for phone field using regex.
        /// </summary>
        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {
            var phone = TxtPhone.Text.Trim();
            if (!Regex.IsMatch(phone, @"^\+?\d{7,15}$"))
                TxtPhone.BackColor = Color.MistyRose;
            else
                TxtPhone.BackColor = Color.White;
        }

        /// <summary>
        /// Toggles visibility of staff-specific input fields based on role selection.
        /// </summary>
        private void CmbRole_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (CmbRole.SelectedItem is UserRole role)
            {
                pnlStaffFields.Visible = role == UserRole.STAFF || role == UserRole.BOTH;
            }
        }
    }
}
