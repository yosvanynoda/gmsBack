namespace GMS.DBModels.CMN
{
    public class CMNStaffDocument
    {
        public int DocumentId { get; set; }

        public string DocType { get; set; } = "";

        public string DocName { get; set; } = "";

        public string DocDate { get; set; } = "";

        public string DocVersion { get; set; } = "";

        public string Notes { get; set; } = "";

        public int StaffId { get; set; }

        public int? CompanyId { get; set; }

        public int? SiteId { get; set; }
    }
}
