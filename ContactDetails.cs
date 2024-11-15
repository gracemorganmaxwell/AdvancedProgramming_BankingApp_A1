namespace BankingApp.Lib
{
    public class ContactDetails
    { 
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public ContactDetails(string address, string email, string phoneNumber)
        {
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}