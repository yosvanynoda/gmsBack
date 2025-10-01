namespace GMS.Objects.VLT
{
    public class VolunteerEmergencyContactData
    {
        public int VoluntierId { get; set; } = 0;

        public string ContactName { get; set; } = string.Empty;

        public string ContactPhone { get; set; } = string.Empty;

        public int ContactRelation { get; set; } = 0;

        public int CompanyId { get; set; } = 0;

        public int UserName { get; set; } = 0;

        public bool Active { get; set; }

        public int SiteId { get; set; } = 0;
    }
}
