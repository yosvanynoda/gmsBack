namespace GMS.DBModels.STD
{
    /// <summary>
    /// STDDocumentation
    /// </summary>
    public class STDDocumentation
    {
        public int Id { get; set; }

        public int StudioId { get; set; }

        public string StudioName { get; set; } = "";

        public int DocumentTypeId { get; set; }


        public string DocType { get; set; } = "";

        /// <summary>
        /// DocName
        /// </summary>
        public string DocName { get; set; } = "";

        /// <summary>
        /// DocDate
        /// </summary>
        public DateTime DocDate { get; set; }

        /// <summary>
        /// DocVersion
        /// </summary>
        public string DocVersion { get; set; } = "";

        /// <summary>
        /// DocActive
        /// </summary>
        public bool DocActive { get; set; }

        /// <summary>
        /// Notes
        /// </summary>
        public string Notes { get; set; } = "";

        /// <summary>
        /// CompanyId
        /// </summary>
        public int CompanyId { get; set; }

        public DateTime CreatedAt { get; set; }

        public int UserName { get; set; }

        public Boolean Active { get; set; }

        public int SiteId { get; set; }


    }
}
