namespace GMS.Objects.VLT
{
    public class VolunteerGeneralData
    {
        public int VolunteerId { get; set; } = 0;

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string MiddleName { get; set; } = string.Empty;

        public DateTime SubjectDOB { get; set; }

        public string SubjectSS { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string SubjectEmail { get; set; } = string.Empty;

        public string SubjectId { get; set; } = string.Empty;

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public int CompanyId { get; set; } = 0;

        public string CurrentStatus { get; set; } = string.Empty;

        public string Weight { get; set; } = string.Empty;

        public string Height { get; set; } = string.Empty;

        public string LegalRepresentative { get; set; } = string.Empty;

        public int AddressId { get; set; } = 0;

        public string Address1 { get; set; } = string.Empty;

        public string Address2 { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

        public string ZipCode { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public int UserName { get; set; } = 0;

        public bool Active { get; set; }

        public int SiteId { get; set; } = 0;

        public int Race { get; set; } = 0;

        public int Ethnicity { get; set; } = 0;

        public string Picture { get; set; } = string.Empty;

        public int Sex { get; set; } = 0;

        public int Gender { get; set; } = 0;

        public int Language { get; set; } = 0;
        

    }
}
