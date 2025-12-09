namespace GMS.Objects.SUB
{
    public class SubjectGeneralData
    {
        public int SubjectId { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public int CompanyId { get; set; }

        public string CurrentStatus { get; set; } = string.Empty;

        public int UserNameId { get; set; }

        public bool Active { get; set; }

        public int SiteId { get; set; }

        public int VolunteerId { get; set; }

        public int StudyId { get; set; }

        public string SubjectCode { get; set; } = string.Empty;

    }
}
