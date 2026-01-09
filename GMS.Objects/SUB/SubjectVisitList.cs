using System.ComponentModel.Design;

namespace GMS.Objects.SUB
{
    public class SubjectVisitList
    {
        public int SubjectVisitID { get; set; }

        public int SubjectId { get; set; }

        public int VisitID { get; set; }

        public DateTime ScheduledDate { get; set; }

        public string Status { get; set; } = string.Empty;

        public string Notes { get; set; } = string.Empty;

        public int StudyId { get; set; }

        public string VisitName { get; set; } = string.Empty;

        public int DayOffset { get; set; }

        public int WindowMinus { get; set; }

        public int WindowPlus { get; set; }

        public bool RequiredFlag { get; set; }

        public int CompanyId { get; set; }

        public int SiteId { get; set; }

        public string VisitComment { get; set; } = string.Empty;

        public int StaffId { get; set; }

        public string StaffName { get; set; } = string.Empty;

        public string SubjectName { get; set; } = string.Empty;

        public DateTime WindowStart { get; set; }

        public DateTime WindowEnd { get; set; }

        public int DependencyOf { get; set; }

    }
}
