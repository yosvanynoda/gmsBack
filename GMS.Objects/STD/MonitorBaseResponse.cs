namespace GMS.Objects.STD
{
    public class MonitorBaseResponse
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// FirstName
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// LastName
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Phone
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Role
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// ActionDate
        /// </summary>
        public DateTime ActionDate { get; set; }

        /// <summary>
        /// CompanyId
        /// </summary>
        public int CompanyId { get; set; }


        /// <summary>
        /// CompanyId
        /// </summary>
        public int SiteId { get; set; }

        /// <summary>
        /// StudioName
        /// </summary>
        public string StudioName { get; set; }

        public int StudyId { get; set; }

        public string SponsorName { get; set; }

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
