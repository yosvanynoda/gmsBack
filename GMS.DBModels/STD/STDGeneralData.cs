using System.Numerics;
using static System.Net.Mime.MediaTypeNames;

namespace GMS.DBModels.STD
{
    public class STDGeneralData
    {

        
        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Notes { get; set; }

        public int SponsorId { get; set; }     

        public string SponsorName { get; set; }

        public int CompanyId { get; set; }

        public int ProtocolId { get; set; }

        public string ProtocolName { get; set; }

        public bool Active { get; set; }

        public int SiteId { get; set; }

        public string SiteName { get; set; }

        public string StudioStatus { get; set; }

        public int Goal { get; set; }

        public DateTime DateCreated { get; set; }

        public int Phase { get; set; }

        public string Indication { get; set; }

        public string TherapeuticArea { get; set; }

        public int BlindType { get; set; }

        public int RandomizationType { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int CroId { get; set; }

        public STDGeneralData()
        {
            Code = "";

            Name = "";

            Description = "";


        }
    }
}
