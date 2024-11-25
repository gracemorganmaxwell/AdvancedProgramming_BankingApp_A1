namespace BankingApp.Lib;

public class StaffContactDetails : ContactDetails
{
    public int StaffId { get; private set; }
    public string Department { get; set; }
    public string Position { get; set; }

    public StaffContactDetails(string address, string email, string phoneNumber, int staffId, string department, string position)
        : base(address, email, phoneNumber)
    {
        StaffId = staffId;
        Department = department;
        Position = position;
    }
}