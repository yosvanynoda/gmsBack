namespace GMS.DBModels.VLT
{
    public class VLTGeneralDataUDT
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public DateTime SubjectDOB { get; set; }

        public string SubjectSS { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public int AddressId { get; set; }

        public string SubjectEmail { get; set; } = string.Empty;

        public string SubjectId { get; set; } = string.Empty;

        public DateTime DateCreated { get; set; }

        public int CompanyId { get; set; }

        public string CurrentStatus { get; set; } = string.Empty;

        public string Weight { get; set; } = string.Empty;

        public string Height { get; set; } = string.Empty;

        public string LegalRepresentative { get; set; } = string.Empty;
    }
}
