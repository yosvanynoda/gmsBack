using Newtonsoft.Json;

namespace GMS.Objects.STD
{
    public class STDVisitBaseResponse
    {
        [JsonProperty("visitID")]
        public int VisitID { get; set; }

        [JsonProperty("studyID")]
        public int StudyID { get; set; }

        [JsonProperty("armID")]
        public int? ArmID { get; set; }

        [JsonProperty("armName")]
        public string ArmName { get; set; } = "";

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("dayOffset")]
        public int DayOffset { get; set; }

        [JsonProperty("windowMinus")]
        public int WindowMinus { get; set; }

        [JsonProperty("windowPlus")]
        public int WindowPlus { get; set; }

        [JsonProperty("requiredFlag")]
        public bool RequiredFlag { get; set; }

        [JsonProperty("sortOrder")]
        public int SortOrder { get; set; }

        [JsonProperty("userName")]
        public int UserName { get; set; }

        [JsonProperty("actionDateTime")]
        public DateTime? ActionDateTime { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("lastUpdateAt")]
        public DateTime? LastUpdateAt { get; set; }

        [JsonProperty("companyId")]
        public int? CompanyId { get; set; }

        [JsonProperty("siteId")]
        public int? SiteId { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("dependencyOf")]
        public int? DependencyOf { get; set; }

        [JsonProperty("cost")]
        public double? Cost { get; set; }

        [JsonProperty("visitType")]
        public int? VisitType { get; set; }
    }
}
