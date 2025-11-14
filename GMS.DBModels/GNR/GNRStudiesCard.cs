using GMS.DBModels.STD;
using GMS.Objects.GNR;
using System.Reflection.PortableExecutable;
using System.Threading;

namespace GMS.DBModels.GNR

{
    public class GNRStudiesCard
    {

        public GNRStudiesCardHeader Header { get; set; }

        public List<GNRStudyStatusCount> StatusCounts { get; set; }

        public GNRStudiesCard()
        {

            Header = new();

            StatusCounts = [];
                        
        }

    }
}
