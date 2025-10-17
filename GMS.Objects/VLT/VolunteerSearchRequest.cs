namespace GMS.Objects.VLT
{
    public class VolunteerSearchRequest
    {
        public int CompanyId { get; set; }
        public int SiteId { get; set; }
        public int? MinAge { get; set; }
        public int? MaxAge { get; set; }

        // Changed to List<int> for multi-selection
        public List<int>? GenderIds { get; set; }
        public List<int>? RaceIds { get; set; }
        public List<int>? EthnicityIds { get; set; }
        public List<int>? LanguageIds { get; set; }
        public List<int>? DiseaseIds { get; set; }

        public string? CurrentStatus { get; set; }
        public bool ExcludeAlreadyAssigned { get; set; }
        public int? StudyId { get; set; }
        public bool? Healthy { get; set; }




    }
}
