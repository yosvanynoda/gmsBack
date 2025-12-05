using Newtonsoft.Json;

namespace GMS.DBModels.STD
{
    /// <summary>
    /// STDDocumentation
    /// </summary>
    public class STDDocumentation
    {
        [JsonProperty("vId")]
        public int Id { get; set; }

        [JsonProperty("studioId")]
        public int StudioId { get; set; }

        [JsonProperty("studioName")]
        public string StudioName { get; set; } = "";

        [JsonProperty("documentTypeId")]
        public int DocumentTypeId { get; set; }

        [JsonProperty("docTypeName")]
        public string DocType { get; set; } = "";

        /// <summary>
        /// DocName
        /// </summary>
        [JsonProperty("docName")]
        public string DocName { get; set; } = "";

        /// <summary>
        /// DocDate
        /// </summary>
        [JsonProperty("docDate")]
        public DateTime DocDate { get; set; }

        /// <summary>
        /// DocVersion
        /// </summary>
        [JsonProperty("docVersion")]
        public string DocVersion { get; set; } = "";

        /// <summary>
        /// DocActive
        /// </summary>
        [JsonProperty("docActive")]
        public bool DocActive { get; set; }

        /// <summary>
        /// Notes
        /// </summary>
        [JsonProperty("notes")]
        public string Notes { get; set; } = "";

        /// <summary>
        /// CompanyId
        /// </summary>
        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("userName")]
        public int UserName { get; set; }

        [JsonProperty("active")]
        public Boolean Active { get; set; }

        [JsonProperty("siteId")]
        public int SiteId { get; set; }

        [JsonProperty("docPath")]
        public string DocPath { get; set; } = "";

    }
}
