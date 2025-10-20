namespace GMS.DBModels.SUB
{
    /// <summary>
    /// SUBGeneralData
    /// </summary>
    public class SUBDeviation
    {

       
        public int PDevID { get; set; }

        public int StudyId { get; set; }

        public int SubjectID { get; set; }

        public int VisitID { get; set; }

        public DateTime ScheduledDate { get; set; }

        public string Description { get; set; } = string.Empty;

        public int Severity { get; set; }

        public DateTime ReportedDate { get; set; }

        public string Outcome { get; set; } = string.Empty;

        public int DeviationId { get; set; }

        public string DeviationName { get; set; } = string.Empty;

        public string DeviationCode { get; set; }
        
      
        public SUBDeviation()
        {
            PDevID = 0;

        }

    }
}
