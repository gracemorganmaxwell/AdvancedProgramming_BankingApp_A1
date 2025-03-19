namespace BankingApp.Lib
{
    /// <summary>
    /// Represents contact details specific to bank staff.
    /// Extends ContactDetails to include staff-related information.
    /// </summary>
    public class StaffContactDetails : ContactDetails
    {
        /// <summary>
        /// Unique identifier for the staff member.
        /// </summary>
        public int StaffId { get; private set; }

        /// <summary>
        /// The department in which the staff member works.
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// The job position or role of the staff member.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Initializes a new instance of the StaffContactDetails class.
        /// </summary>
        /// <param name="address">Street address of the staff member</param>
        /// <param name="email">Work email address</param>
        /// <param name="phoneNumber">Work phone number</param>
        /// <param name="staffId">Unique staff ID</param>
        /// <param name="department">Department in which the staff member works</param>
        /// <param name="position">Staff member's job position</param>
        public StaffContactDetails(string address, string email, string phoneNumber, int staffId, string department, string position)
            : base(address, email, phoneNumber)
        {
            StaffId = staffId;
            Department = department;
            Position = position;
        }

        /// <summary>
        /// Returns a string representation of the staff contact details.
        /// </summary>
        /// <returns>A formatted string containing staff-specific contact details</returns>
        public override string ToString()
        {
            return base.ToString() + $", Staff ID: {StaffId}, Department: {Department}, Position: {Position}";
        }
    }
}