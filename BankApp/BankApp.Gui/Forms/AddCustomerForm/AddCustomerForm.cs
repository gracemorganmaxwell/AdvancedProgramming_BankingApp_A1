namespace BankingApp.Gui
{
    using System;
    using System.Windows.Forms;
    using BankingApp.Gui.Controllers;
    using BankingApp.Lib.Models;

    /// <summary>
    /// Form for adding a new customer.
    /// </summary>
    public partial class AddCustomerForm : Form
    {
        private CustomerController customerController;

        /// <summary>
        /// Initializes the AddCustomerForm and sets up the controller.
        /// </summary>
        public AddCustomerForm()
        {
            InitializeComponent();
            customerController = new CustomerController();

            // Populate role dropdown
            cmbRole.Items.Add("Customer");
            cmbRole.Items.Add("Staff");
            cmbRole.Items.Add("Both");
            cmbRole.SelectedIndex = 0; // Default to "Customer"
        }

        /// <summary>
        /// Handles the Save Customer button click event.
        /// Validates input fields, creates a new customer, and adds it to the system.
        /// </summary>
        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            // Retrieve input values
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            DateTime dob = dtpDateOfBirth.Value;
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            UserRole role = GetSelectedUserRole();

            // Validate input fields
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("First Name and Last Name are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dob > DateTime.Now)
            {
                MessageBox.Show("Date of Birth cannot be in the future.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create new contact details object
            ContactDetails contactDetails = new ContactDetails
            {
                Email = email,
                PhoneNumber = phone,
                Address = address
            };

            // Save customer using the controller
            customerController.AddCustomer(firstName, lastName, dob, contactDetails, role);
            MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear form for a new entry
            ClearForm();
        }

        /// <summary>
        /// Retrieves the selected user role from the ComboBox.
        /// </summary>
        private UserRole GetSelectedUserRole()
        {
            string selectedRole = cmbRole.SelectedItem.ToString();
            return selectedRole switch
            {
                "Staff" => UserRole.STAFF,
                "Both" => UserRole.BOTH,
                _ => UserRole.CUSTOMER
            };
        }

        /// <summary>
        /// Clears all input fields for a new entry.
        /// </summary>
        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            cmbRole.SelectedIndex = 0;
            dtpDateOfBirth.Value = DateTime.Now;
        }

        /// <summary>
        /// Handles cancel button click event to close the form without saving.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles back button click event to navigate back to the main menu.
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
