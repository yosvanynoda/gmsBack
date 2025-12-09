namespace GMS.Objects.SUB
{
    public class SubjectProtocolDeviation
    {
        public int PDevID { get; set; }

        public int StudyID { get; set; }

        public int SubjectID { get; set; }

        public int VisitID { get; set; }

        public int CategoryId { get; set; }

        public string Description { get; set; } = string.Empty;

        public string Severity { get; set; } = string.Empty;

        public DateTime ReportedDate { get; set; }

        public string Outcome { get; set; } = string.Empty;

        public int UserName { get; set; }

        public bool Active { get; set; }
    }
}
