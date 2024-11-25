namespace BankingApp.Lib
{
    using System;

    // User class to handle customer and staff information
    public class User
    {
        public int UserId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ContactDetails ContactDetails { get; private set; }
        public string Role { get; private set; } // CUSTOMER, STAFF, or BOTH
        private static int userCount = 0;

        public User(string firstName, string lastName, DateTime dateOfBirth, ContactDetails contactDetails, string role)
        {
            UserId = ++userCount;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            ContactDetails = contactDetails;
            Role = role;
        }

        public float GetFeeDiscount()
        {
            return Role == "STAFF" || Role == "BOTH" ? 0.5f : 1.0f;
        }

        public bool IsEligibleForDiscount()
        {
            return Role == "STAFF" || Role == "BOTH";
        }

        public void UpdateDetails(ContactDetails newDetails)
        {
            ContactDetails = newDetails;
        }
    }
}
