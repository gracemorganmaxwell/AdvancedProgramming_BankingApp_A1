using BankApp.Gui.Controllers;
using BankingApp.Lib.Models;

namespace BankApp.Gui.Forms
{
    /// <summary>
    /// Main dashboard for the banking application. Handles navigation and CSV import/export.
    /// </summary>
    public partial class MainMenuForm : Form
    {
        // === Controllers ===
        private readonly CustomerController _customerController = new CustomerController();
        private readonly CsvController _csvController = new CsvController();

        /// <summary>
        /// Initializes the main menu and loads any existing customer data from CSV.
        /// </summary>
        public MainMenuForm()
        {
            InitializeComponent();
            LoadAssets();
            DateTimeTimer.Start();

            // Load users from default CSV path on startup
            string customerCsvPath = Path.Combine(Application.StartupPath, "Assets", "customers.csv");
            _csvController.LoadUsers(customerCsvPath, _customerController.Users);
        }

        /// <summary>
        /// Handles the Add Customer button click.
        /// </summary>
        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            var addForm = new AddCustomerForm(_customerController);
            addForm.ShowDialog();
        }

        /// <summary>
        /// Loads icons and logos into the UI.
        /// </summary>
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

        /// <summary>
        /// Opens the customer search screen.
        /// </summary>
        private void BtnSearchCustomer_Click(object sender, EventArgs e)
        {
            var searchCustomerForm = new SearchCustomerForm(_customerController);
            searchCustomerForm.ShowDialog();
        }

        /// <summary>
        /// Updates the time/date label on the form.
        /// </summary>
        private void DateTimeTimer_Tick(object sender, EventArgs e)
        {
            LabelTimeDate.Text = DateTime.Now.ToLongDateString();
        }

        /// <summary>
        /// Opens a dialog for selecting a CSV file to import users.
        /// Provides a summary of results.
        /// </summary>
        private void BtnImportCustomers_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Import Customers"
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var result = _csvController.LoadUsers(openFile.FileName, _customerController.Users);

                    string message = $"✅ Imported: {result.Successful}\n" +
                                     $"⚠️ Duplicates skipped: {result.Duplicates}\n" +
                                     $"❌ Malformed lines: {result.Malformed}";

                    if (result.Duplicates > 0)
                        message += $"\n\n🔁 Duplicate Emails:\n- {string.Join("\n- ", result.DuplicateEmails)}";

                    if (result.Malformed > 0)
                        message += $"\n\n🧨 Malformed Rows:\n- {string.Join("\n- ", result.MalformedLines.Take(5))}" +
                                   (result.MalformedLines.Count > 5 ? "\n..." : "");

                    MessageBox.Show(message, "Import Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to import customers:\n{ex.Message}", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Opens a dialog for selecting a location to export current users to CSV.
        /// </summary>
        private void BtnExportCustomers_Click(object sender, EventArgs e)
        {
            using SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Export Customers",
                FileName = "customers.csv"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _csvController.SaveUsers(saveFile.FileName, _customerController.Users);
                    MessageBox.Show("Customers exported successfully.", "Export Complete");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to export customers:\n{ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}