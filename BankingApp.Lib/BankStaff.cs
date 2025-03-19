namespace BankingApp.Lib
{
    using System;

    // ===========================
    // CLASS: BankStaff
    // ===========================
    // Represents a specialized user who is a staff member at the bank.
    // Inherits from the User class and extends it with staff-specific attributes.
    public class BankStaff : User
    {
        // Unique identifier for each staff member
        public int StaffId { get; private set; }

        // Department where the staff member works (e.g., Finance, IT, Customer Support)
        public string Department { get; set; }

        // Job position/title of the staff member (e.g., Branch Manager, Teller)
        public string Position { get; set; }

        // Additional contact details specific to staff members
        public StaffContactDetails StaffDetails { get; private set; }

        // Static counter to generate unique staff IDs
        private static int staffCount = 0;

        // ===========================
        // CONSTRUCTOR: BankStaff
        // ===========================
        /// <summary>
        /// Creates a new bank staff member, inheriting from the User class.
        /// </summary>
        /// <param name="firstName">Staff's first name</param>
        /// <param name="lastName">Staff's last name</param>
        /// <param name="dateOfBirth">Staff's date of birth</param>
        /// <param name="contactDetails">General contact details of the staff</param>
        /// <param name="staffDetails">Additional details specific to staff members</param>
        /// <param name="department">Department where the staff works</param>
        /// <param name="position">Job title/role of the staff</param>
        public BankStaff(
            string firstName,
            string lastName,
            DateTime dateOfBirth,
            ContactDetails contactDetails,
            StaffContactDetails staffDetails,
            string department,
            string position)
            : base(firstName, lastName, dateOfBirth, contactDetails, UserRole.STAFF) // Calls base User constructor with STAFF role
        {
            // Assign unique staff ID
            StaffId = ++staffCount;

            // Assign provided values
            StaffDetails = staffDetails;
            Department = department;
            Position = position;
        }

        // ===========================
        // METHOD: UpdateStaffDetails
        // ===========================
        /// <summary>
        /// Updates the staff member's department, position, and contact details.
        /// </summary>
        /// <param name="department">New department</param>
        /// <param name="position">New job title/position</param>
        /// <param name="newStaffDetails">Updated staff contact details</param>
        public void UpdateStaffDetails(string department, string position, StaffContactDetails newStaffDetails)
        {
            Department = department;
            Position = position;
            StaffDetails = newStaffDetails;
        }

        // ===========================
        // METHOD: IsManager
        // ===========================
        /// <summary>
        /// Checks if the staff member holds a managerial position.
        /// </summary>
        /// <returns>Returns true if the staff position contains 'manager', otherwise false.</returns>
        public bool IsManager()
        {
            return Position.ToLower().Contains("manager");
        }

        // ===========================
        // METHOD: ToString (Override)
        // ===========================
        /// <summary>
        /// Provides a formatted string representation of the staff member.
        /// </summary>
        /// <returns>Returns a string containing the staff member's name, position, department, and staff ID.</returns>
        public override string ToString()
        {
            return $"{FirstName} {LastName} - {Position} in {Department} (Staff ID: {StaffId})";
        }
    }
}
