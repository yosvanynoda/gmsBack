namespace GMS.Objects.STD
{
    public class CreateStudioDocRequest
    {
        //int studioId, string name, int typeId, DateTime docDate, string version, string notes, int companyId

        public int Id { get; set; }
        
        public int StudioId { get; set; } = 0;

        public string Name { get; set; } = string.Empty;

        public int TypeId { get; set; } = 0;

        public DateTime DocDate { get; set; } = DateTime.Now;

        public string Version { get; set; } = string.Empty;

        public string Notes { get; set; } = string.Empty;

        public int CompanyId { get; set; } = 0;

        public int UserName { get; set; }

        public int Action { get; set; }

        public int SiteId { get; set; }

        public int Username { get; set; }




    }
}
