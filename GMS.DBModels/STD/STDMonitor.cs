using System.ComponentModel.DataAnnotations;

namespace GMS.DBModels.STD
{
    /// <summary>
    /// STDMonitor
    /// </summary>
    public class STDVisitDefinition
    {
   
        public int VisitID { get; set; }

       public int StudyID { get; set; }

        public int? ArmID { get; set; }

        public string Name { get; set; }

        public int DayOffset { get; set; }

        public int WindowMinus { get; set; }

        public int WindowPlus { get; set; }

        public bool RequiredFlag { get; set; }

        public int SortOrder { get; set; }

        public int UserName { get; set; }

        public DateTime? ActionDateTime { get; set; }

        public bool Active { get; set; }

        public DateTime? LastUpdateAt { get; set; }

        public int? CompanyId { get; set; }

        public int? SiteId { get; set; }
        
        
        public STDVisitDefinition()
        {
            Name = "";         

        }

    }
}
