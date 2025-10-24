namespace GMS.Objects.SUB
{
    public class SubjectProtocolDeviation
    {
        public int SubjectId { get; set; }

        public int VolunteerId { get; set; }

        public int StudyId { get; set; }

        public int CompanyId { get; set; }

        public int SiteId { get; set; }

        public int UserNameId { get; set; }

        public string CurrentStatus { get; set; } = string.Empty;

        public int CurrentStatusId { get; set; }
    }
}
