using GMS.DBModels.SUB;
using System.Reflection.PortableExecutable;

namespace GMS.DBModels.SUB
{
    /// <summary>
    /// SUBGeneralData
    /// </summary>
    public class SUBSubjectResponse
    {

        public SUBSubject Header { get; set; }

        public List<SUBConsent> Consent { get; set; }

        public List<SUBDeviation> Deviation { get; set; }

        public List<SUBAdverse> Adverse { get; set; }

        public SUBSubjectResponse()
        {
            Header = new();

            Consent = [];

            Deviation = [];

            Adverse = [];
        }

    }
}
