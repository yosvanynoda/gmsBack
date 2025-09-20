namespace GMS.DBModels.CMN
{
    public class CMNSites
    {
        public int SiteId { get; set; }

        public int CompanyId { get; set; }

        public string SiteName { get; set; }

        public string? SiteAddress { get; set; }

        public string? SiteContact { get; set; }

        public string? SitePhone { get; set; }

        public string? SiteEmail { get; set; }

        public string? SiteCode { get; set; }

        public int? UserName { get; set; }

        public bool? Active { get; set; }

        public DateTime? LastUpdateAt { get; set; }

        public CMNSites()
        {
            SiteName = "";
        }
    }
}
