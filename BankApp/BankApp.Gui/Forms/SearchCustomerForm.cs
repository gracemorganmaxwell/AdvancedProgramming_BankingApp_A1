using BankApp.Gui.Controllers;

namespace BankApp.Gui.Forms
{
    public partial class SearchCustomerForm : Form
    {
        private readonly CustomerController _customerController;

        public SearchCustomerForm(CustomerController customerController)
        {
            InitializeComponent();
            _customerController = customerController ?? throw new ArgumentNullException(nameof(customerController));
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string query = TxtSearchQuery.Text.Trim();

            if (string.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("Please enter a name to search.");
                return;
            }

            var results = _customerController.SearchCustomer(query);

            if (results.Count == 0)
            {
                MessageBox.Show("No customers found.");
                DataGridResults.DataSource = null;
                BtnEditCustomer.Enabled = false;
                BtnDeleteCustomer.Enabled = false;
                return;
            }

            var displayList = results.Select(c => new
            {
                ID = c.UserId,
                Name = $"{c.FirstName} {c.LastName}",
                Email = c.ContactDetails.Email,
                Phone = c.ContactDetails.PhoneNumber,
                Role = c.Role.ToString()
            }).ToList();

            DataGridResults.DataSource = displayList;
            BtnEditCustomer.Enabled = true;
            BtnDeleteCustomer.Enabled = true;
        }

        private void BtnEditCustomer_Click(object sender, EventArgs e)
        {
            if (DataGridResults.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to edit.");
                return;
            }

            int userId = (int)DataGridResults.SelectedRows[0].Cells["ID"].Value;

            var customerForm = new CustomerAccountForm(_customerController, userId);
            customerForm.ShowDialog();

            BtnSearch_Click(null, null);
        }

        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (DataGridResults.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            int userId = (int)DataGridResults.SelectedRows[0].Cells["ID"].Value;
            var selectedName = DataGridResults.SelectedRows[0].Cells["Name"].Value.ToString();

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete customer:\n{selectedName}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _customerController.DeleteCustomer(userId);
                MessageBox.Show("Customer deleted successfully.");
                BtnSearch_Click(null, null);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtSearchQuery.Clear();
            DataGridResults.DataSource = null;
            BtnEditCustomer.Enabled = false;
            BtnDeleteCustomer.Enabled = false;
        }

        private void BtnBackMainMenu_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenuForm();
            mainMenu.Show();
            Close();
        }
    }
}
