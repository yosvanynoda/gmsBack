using GMS.Objects.STD;
using Newtonsoft.Json;
using System.Runtime.Intrinsics.Arm;

namespace GMS.Objects.API
{
    public class StudioDataResponse
    {
        [JsonProperty("header")]
        public StudioHeader? Header { get; set; }

        [JsonProperty("monitors")]
        public List<MonitorBaseResponse>? Monitors { get; set; }

        [JsonProperty("protocol")]
        public List<ProtocolBaseResponse>? Protocol { get; set; }

        [JsonProperty("arms")]
        public List<ArmsBaseResponse>? Arms { get; set; }

        [JsonProperty("documentation")]
        public List<StudioDocBaseResponse>? Documentation { get; set; }

        [JsonProperty("visitDefinition")]
        public List<STDVisitBaseResponse>? VisitDefinition { get; set; }
    }

    public class StudioHeader
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; } = "";

        [JsonProperty("sponsorId")]
        public int SponsorId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = "";

        [JsonProperty("description")]
        public string Description { get; set; } = "";

        [JsonProperty("notes")]
        public string Notes { get; set; } = "";

        [JsonProperty("dateCreated")]
        public DateTime DateCreated { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("sponsorName")]
        public string SponsorName { get; set; } = "";

        [JsonProperty("protocolId")]
        public int ProtocolId { get; set; }

        [JsonProperty("protocolName")]
        public string ProtocolName { get; set; } = "";

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("siteId")]
        public int SiteId { get; set; }

        [JsonProperty("siteName")]
        public string SiteName { get; set; } = "";

        [JsonProperty("studioStatus")]
        public string StudioStatus { get; set; } = "";

        [JsonProperty("goal")]
        public int Goal { get; set; }

        [JsonProperty("phase")]
        public int Phase { get; set; }

        [JsonProperty("indication")]
        public string Indication { get; set; } = "";

        [JsonProperty("therapeuticArea")]
        public string TherapeuticArea { get; set; } = "";

        [JsonProperty("blindType")]
        public int BlindType { get; set; }

        [JsonProperty("randomizationType")]
        public int RandomizationType { get; set; }

        [JsonProperty("startDate")]
        public DateTime? StartDate { get; set; }

        [JsonProperty("endDate")]
        public DateTime? EndDate { get; set; }

        [JsonProperty("croId")]
        public int CroId { get; set; }

        [JsonProperty("diseaseId")]
        public int DiseaseId { get; set; }
    }
}
