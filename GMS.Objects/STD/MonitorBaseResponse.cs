using Newtonsoft.Json;

namespace GMS.Objects.STD
{
    public class MonitorBaseResponse
    {
        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("monitorId")]
        public int Id { get; set; }

        /// <summary>
        /// FirstName
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// LastName
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Phone
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Role
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; }

        /// <summary>
        /// ActionDate
        /// </summary>
        [JsonProperty("actionDate")]
        public DateTime ActionDate { get; set; }

        /// <summary>
        /// CompanyId
        /// </summary>
        [JsonProperty("companyId")]
        public int CompanyId { get; set; }


        /// <summary>
        /// CompanyId
        /// </summary>
        [JsonProperty("siteId")]
        public int SiteId { get; set; }

        /// <summary>
        /// StudioName
        /// </summary>
        [JsonProperty("studioName")]
        public string StudioName { get; set; }

        [JsonProperty("studyId")]
        public int StudyId { get; set; }

        [JsonProperty("sponsorName")]
        public string SponsorName { get; set; }

        [JsonProperty("monitorName")]
        public string MonitorName => $"{FirstName} {LastName}";

        public MonitorBaseResponse()
        {
            FirstName = "";

            LastName = "";

            Email = "";

            Phone = "";

            Role = "";

            StudioName = "";

            SponsorName = "";

        }
    }
}
