namespace GMS.Objects.SUB
{
    public class SubjectInformedConsent
    {
        public int ConsentID { get; set; }

        public int SubjectID { get; set; }

        public int StudyId { get; set; }

        public int ProtocolVersionId { get; set; }

        public DateTime ConsentDate { get; set; }

        public bool ReconsentFlag { get; set; }

        public int UserName { get; set; }

        public bool Active { get; set; }

        public bool Signed { get; set; }
    }
}
