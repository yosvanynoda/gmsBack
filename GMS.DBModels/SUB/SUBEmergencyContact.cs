namespace GMS.DBModels.SUB
{
    /// <summary>
    /// SUBEmergencyContact
    /// </summary>
    public class SUBEmergencyContact
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
        /// ContactName
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// ContactPhone
        /// </summary>
        public string ContactPhone { get; set; }

        /// <summary>
        /// ContactRelation
        /// </summary>
        public int ContactRelation { get; set; }

        /// <summary>
        /// CompanyId
        /// </summary>
        public int CompanyId { get; set; }

        /// <summary>
        /// ActionDate
        /// </summary>
        public DateTime ActionDate { get; set; }

        /// <summary>
        /// SUBEmergencyContact
        /// </summary>
        public SUBEmergencyContact()
        {
            ContactName = "";

            ContactPhone = "";

        }
    }
}
