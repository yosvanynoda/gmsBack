namespace GMS.Objects.SUB
{
    public class SubjectData
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public DateTime SubjectDOB { get; set; }

        public string SubjectSS { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public int AddressId { get; set; }

        public string SubjectEmail { get; set; } = string.Empty;

        public string SubjectId { get; set; } = string.Empty;

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public int CompanyId { get; set; } = 0;

        public string CurrentStatus { get; set; } = string.Empty;

        public string Weight { get; set; } = string.Empty;

        public string Height { get; set; } = string.Empty;

        public string LegalRepresentative { get; set; } = string.Empty;
    }
}
