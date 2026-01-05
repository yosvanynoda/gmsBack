namespace GMS.Objects.CMN
{
    public class CreateMedicationRequest
    {
        public string MedicationName { get; set; } = string.Empty;       

        public int MedicationId { get; set; } = 0;

        public int CompanyId { get; set; } = 0;             

        public int Action { get; set; } = 0;

        public int Username { get; set; } = 0;
    }
}
