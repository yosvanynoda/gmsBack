namespace GMS.Objects.VLT
{
    public class CreateVolunteerDataRequest
    {
        public List<VolunteerGeneralData> VolunteerGeneralData { get; set; } = [];

        public List<VolunteerAllergyData> VolunteerAllergyData { get; set; } = [];

        public List<VolunteerDeseaseData> VolunteerDiseaseData { get; set; } = [];

        public List<VolunteerDocumentationData> VolunteerDocumentationData { get; set; } = [];

        public List<VolunteerEmergencyContactData> VolunteerEmergencyContactData { get; set; } = [];

        public List<VolunteerMedicationData> VolunteerMedicationData { get; set; } = [];

        public List<VolunteerVaccineData> VolunteerVaccineData { get; set; } = [];

        public List<VolunteerSurgicalData> VolunteerSurgicalData { get; set; } = [];
    }
}
