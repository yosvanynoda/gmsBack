namespace GMS.Objects.STD
{
    public class CreateMonitorRequest
    {
        //string fName, string lName, string email, string phone, string role, int companyId

        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Role { get; set; } = string.Empty;

        public int CompanyId { get; set; }

        public int Action { get; set; }

        public int Username { get; set; }

        public int? SiteId { get; set; }

        public int SponsorId { get; set; }


        public CreateMonitorRequest()
        {
            FirstName = "";

        }

    }
}
