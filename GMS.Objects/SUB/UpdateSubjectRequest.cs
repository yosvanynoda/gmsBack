namespace GMS.Objects.SUB
{
    public class UpdateSubjectRequest
    {
        public List<SubjectGeneralData> SubjectGeneralData { get; set; } = [];

        public List<SubjectInformedConsent> SubjectInformedConsent { get; set; } = [];

        public List<SubjectAdverseEvent> SubjectAdverseEvent { get; set; } = [];

        public List<SubjectProtocolDeviation> SubjectProtocolDeviation { get; set; } = [];

        
    }
}
