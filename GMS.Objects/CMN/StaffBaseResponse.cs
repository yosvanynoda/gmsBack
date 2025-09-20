namespace GMS.Objects.CMN
{
    public class StaffBaseResponse
    {
        public int StaffId { get; set; }

        public int? CompanyId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Position { get; set; }

        public string? Department { get; set; }

        public string? StaffStatus { get; set; }

        public int? SiteId { get; set; }

        public int? UserName { get; set; }

        public DateTime ActionDateTime { get; set; }

        public bool? Active { get; set; }

        public DateTime? LastUpdateAt { get; set; }

        public string? SiteName { get; set; }

        public string? Studios { get; set; }

        public StaffBaseResponse()
        {
            FirstName = "";

            LastName = "";

            Email = "";

            PhoneNumber = "";

            Position = "";

            Department = "";

            StaffStatus = "";

            SiteName = "";

        }
    }
}



