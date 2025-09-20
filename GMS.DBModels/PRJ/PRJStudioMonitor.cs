namespace GMS.DBModels.PRJ
{
    /// <summary>
    /// PRJStudioMonitor
    /// </summary>
    public class PRJStudioMonitor
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// StudioId
        /// </summary>
        public int StudioId { get; set; }

        /// <summary>
        /// MonitorId
        /// </summary>
        public int MonitorId { get; set; }

        /// <summary>
        /// StartDate
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// EndDate
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// CompanyId
        /// </summary>
        public int CompanyId { get; set; }
    }
}
