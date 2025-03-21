using BankingApp.Lib.Models;

namespace BankApp.Gui.Controllers
{
    /// <summary>
    /// Manages customer-related operations, acting as a bridge between the Model (User) and View.
    /// </summary>
    public class CustomerController
    {
        /// <summary>
        /// Stores a list of all customers (including staff).
        /// </summary>
        private List<User> _users;

        /// <summary>
        /// Initializes a new instance of the CustomerController.
        /// </summary>
        public CustomerController()
        {
            _users = [];
        }

        /// <summary>
        /// Adds a new customer to the system.
        /// </summary>
        /// <param name="firstName">First name of the customer</param>
        /// <param name="lastName">Last name of the customer</param>
        /// <param name="dateOfBirth">Date of birth of the customer</param>
        /// <param name="contactDetails">Contact details of the customer</param>
        /// <param name="role">User role (CUSTOMER or STAFF)</param>
        public void AddCustomer(string firstName, string lastName, DateTime dateOfBirth, ContactDetails contactDetails, UserRole role)
        {
            User newUser = new User(firstName, lastName, dateOfBirth, contactDetails, role);
            _users.Add(newUser);
            Console.WriteLine($"Customer {firstName} {lastName} added successfully.");
        }

        /// <summary>
        /// Updates the details of an existing customer.
        /// </summary>
        /// <param name="userId">ID of the customer to update</param>
        /// <param name="newDetails">New contact details</param>
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

        /// <summary>
        /// Deletes a customer from the system.
        /// </summary>
        /// <param name="userId">ID of the customer to remove</param>
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

        /// <summary>
        /// Searches for a customer by name.
        /// </summary>
        /// <param name="name">Name of the customer to search</param>
        /// <returns>List of customers matching the search query</returns>
        public List<User> SearchCustomer(string name)
        {
            List<User> matchingUsers = _users.FindAll(u => u.FirstName.Contains(name, StringComparison.OrdinalIgnoreCase) || 
                                                          u.LastName.Contains(name, StringComparison.OrdinalIgnoreCase));

            if (matchingUsers.Count == 0)
            {
                Console.WriteLine("No customers found.");
            }
            return matchingUsers;
        }

        /// <summary>
        /// Retrieves a customer by their ID.
        /// </summary>
        /// <param name="userId">User ID of the customer</param>
        /// <returns>The matching User object, or null if not found</returns>
        public User GetCustomer(int userId)
        {
            return _users.Find(u => u.UserId == userId);
        }

        /// <summary>
        /// Displays a list of all customers.
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
