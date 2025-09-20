namespace GMS.Objects.SUB
{
    public class CreateSubjectRequest
    {
        //string fName, string lName, DateTime dob, string ssNumber, string email, string phone, int addressId, string id, int companyId

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public DateTime DateOfBirth { get; set; }

        public string SocialSecurityNumber { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public int AddressId { get; set; }

        public string Id { get; set; } = string.Empty;

        public int CompanyId { get; set; }
    }
}
