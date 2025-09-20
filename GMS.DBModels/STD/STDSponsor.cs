namespace GMS.DBModels.STD
{
    /// <summary>
    /// STDSponsor
    /// </summary>
    public class STDSponsor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public DateTime DateCreated { get; set; }
              
        public int CompanyId { get; set; }

        public int? UserName { get; set; }

        public int SiteId { get; set; }

        public string ContactName { get; set; } 

        public string ContactEmail { get; set; }

        public string ContactPhone { get; set; }

        public bool? Active { get; set; }


        public STDSponsor()
        {
            Name = "";

            Type = "";

        }
    }

}
