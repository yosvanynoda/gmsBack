namespace GMS.Objects.CMN
{
    public class CreateDocTypeRequest
    {
        public string DocType { get; set; } 

        public int Id { get; set; }

        public string? Comment { get; set; }

        public int ApplyFor { get; set; }

        public int CompanyId { get; set; }

        public int Action { get; set; }

        public int Username { get; set; }

        public CreateDocTypeRequest()
        {
            DocType = "";
        }
    }
}