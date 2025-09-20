 namespace GMS.Objects.STD
{
    public class ProtocolBaseResponse
    {
        public int Id { get; set; }

        public string Protocol { get; set; }

        public DateTime DateCreated { get; set; }

        public string Version { get; set; }

        public int CompanyId { get; set; }

        public int UserName { get; set; }

        public DateTime ActionDateTime { get; set; }

        public bool Active { get; set; }

        public DateTime LastUpdatedAt { get; set; }

        public int SiteId { get; set; }

        public string StudioName { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }


        public ProtocolBaseResponse()
        {
            Protocol = "";

            Version = "";

            StudioName = "";
        }
    }
}
