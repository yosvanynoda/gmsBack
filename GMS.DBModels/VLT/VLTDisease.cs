namespace GMS.DBModels.VLT
{
    public class VLTDisease
    {
        public int DiseaseId { get; set; }

        public string DiseaseName { get; set; } = "";

        public string StartDate { get; set; } = "";

        public string? EndDate { get; set; } = "";

        public int VolunteerId { get; set; }

        public int CompanyId { get; set; }

        public int SiteId { get; set; }
    }
}
