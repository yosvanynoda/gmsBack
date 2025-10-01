namespace GMS.Objects.VLT
{
    public class VolunteerDeseaseData
    {
        public int VId { get; set; } = 0;

        public int DiseaseId { get; set; } = 0;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int CompanyId { get; set; } = 0;

        public int UserName { get; set; } = 0;

        public bool Active { get; set; }

        public int SiteId { get; set; } = 0;
    }
}
