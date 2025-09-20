using GMS.DBModels.CMN;

namespace GMS.DBModels.STD
{
    public class STDGetStudioData
    {
        public STDGeneralData Header { get; set; }

        public List<STDArms> Arms { get; set; }

        public List<STDMonitor> Monitors { get; set; }

        public List<CMNStaff> Staffs { get; set; }

        public List<STDDocumentation> Documentation { get; set; }

        public List<STDVisitDefinition> VisitDefinition { get; set; }

        public STDGetStudioData()
        {
            Header = new();

            Arms = [];

            Monitors = [];

            Staffs = [];

            Documentation = [];

            VisitDefinition = [];
        }
    }
}
