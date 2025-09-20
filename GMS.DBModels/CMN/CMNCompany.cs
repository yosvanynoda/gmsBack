namespace GMS.DBModels.CMN
{
    /// <summary>
    /// CMNCompany
    /// </summary>
    public class CMNCompany
    {
        /// <summary>
        /// CompanyId
        /// </summary>
        public int CompanyId { get; set; }

        /// <summary>
        /// CompanyName
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// CreateDate
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// UserName
        /// </summary>
        public int? UserName { get; set; }

        /// <summary>
        /// Active
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// LastUpdateAt
        /// </summary>
        public DateTime? LastUpdateAt { get; set; }

        /// <summary>
        /// CMNCompany
        /// </summary>
        public CMNCompany()
        {
            CompanyName = "";

            CreateDate = DateTime.Now;

            CompanyId = 0;
        }
    }
}
