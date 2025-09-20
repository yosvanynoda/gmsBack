namespace GMS.Objects.STD
{
    public class StudioDocBaseResponse
    {
        //int studioId, string name, int typeId, DateTime docDate, string version, string notes, int companyId

        public int Id { get; set; }
        
        public int StudioId { get; set; } = 0;

        public string DocName { get; set; } = string.Empty;

        public int TypeId { get; set; } = 0;

        public DateTime DocDate { get; set; } = DateTime.Now;

        public string Version { get; set; } = string.Empty;

        public string Notes { get; set; } = string.Empty;

        public int CompanyId { get; set; } = 0;

        public int UserName { get; set; }

        public int Action { get; set; }

        public int SiteId { get; set; }

        public string StudioName { get; set; } = string.Empty;

        public int DocumentTypeId { get; set; }

        public string DocType { get; set; } = string.Empty;


        public string DocVersion { get; set; } = string.Empty;

       
        public bool DocActive { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool Active { get; set; }
       
    }
}
