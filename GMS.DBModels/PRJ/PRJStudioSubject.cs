namespace GMS.DBModels.PRJ
{
    /// <summary>
    /// PRJStudioSubject
    /// </summary>
    public class PRJStudioSubject
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
        /// SubjectId
        /// </summary>
        public int SubjectId { get; set; }

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
