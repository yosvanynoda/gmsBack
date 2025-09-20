namespace GMS.Objects.SUB
{
    public class CreateContactRequest
    {
        //int subjectId, string name, string phone, int relation, int companyId

        public int SubjectId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public int Relation { get; set; }

        public int CompanyId { get; set; } = 0;
    }
}
