namespace GMS.DBModels.SUB
{
    /// <summary>
    /// SUBGeneralData
    /// </summary>
    public class SUBVisitPlanList
    {

        public int SubjectVisitID { get; set; }

        public int SubjectId { get; set; }

        public int VisitID { get; set; }

        public DateTime ScheduledDate { get; set; }

        public string Status { get; set; } = string.Empty;

        public string Notes { get; set; }

        public int StudyId { get; set; }

        public string VisitName { get; set; }

        public int DayOffset { get; set; }

        public int WindowMinus { get; set; }

        public int WindowPlus { get; set; }

        public bool RequiredFlag { get; set; }

        public int CompanyId { get; set; }

        public int SiteId { get; set; }

        public string VisitComment { get; set; }

        public int StaffId { get; set; }

        public string StaffName { get; set; }

    }
}
