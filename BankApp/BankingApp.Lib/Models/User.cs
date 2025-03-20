namespace BankingApp.Lib.Models
{
    using System;

    // ===========================
    // ENUM: User Roles
    // ===========================
    // Defines different roles a user can have in the banking system.
    public enum UserRole
    {
        CUSTOMER,  // Regular bank customer
        STAFF,     // Bank employee with additional privileges
        BOTH       // User who is both a customer and a staff member
    }

    // ===========================
    // CLASS: User
    // ===========================
    // Represents a generic bank user, which could be a customer or a staff member.
    public class User
    {
        // Unique identifier for each user
        public int UserId { get; private set; }

        // Basic user information: First name, Last name, and Date of Birth
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        // Contact details associated with the user
        public ContactDetails ContactDetails { get; private set; }

        // Role of the user in the banking system (Customer, Staff, or Both)
        public UserRole Role { get; private set; }

        // Static counter to generate unique user IDs
        private static int userCount = 0;

        // ===========================
        // CONSTRUCTOR: User
        // ===========================
        /// <summary>
        /// Creates a new user with a unique ID, basic details, and a specific role.
        /// </summary>
        /// <param name="firstName">User's first name</param>
        /// <param name="lastName">User's last name</param>
        /// <param name="dateOfBirth">User's date of birth</param>
        /// <param name="contactDetails">User's contact details (address, email, phone number)</param>
        /// <param name="role">User role (Customer, Staff, or Both)</param>
        /// <exception cref="ArgumentException">Throws an exception if the role provided is invalid</exception>
        public User(string firstName, string lastName, DateTime dateOfBirth, ContactDetails contactDetails, UserRole role)
        {
            // Validate that the provided role is a defined enum value
            if (!Enum.IsDefined(typeof(UserRole), role))
            {
                throw new ArgumentException("Invalid role provided. Please use a valid UserRole value.");
            }

            // Assign unique user ID
            UserId = ++userCount;

            // Assign provided values
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            ContactDetails = contactDetails;
            Role = role;
        }

        // ===========================
        // METHOD: GetFeeDiscount
        // ===========================
        /// <summary>
        /// Determines the transaction fee discount based on the user's role.
        /// Staff members receive a 50% discount.
        /// </summary>
        /// <returns>Returns 0.5 (50% discount) for staff, 1.0 (no discount) for regular customers.</returns>
        public float GetFeeDiscount()
        {
            return (Role == UserRole.STAFF || Role == UserRole.BOTH) ? 0.5f : 1.0f;
        }

        // ===========================
        // METHOD: IsEligibleForDiscount
        // ===========================
        /// <summary>
        /// Checks if the user is eligible for a transaction fee discount.
        /// </summary>
        /// <returns>Returns true if the user is a staff member, otherwise false.</returns>
        public bool IsEligibleForDiscount()
        {
            return (Role == UserRole.STAFF || Role == UserRole.BOTH);
        }

        // ===========================
        // METHOD: UpdateDetails
        // ===========================
        /// <summary>
        /// Updates the contact details for the user.
        /// </summary>
        /// <param name="newDetails">New contact details object</param>
        public void UpdateDetails(ContactDetails newDetails)
        {
            ContactDetails = newDetails;
        }
    }

    // ===========================
    // CLASS: BankStaff
    // ===========================
    // Represents a specialized user who is a staff member at the bank.
    public class BankStaff : User
    {
        // Stores additional contact details specific to staff members
        public StaffContactDetails StaffDetails { get; private set; }

        // ===========================
        // CONSTRUCTOR: BankStaff
        // ===========================
        /// <summary>
        /// Creates a new bank staff member, inheriting from the User class.
        /// </summary>
        /// <param name="firstName">Staff's first name</param>
        /// <param name="lastName">Staff's last name</param>
        /// <param name="dateOfBirth">Staff's date of birth</param>
        /// <param name="contactDetails">General contact details</param>
        /// <param name="staffDetails">Additional details specific to staff members</param>
        public BankStaff(string firstName, string lastName, DateTime dateOfBirth, ContactDetails contactDetails, StaffContactDetails staffDetails)
            : base(firstName, lastName, dateOfBirth, contactDetails, UserRole.STAFF)
        {
            StaffDetails = staffDetails;
        }
    }
}
