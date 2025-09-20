namespace GMS.DBModels.STD
{
    /// <summary>
    /// STDProtocol
    /// </summary>
    public class STDProtocol
    {
        public int Id { get; set; }
        
        public string Protocol { get; set; }
        
        public DateTime DateCreated { get; set; }
        
        public string Version { get; set; }

        public int CompanyId { get; set; }

        public int? UserName { get; set; }

        public DateTime ActionDateTime { get; set; }

        public bool? Active { get; set; }

        public DateTime? LastUpdateAt { get; set; }

        public int SiteId { get; set; }

        public string Notes { get; set; }
        
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }



        public STDProtocol()
        {
            Protocol = "";
           
            Version = "";
        }
    }

}
