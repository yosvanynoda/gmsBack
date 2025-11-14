namespace GMS.Objects.VLT
{
    public class VolunteerDocumentationData
    {
        public int VId { get; set; } = 0;

        public int DocumentId { get; set; } = 0;

        public int DocumentTypeId { get; set; } = 0;

        public string DocName { get; set; }

        public DateTime DocDate { get; set; }

        public string DocVersion { get; set; }

        public bool DocActive { get; set; }

        public string Notes { get; set; }

        public int CompanyId { get; set; } = 0;

        public int UserName { get; set; } = 0;

        public bool Active { get; set; }

        public int SiteId { get; set; } = 0;
        
        public VolunteerDocumentationData()
        {
            DocName = "";

            DocVersion = "";

            Notes = "";
        }
    }
}
