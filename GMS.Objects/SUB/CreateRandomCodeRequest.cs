namespace GMS.Objects.SUB
{
    public class CreateRandomCodeRequest
    {
        //int subjectId, int studioId, string code, int companyId

        public int SubjectId { get; set; }

        public int StudioId { get; set; }

        public string Code { get; set; } = string.Empty;

        public int CompanyId { get; set; } = 0;
    }
}
