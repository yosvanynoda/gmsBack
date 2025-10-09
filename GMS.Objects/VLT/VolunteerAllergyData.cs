namespace GMS.Objects.VLT
{
    public class VolunteerAllergyData
    {
        public int CompanyId { get; set; } = 0;

        public int VId { get; set; } = 0;

        public int AllergyId { get; set; } = 0;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int UserName { get; set; } = 0;

        public bool Active { get; set; }

        public int SiteId { get; set; } = 0;
    }
}
