using System;
using System.Xml.Linq;

namespace GMS.DBModels.STD
{
    /// <summary>
    /// STDProtocol
    /// </summary>
    public class STDArms
    {

               

        public int ArmId { get; set; }

        public int StudyID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int TargetEnrollment { get; set; }

        public string DoseLevel { get; set; }       

        public int? UserName { get; set; }

        public DateTime ActionDateTime { get; set; }

       public bool? Active { get; set; }

        public DateTime? LastUpdateAt { get; set; }

        public STDArms()
        {
            Name = "";          
            
        }
    }

}
