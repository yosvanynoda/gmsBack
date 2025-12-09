using Newtonsoft.Json;

namespace GMS.Objects.STD
{
    public class ProtocolBaseResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        [JsonProperty("dateCreated")]
        public DateTime DateCreated { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("userName")]
        public int UserName { get; set; }

        [JsonProperty("actionDateTime")]
        public DateTime ActionDateTime { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("lastUpdatedAt")]
        public DateTime LastUpdatedAt { get; set; }

        [JsonProperty("siteId")]
        public int SiteId { get; set; }

        [JsonProperty("studioName")]
        public string StudioName { get; set; }

        [JsonProperty("startDate")]
        public DateTime? StartDate { get; set; }

        [JsonProperty("endDate")]
        public DateTime? EndDate { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; } = "";

        [JsonProperty("numVisit")]
        public int NumVisit { get; set; }

        [JsonProperty("approvedDate")]
        public DateTime? ApprovedDate { get; set; }

        [JsonProperty("studyId")]
        public int StudyId { get; set; }


        public ProtocolBaseResponse()
        {
            Protocol = "";

            Version = "";

            StudioName = "";
        }
    }
}
