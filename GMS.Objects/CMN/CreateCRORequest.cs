namespace GMS.Objects.CMN
{
    public class CreateCRORequest
    {
        public string CRO { get; set; }

        public int Id { get; set; }

        public string? Comment { get; set; }

        public int CompanyId { get; set; }

        public int Action { get; set; }

        public int Username { get; set; }

        public CreateCRORequest()
        {
            CRO = "";
        }
    }
}
