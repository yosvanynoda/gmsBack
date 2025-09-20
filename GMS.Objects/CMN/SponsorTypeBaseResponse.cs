namespace GMS.Objects.CMN
{
    public class SponsorTypeBaseResponse
    {
        public int Id { get; set; }

        public string SponsorType { get; set; }

        public int CompanyId { get; set; }

        public int? UserName { get; set; }

        public DateTime ActionDateTime { get; set; }

        public bool? Active { get; set; }

        public DateTime? LastUpdateAt { get; set; }

        public SponsorTypeBaseResponse()
        {
            SponsorType = "";          

        }
    }
}



