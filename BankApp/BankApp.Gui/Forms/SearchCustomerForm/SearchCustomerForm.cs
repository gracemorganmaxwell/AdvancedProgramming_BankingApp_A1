namespace BankApp.Gui
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using BankingApp.Lib.Models;
    using BankApp.Gui.Controllers;

    public partial class SearchCustomerForm : Form
    {
        private CustomerController customerController;

        public SearchCustomerForm()
        {
            InitializeComponent();
            customerController = new CustomerController();
            LoadCustomerData();
        }

        // Load all customers into DataGridView when the form is opened
        private void LoadCustomerData()
        {
            dgvCustomers.Rows.Clear(); // Clear any existing rows

            List<User> customers = customerController.GetAllCustomers();

            foreach (var customer in customers)
            {
                dgvCustomers.Rows.Add(customer.UserId, customer.FirstName, customer.LastName, customer.Role.ToString());
            }
        }

        // Search customers by name when search button is clicked
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                MessageBox.Show("Please enter a customer name to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var searchResults = customerController.SearchCustomer(searchQuery);

            dgvCustomers.Rows.Clear(); // Clear previous results

            foreach (var customer in searchResults)
            {
                dgvCustomers.Rows.Add(customer.UserId, customer.FirstName, customer.LastName, customer.Role.ToString());
            }

            if (searchResults.Count == 0)
            {
                MessageBox.Show("No customers found matching the search query.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Edit selected customer
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to edit.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedCustomerId = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["ID"].Value);
            User selectedCustomer = customerController.GetCustomer(selectedCustomerId);

            if (selectedCustomer != null)
            {
                AddCustomerForm editForm = new AddCustomerForm(selectedCustomer); // Pass selected customer
                editForm.ShowDialog();
                LoadCustomerData(); // Refresh customer list after editing
            }
        }

        // Delete selected customer
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedCustomerId = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["ID"].Value);
            DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmDelete == DialogResult.Yes)
            {
                bool isDeleted = customerController.DeleteCustomer(selectedCustomerId);

                if (isDeleted)
                {
                    MessageBox.Show("Customer deleted successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomerData(); // Refresh the list
                }
                else
                {
                    MessageBox.Show("Failed to delete the customer. Try again.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // View details of selected customer
        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to view.", "View Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedCustomerId = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["ID"].Value);
            User selectedCustomer = customerController.GetCustomer(selectedCustomerId);

            if (selectedCustomer != null)
            {
                MessageBox.Show($"Customer Details:\n\n" +
                                $"ID: {selectedCustomer.UserId}\n" +
                                $"Name: {selectedCustomer.FirstName} {selectedCustomer.LastName}\n" +
                                $"Role: {selectedCustomer.Role}\n" +
                                $"Email: {selectedCustomer.ContactDetails.Email}\n" +
                                $"Phone: {selectedCustomer.ContactDetails.PhoneNumber}\n" +
                                $"Address: {selectedCustomer.ContactDetails.Address}",
                                "Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Navigate back to Main Menu
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the search form
        }
    }
}
