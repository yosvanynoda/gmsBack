namespace GMS.Objects.STD
{
    public class SponsorBaseResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Type { get; set; }

        public int CompanyId { get; set; }

        public int? UserName { get; set; }

        public DateTime? ActionDateTime { get; set; }

        public DateTime? LastUpdatedAt { get; set; }

        public int SiteId { get; set; }

        public string? ContactName { get; set; }

        public string? ContactEmail { get; set; }

        public string? ContactPhone { get; set; }

        public bool? Active { get; set; }

        public string? SponsorType { get; set; }

        public SponsorBaseResponse()
        {
            Name = "";

            SponsorType = "";
        }
    }
}
