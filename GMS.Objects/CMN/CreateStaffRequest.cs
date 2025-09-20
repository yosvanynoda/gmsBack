namespace GMS.Objects.CMN
{
    public class CreateStaffRequest
    {
        public int StaffId { get; set; } 

        public string FirstName { get; set; } 

        public string LastName { get; set; } 

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public string? Role { get; set; }

        public string? Department { get; set; } 

        public string? Status { get; set; } 

        public int Site { get; set; } 

        public int CompanyId { get; set; }

        public int Action { get; set; }

        public int Username { get; set; }

        public CreateStaffRequest()
        {
            FirstName = "";

            LastName = "";

            Phone = "";

            Email = "";

            Role = "";

            Department = "";

            Status = "";
        }
    }
}
