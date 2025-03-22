using BankApp.Gui.Controllers;

namespace BankApp.Gui.Forms
{
    public partial class CustomerAccountForm : Form
    {
        private readonly CustomerController _customerController;
        private readonly int _userId;

        public CustomerAccountForm(CustomerController customerController, int userId)
        {
            InitializeComponent();
            _customerController = customerController ?? throw new ArgumentNullException(nameof(customerController));
            _userId = userId;

            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            var customer = _customerController.GetCustomer(_userId);
            if (customer == null)
            {
                MessageBox.Show("Customer not found.");
                Close();
                return;
            }

            // Load customer data into form controls (TextBoxes, Labels, etc.)
            // e.g., TxtFirstName.Text = customer.FirstName;
        }
    }

}
