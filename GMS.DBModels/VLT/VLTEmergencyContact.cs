namespace GMS.DBModels.VLT
{
    public class VLTEmergencyContact
    {
        public int EmergencyContactId { get; set; }

        public string ContactName { get; set; } = "";

        public string ContactPhone { get; set; } = "";

        public string ContactRelation { get; set; } = "";

        public int VolunteerId { get; set; }

        public int? CompanyId { get; set; }

        public int? SiteId { get; set; }
    }
}
