namespace GMS.Objects.CMN
{
    public class CreateSponsorTypeRequest
    {
        public string SponsorType { get; set; } 

        public int Id { get; set; } 

        public int CompanyId { get; set; }

        public int Action { get; set; } 

        public int Username { get; set; }

        public CreateSponsorTypeRequest()
        {
            SponsorType = "";
        }
    }
}
