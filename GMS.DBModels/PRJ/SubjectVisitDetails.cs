namespace GMS.DBModels.PRJ
{
    /// <summary>
    /// PRJStudioSubject
    /// </summary>
    public class SubjectVisitDetails
    {

        public int SubjectVisitID { get; set; }
        public int SubjectID { get; set; }
        public int VisitID { get; set; }
        public DateTime ScheduledDate { get; set; }       
        public int StudyId { get; set; }
        public int StaffId { get; set; }
        public string SubjectName { get; set; } = string.Empty;
        public string StudyName { get; set; } = string.Empty;
        public string StaffName { get; set; } = string.Empty;
        public string VisitStatus { get; set; } = string.Empty;       


    }
}
