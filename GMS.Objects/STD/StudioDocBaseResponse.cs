using Newtonsoft.Json;

namespace GMS.Objects.STD
{
    public class StudioDocBaseResponse
    {
        //int studioId, string name, int typeId, DateTime docDate, string version, string notes, int companyId

        [JsonProperty("vId")]
        public int Id { get; set; }

        [JsonProperty("studioId")]
        public int StudioId { get; set; } = 0;

        [JsonProperty("docName")]
        public string DocName { get; set; } = string.Empty;

        [JsonProperty("typeId")]
        public int TypeId { get; set; } = 0;

        [JsonProperty("docDate")]
        public DateTime DocDate { get; set; } = DateTime.Now;

        [JsonProperty("version")]
        public string Version { get; set; } = string.Empty;

        [JsonProperty("notes")]
        public string Notes { get; set; } = string.Empty;

        [JsonProperty("companyId")]
        public int CompanyId { get; set; } = 0;

        [JsonProperty("userName")]
        public int UserName { get; set; }

        [JsonProperty("action")]
        public int Action { get; set; }

        [JsonProperty("siteId")]
        public int SiteId { get; set; }

        [JsonProperty("studioName")]
        public string StudioName { get; set; } = string.Empty;

        [JsonProperty("documentTypeId")]
        public int DocumentTypeId { get; set; }

        [JsonProperty("docTypeName")]
        public string DocType { get; set; } = string.Empty;


        [JsonProperty("docVersion")]
        public string DocVersion { get; set; } = string.Empty;


        [JsonProperty("docActive")]
        public bool DocActive { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("docPath")]
        public string DocPath { get; set; } = string.Empty;
       
    }
}
