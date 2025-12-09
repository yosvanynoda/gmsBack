namespace GMS.DBModels.VLT
{
    public class VLTVolunteerList
    {
        public int VolunteerId { get; set; }

        public int? CompanyId { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string? SubjectDOB { get; set; } = string.Empty;

        public string? Sex { get; set; } = string.Empty;

        public string? Race { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string? Ethnicity { get; set; } = string.Empty;

        public string? CurrentStatus { get; set; } = string.Empty;

        public int? SiteId { get; set; }

        public string FlagColor { get; set; }

        public string FlagName { get; set; }


    }
}
