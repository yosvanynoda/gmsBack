namespace GMS.Objects.STD
{
    public class StudioBaseResponse
    {
        public int Id { get; set; }

        public string Code { get; set; }      

        public string Name { get; set; }

        public string Description { get; set; }
        
        public int SponsorId { get; set; }

        public string SponsorName { get; set; }

        public int CompanyId { get; set; }

        public int ProtocolId { get; set; }

        public string ProtocolName { get; set; }

        public bool Active { get; set; }

        public int SiteId { get; set; }

        public string StatusId { get; set; }

        public int Goal { get; set; }

        public int Screened { get; set; }

        public int  Randomizations { get; set; }

        public int Failed { get; set; }





        public StudioBaseResponse()
        {
            Code = "";  

            Name = "";  

            Description = "";

           

        }

    }
}
