namespace GMS.DBModels.SUB
{
    /// <summary>
    /// SUBGeneralData
    /// </summary>
    public class SUBAdverse
    {
        
        public int AEID { get; set; }

        public int SubjectId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Severity { get; set; } = string.Empty;

        public string RelationshipToIP { get; set; } = string.Empty;

        public bool SeriousFlag { get; set; }

        public string SAECriteria { get; set; } = string.Empty;

        public string Outcome { get; set; } = string.Empty;

        public string MedDRACode { get; set; } = string.Empty;

        public SUBAdverse()
        {
            AEID = 0;

        }

    }
}
