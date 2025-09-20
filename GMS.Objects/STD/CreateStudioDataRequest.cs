using GMS.Objects.CMN;

namespace GMS.Objects.STD
{
    public class CreateStudioDataRequest
    {
        public List<STDGeneralDataUDT> STDGeneralData { get; set; } = [];

        public List<CMNDocumentationUDT> STDDocumentation { get; set; } = [];

        public List<CMNValueIntUDT> STDMonitor { get; set; } = [];

        public List<STDProtocolUDT> STDProtocol { get; set; } = [];

        public List<STDArmsUDT> STDArms { get; set; } = [];

        public List<STDVisitUDT> STDVisits { get; set; } = [];

        public int CompanyId { get; set; }

        public int SiteId { get; set; }

        public int Username { get; set; }
    }
}
