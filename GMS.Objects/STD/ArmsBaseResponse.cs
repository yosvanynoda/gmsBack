using Newtonsoft.Json;

namespace GMS.Objects.STD
{
    public class ArmsBaseResponse
    {
        [JsonProperty("armID")]
        public int ArmId { get; set; }

        [JsonProperty("studyID")]
        public int StudyID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = "";

        [JsonProperty("description")]
        public string Description { get; set; } = "";

        [JsonProperty("targetEnrollment")]
        public int TargetEnrollment { get; set; }

        [JsonProperty("doseLevel")]
        public string DoseLevel { get; set; } = "";

        [JsonProperty("userName")]
        public int? UserName { get; set; }

        [JsonProperty("actionDateTime")]
        public DateTime ActionDateTime { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("lastUpdateAt")]
        public DateTime? LastUpdateAt { get; set; }
    }
}
