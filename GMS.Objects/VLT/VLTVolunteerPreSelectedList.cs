namespace GMS.Objects.VLT
{
    public class  VLTVolunteerPreSelectedList
    {
        public int StudyId { get; set; }

        public int VolunteerId { get; set; }

        public int? CompanyId { get; set; }

        public string VolunteerName { get; set; } = string.Empty;

        public string StudyName { get; set; } = string.Empty;

        public string PreAssignedDate { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;

        public string? SubjectDOB { get; set; } = string.Empty;

        public string? Sex { get; set; } = string.Empty;

        public string? Race { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string? Ethnicity { get; set; } = string.Empty;

        public string? CurrentStatus { get; set; } = string.Empty;

        public int? SiteId { get; set; }

        public string FlagColor { get; set; }
    }
}
