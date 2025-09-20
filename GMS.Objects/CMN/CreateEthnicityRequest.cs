namespace GMS.Objects.CMN
{
    public class CreateEthnicityRequest
    {
        public string Ethnicity { get; set; }

        public int Id { get; set; }

        public string? Comment { get; set; }

        public int CompanyId { get; set; }

        public int Action { get; set; }

        public int Username { get; set; }

        public CreateEthnicityRequest()
        {
            Ethnicity = "";
                       
        }
    }
}
