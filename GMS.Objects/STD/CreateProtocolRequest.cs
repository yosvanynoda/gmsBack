namespace GMS.Objects.STD
{
    public class CreateProtocolRequest
    {
       
        public int Id { get; set; }

        public string Protocol { get; set; } = string.Empty;

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public string Version { get; set; } = string.Empty;

        public int CompanyId { get; set; }

        public int Action { get; set; }

        public int Username { get; set; }

        public int? SiteId { get; set; }

        public string Notes { get; set; } = string.Empty;

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public CreateProtocolRequest()
        {
            Protocol = "";

        }

    }
}
