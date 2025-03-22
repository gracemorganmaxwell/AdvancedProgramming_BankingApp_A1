using BankingApp.Lib.Models;

namespace BankApp.Gui.Controllers
{
    /// <summary>
    /// Handles import and export of application data (e.g. customers, accounts) using CSV format.
    /// </summary>
    public class CsvController
    {
        // === Customer Export ===

        /// <summary>
        /// Saves all customer records to a CSV file.
        /// </summary>
        /// <param name="filePath">Full path to the CSV file.</param>
        /// <param name="users">List of users to save.</param>
        public void SaveUsers(string filePath, List<User> users)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);

            using var writer = new StreamWriter(filePath);
            writer.WriteLine("UserId,FirstName,LastName,Email,Phone,Address,Role,DateOfBirth,Department,Position");

            foreach (var user in users)
            {
                var c = user.ContactDetails;
                string department = "", position = "";

                if (user is BankStaff staff)
                {
                    department = staff.Department ?? "";
                    position = staff.Position ?? "";
                }

                writer.WriteLine($"{user.UserId},{user.FirstName},{user.LastName},{c.Email},{c.PhoneNumber},{c.Address},{user.Role},{user.DateOfBirth:yyyy-MM-dd},{department},{position}");
            }
        }

        // === Customer Import ===

        /// <summary>
        /// Loads customer records from a CSV file and appends them to the given list.
        /// Skips duplicate emails and malformed lines, returning an import summary.
        /// </summary>
        /// <param name="filePath">Path to the CSV file to read from.</param>
        /// <param name="users">Reference to the in-memory user list to populate.</param>
        /// <returns>Summary report containing stats and details about the import.</returns>
        public CsvImportResult LoadUsers(string filePath, List<User> users)
        {
            CsvImportResult result = new();

            if (!File.Exists(filePath)) return result;

            using var reader = new StreamReader(filePath);
            string? headerLine = reader.ReadLine(); // Skip header row

            while (!reader.EndOfStream)
            {
                string? line = reader.ReadLine();
                if (string.IsNullOrWhiteSpace(line)) continue;

                var fields = line.Split(',');

                if (fields.Length < 8)
                {
                    result.Malformed++;
                    result.MalformedLines.Add(line);
                    continue;
                }

                try
                {
                    int userId = int.Parse(fields[0]);
                    string firstName = fields[1];
                    string lastName = fields[2];
                    string email = fields[3];
                    string phone = fields[4];
                    string address = fields[5];
                    UserRole role = Enum.Parse<UserRole>(fields[6]);
                    DateTime dob = DateTime.Parse(fields[7]);

                    string department = fields.Length > 8 ? fields[8] : "";
                    string position = fields.Length > 9 ? fields[9] : "";

                    if (users.Any(u => u.ContactDetails.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
                    {
                        result.Duplicates++;
                        result.DuplicateEmails.Add(email);
                        continue;
                    }

                    var contact = new ContactDetails(address, email, phone);

                    User user;
                    if (role == UserRole.STAFF || role == UserRole.BOTH)
                    {
                        var staffDetails = new StaffContactDetails(address, email, phone, userId, department, position);
                        user = new BankStaff(firstName, lastName, dob, contact, staffDetails, department, position);
                    }
                    else
                    {
                        user = new User(firstName, lastName, dob, contact, role);
                    }

                    users.Add(user);
                    result.Successful++;
                }
                catch
                {
                    result.Malformed++;
                    result.MalformedLines.Add(line);
                }
            }

            return result;
        }

        // === Accounts (Placeholder) ===

        /// <summary>
        /// Saves account records to a CSV file (to be implemented).
        /// </summary>
        public void SaveAccounts(string filePath, List<Account> accounts)
        {
            // TODO: Implement account export
        }

        /// <summary>
        /// Loads account records from a CSV file (to be implemented).
        /// </summary>
        public void LoadAccounts(string filePath, List<Account> accounts)
        {
            // TODO: Implement account import
        }
    }

    /// <summary>
    /// Contains results of a CSV import operation.
    /// Tracks successful, duplicate, and malformed records.
    /// </summary>
    public class CsvImportResult
    {
        public int Successful { get; set; }
        public int Duplicates { get; set; }
        public int Malformed { get; set; }
        public List<string> DuplicateEmails { get; set; } = new();
        public List<string> MalformedLines { get; set; } = new();
    }
}
