namespace GMS.Objects.VLT
{
    public class VolunteerDeseaseData
    {
        public int CompanyId { get; set; } = 0;

        public int VId { get; set; } = 0;

        public int DiseaseId { get; set; } = 0;

        public DateOnly StartDate { get; set; }

        public DateOnly EndDate { get; set; }

        public int UserName { get; set; } = 0;

        public bool Active { get; set; }

        public int SiteId { get; set; } = 0;
    }
}

