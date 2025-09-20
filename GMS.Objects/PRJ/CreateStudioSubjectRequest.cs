namespace GMS.Objects.PRJ
{
    public class CreateStudioSubjectRequest
    {
        public int SubjectId { get; set; }

        public int StudioId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int CompanyId { get; set; }
    }
}
