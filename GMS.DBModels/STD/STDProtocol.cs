using Newtonsoft.Json;

namespace GMS.DBModels.STD
{
    /// <summary>
    /// STDProtocol
    /// </summary>
    public class STDProtocol
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        public string Protocol { get; set; }

        [JsonProperty("name")]
        public string Name => Protocol;

        [JsonProperty("dateCreated")]
        public DateTime DateCreated { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("userName")]
        public int? UserName { get; set; }

        [JsonProperty("actionDateTime")]
        public DateTime ActionDateTime { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("lastUpdateAt")]
        public DateTime? LastUpdateAt { get; set; }

        [JsonProperty("siteId")]
        public int SiteId { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("startDate")]
        public DateTime? StartDate { get; set; }

        [JsonProperty("endDate")]
        public DateTime? EndDate { get; set; }

        [JsonProperty("numVisit")]
        public int NumVisit { get; set; }

        [JsonProperty("studyId")]
        public int StudyId { get; set; }

        [JsonProperty("approvedDate")]
        public DateTime? ApprovedDate { get; set; }


        public STDProtocol()
        {
            Protocol = "";
           
            Version = "";
        }
    }

}
