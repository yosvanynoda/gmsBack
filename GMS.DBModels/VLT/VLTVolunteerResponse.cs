namespace GMS.DBModels.VLT
{
    public class VLTVolunteerResponse
    {
        public VLTVolunteerData Header { get; set; }

        public List<VLTEmergencyContact> EmergencyContacts { get; set; }

        public List<VLTDocumentation> Documentations { get; set; }

        public List<VLTAllergy> Allergies { get; set; }

        public List<VLTDisease> Diseases { get; set; }

        public List<VLTMedication> Medications { get; set; }

        public VLTVolunteerResponse()
        {
            Header = new();

            EmergencyContacts = [];

            Documentations = [];

            Allergies = [];

            Diseases = [];

            Medications = [];
        }
    }
}
