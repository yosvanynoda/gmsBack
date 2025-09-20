namespace GMS.DBModels.CMN
{
    /// <summary>
    /// CMNDocType
    /// </summary>
    public class CMNDocType
    {
        public int Id { get; set; }
        
        public string DocType { get; set; }

        public string Comment { get; set; }

        public int ApplyFor { get; set; }

        public int CompanyId { get; set; }

        public int? UserName { get; set; }
        public DateTime ActionDateTime { get; set; }
        public bool? Active { get; set; }
        public DateTime? LastUpdateAt { get; set; }

        /// <summary>
        /// CMNDocType
        /// </summary>
        public CMNDocType()
        {
            DocType = "";

            Comment = "";
        }
    }
}
