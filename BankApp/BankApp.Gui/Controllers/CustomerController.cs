using BankingApp.Lib.Models;

namespace BankApp.Gui.Controllers
{
    /// <summary>
    /// Manages customer-related operations, acting as a bridge between the UI and the model layer.
    /// </summary>
    public class CustomerController
    {
        /// <summary>
        /// Internal list of users in memory (including staff and customers).
        /// </summary>
        private List<User> _users;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerController"/> class.
        /// </summary>
        public CustomerController()
        {
            _users = new List<User>();
        }

        /// <summary>
        /// Public accessor to expose the list of users to other controllers (e.g. CsvController).
        /// </summary>
        public List<User> Users => _users;

        // === Add ===

        /// <summary>
        /// Adds a new customer or staff member to the system.
        /// </summary>
        /// <param name="firstName">Customer's first name.</param>
        /// <param name="lastName">Customer's last name.</param>
        /// <param name="dateOfBirth">Customer's date of birth.</param>
        /// <param name="contactDetails">Contact details (email, phone, address).</param>
        /// <param name="role">User role (e.g. CUSTOMER, STAFF, BOTH).</param>
        public void AddCustomer(string firstName, string lastName, DateTime dateOfBirth, ContactDetails contactDetails, UserRole role)
        {
            User newUser = new User(firstName, lastName, dateOfBirth, contactDetails, role);
            _users.Add(newUser);
            Console.WriteLine($"Customer {firstName} {lastName} added successfully.");
        }

        // === Update ===

        /// <summary>
        /// Updates an existing customer's contact details.
        /// </summary>
        /// <param name="userId">The ID of the customer to update.</param>
        /// <param name="newDetails">The new contact details.</param>
        public void UpdateCustomer(int userId, ContactDetails newDetails)
        {
            User customer = _users.Find(u => u.UserId == userId);
            if (customer != null)
            {
                customer.UpdateDetails(newDetails);
                Console.WriteLine($"Customer {customer.FirstName} {customer.LastName} updated successfully.");
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }

        // === Delete ===

        /// <summary>
        /// Deletes a customer from the system by ID.
        /// </summary>
        /// <param name="userId">The ID of the customer to delete.</param>
        public void DeleteCustomer(int userId)
        {
            User customer = _users.Find(u => u.UserId == userId);
            if (customer != null)
            {
                _users.Remove(customer);
                Console.WriteLine($"Customer {customer.FirstName} {customer.LastName} deleted.");
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }

        // === Search ===

        /// <summary>
        /// Searches users by first or last name (case-insensitive).
        /// </summary>
        /// <param name="name">The name to search for.</param>
        /// <returns>A list of matching users.</returns>
        public List<User> SearchCustomer(string name)
        {
            var matches = _users.FindAll(u =>
                u.FirstName.Contains(name, StringComparison.OrdinalIgnoreCase) ||
                u.LastName.Contains(name, StringComparison.OrdinalIgnoreCase));

            if (matches.Count == 0)
            {
                Console.WriteLine("No customers found.");
            }

            return matches;
        }

        // === Get By ID ===

        /// <summary>
        /// Gets a user by their ID.
        /// </summary>
        /// <param name="userId">The user's unique ID.</param>
        /// <returns>The user if found; otherwise, null.</returns>
        public User? GetCustomer(int userId)
        {
            return _users.Find(u => u.UserId == userId);
        }

        // === Display All ===

        /// <summary>
        /// Writes all customers to the console (for debugging).
        /// </summary>
        public void DisplayCustomers()
        {
            if (_users.Count == 0)
            {
                Console.WriteLine("No customers available.");
                return;
            }

            Console.WriteLine("Customer List:");
            foreach (User customer in _users)
            {
                Console.WriteLine($"ID: {customer.UserId}, Name: {customer.FirstName} {customer.LastName}, Role: {customer.Role}");
            }
        }
    }
}
