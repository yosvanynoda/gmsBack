namespace GMS.Objects.CMN
{
    public class CreateSiteRequest
    {
        public string SiteName { get; set; } 
        
        public int SiteId { get; set; } 
        
        public string? SiteAddress { get; set; }
        
        public string? SiteContact { get; set; }
        
        public string? SitePhone { get; set; }
        
        public string? SiteEmail { get; set; }
        
        public string? SiteCode { get; set; }
        
        public int CompanyId { get; set; }

        public int Action { get; set; }

        public int Username { get; set; }

        public CreateSiteRequest()
        {
            SiteName = "";

            SiteAddress = "";

            SiteContact = "";

            SitePhone = "";

            SiteEmail = "";

            SiteCode = "";
        }
    }
}
