namespace GMS.DBModels.SUB
{
    /// <summary>
    /// SUBGeneralData
    /// </summary>
    public class SUBGeneralData
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
        /// SubjectDOB
        /// </summary>
        public DateTime SubjectDOB { get; set; }

        /// <summary>
        /// SubjectSS
        /// </summary>
        public string SubjectSS { get; set; }

        /// <summary>
        /// Phone
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// AddressId
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// SubjectEmail
        /// </summary>
        public string SubjectEmail { get; set; }

        /// <summary>
        /// SubjectId
        /// </summary>
        public string SubjectId { get; set; }

        /// <summary>
        /// DateCreated
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// CompanyId
        /// </summary>
        public int CompanyId { get; set; }

        /// <summary>
        /// SUBGeneralData
        /// </summary>
        public SUBGeneralData()
        {
            FirstName = "";

            LastName = "";

            SubjectSS = "";

            Phone = "";

            SubjectEmail = "";

            SubjectId = "";


        }

    }
}
