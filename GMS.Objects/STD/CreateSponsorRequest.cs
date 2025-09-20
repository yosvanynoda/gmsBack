namespace GMS.Objects.STD
{
    public class CreateSponsorRequest
    {
      
        public int Id { get; set; } = 0;

        public string SponsorName { get; set; }

        public int SponsorType { get; set; } = 0;

        public string? ContactName { get; set; } = string.Empty;

        public string? ContactEmail { get; set; } = string.Empty;

        public string? ContactPhone { get; set; } = string.Empty;

        public int CompanyId { get; set; } = 0;

       public int SiteId { get; set; } = 0;

        public int Username { get; set; } = 0;

        public int Action { get; set; } = 0;


        public CreateSponsorRequest()
        {
            SponsorName = "";
        }

    }
}
