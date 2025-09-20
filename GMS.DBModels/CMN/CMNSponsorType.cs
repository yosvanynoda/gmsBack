namespace GMS.DBModels.CMN
{
    /// <summary>
    /// CMNSponsorType
    /// </summary>
    public class CMNSponsorType
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public string SponsorType { get; set; }

        /// <summary>
        /// CompanyId
        /// </summary>
        public int CompanyId { get; set; }

        public int? UserName { get; set; }

        public DateTime ActionDateTime { get; set; }

        public bool? Active { get; set; }

        public DateTime? LastUpdateAt { get; set; }

        /// <summary>
        /// CMNSponsorType
        /// </summary>
        public CMNSponsorType()
        {
            SponsorType = "";
        }
    }
}
