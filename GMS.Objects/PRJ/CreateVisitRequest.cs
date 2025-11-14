namespace GMS.Objects.PRJ
{
    public class CreateVisitRequest
    {
        public int VisitId { get; set; }

        public int SubjectId { get; set; }

        public int StudioId { get; set; }

        public int Staffid { get; set; }

        public DateTime VisitDate { get; set; }

        public string Notes { get; set; }
    }
}
