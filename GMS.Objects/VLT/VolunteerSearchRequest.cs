namespace GMS.Objects.VLT
{
    public class VolunteerSearchRequest
    {
        public int CompanyId { get; set; }

        public int SiteId { get; set; }

        // Age filters
        public int? MinAge { get; set; }

        public int? MaxAge { get; set; }

        // Demographic filters
        public int? GenderId { get; set; }

        public int? RaceId { get; set; }

        public int? EthnicityId { get; set; }

        public int? LanguageId { get; set; }

        public string? CurrentStatus { get; set; }

        // Assignment filters
        public bool ExcludeAlreadyAssigned { get; set; } = true;

        public int? StudyId { get; set; }
    }
}
