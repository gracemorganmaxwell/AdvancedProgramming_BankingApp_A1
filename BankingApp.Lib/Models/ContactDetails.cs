namespace BankingApp.Lib.Models
{
    /// <summary>
    /// Represents a generic contact details class.
    /// Used for storing address, email, and phone number information.
    /// This class serves as a base for other contact details classes.
    /// </summary>
    public class ContactDetails
    {
        /// <summary>
        /// The street address of the individual.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// The email address of the individual.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The phone number of the individual.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Initializes a new instance of the ContactDetails class.
        /// </summary>
        /// <param name="address">Street address</param>
        /// <param name="email">Email address</param>
        /// <param name="phoneNumber">Phone number</param>
        public ContactDetails(string address, string email, string phoneNumber)
        {
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Returns a string representation of the contact details.
        /// </summary>
        /// <returns>A formatted string containing contact information</returns>
        public override string ToString()
        {
            return $"Address: {Address}, Email: {Email}, Phone: {PhoneNumber}";
        }
    }
}