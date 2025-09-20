namespace GMS.DBModels.VLT
{
    public class VLTAllergy
    {
        public int AllergyId { get; set; }

        public string Allergy { get; set; } = "";

        public string StartDate { get; set; } = "";

        public string? EndDate { get; set; } = "";

        public int VolunteerId { get; set; }

        public int CompanyId { get; set; }

        public int SiteId { get; set; }
    }
}
