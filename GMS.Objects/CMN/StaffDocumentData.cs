namespace GMS.Objects.CMN
{
    public class StaffDocumentData
    {
        public int StaffId { get; set; } = 0;

        public int DocumentTypeId { get; set; } = 0;

        public string DocumentName { get; set; }

        public DateTime DocumentDate { get; set; }

        public string DocumentVersion { get; set; }

        public bool DocumentActive { get; set; }

        public string DocumentNotes { get; set; }

        public int CompanyId { get; set; } = 0;

        public int UserName { get; set; } = 0;

        public bool Active { get; set; }

        public int SiteId { get; set; } = 0;

        public StaffDocumentData()
        {
            DocumentName = "";

            DocumentVersion = "";

            DocumentNotes = "";
        }
        
    }
}
