namespace GMS.DBModels.SUB
{
    /// <summary>
    /// SUBGeneralData
    /// </summary>
    public class SUBConsent
    {
        
        public int ConsentID { get; set; }

        public int SubjectId { get; set; }

        public int StudyId { get; set; }

        public int ProtocolVersionId { get; set; }       

        public DateTime ConsentDate { get; set; }

        public bool ReconsentFlag { get; set; }

        public string ProtocolVersion { get; set; } = string.Empty;

        public bool Signed { get; set; }

        public SUBConsent()
        {
            ConsentID = 0;

        }

    }
}
