namespace GMS.DBModels.STD
{
    /// <summary>
    /// STDProtocol
    /// </summary>
    public class STDGetProtocolVersionList
    {
        public int Id { get; set; }
        
        public string Protocol { get; set; } = "";        
              
        public string Version { get; set; } = "";       

        public string Notes { get; set; } = "";
        
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

    }

}
