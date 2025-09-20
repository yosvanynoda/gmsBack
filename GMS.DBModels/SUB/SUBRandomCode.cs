namespace GMS.DBModels.SUB
{
    /// <summary>
    /// SUBRandomCode
    /// </summary>
    public class SUBRandomCode
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// SubjectId
        /// </summary>
        public int SubjectId { get; set; }

        /// <summary>
        /// StudioId
        /// </summary>
        public int StudioId { get; set; }


        /// <summary>
        /// RandomCode
        /// </summary>
        public string RandomCode { get; set; }


        /// <summary>
        /// ActionDate
        /// </summary>
        public DateTime ActionDate { get; set; }


        /// <summary>
        /// CompanyId
        /// </summary>
        public int CompanyId { get; set; }


        /// <summary>
        /// SUBRandomCode
        /// </summary>
        public SUBRandomCode()
        {
            RandomCode = "";


        }
    }

}
