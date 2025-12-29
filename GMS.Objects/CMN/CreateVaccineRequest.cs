namespace GMS.Objects.CMN
{
    public class CreateVaccineRequest
    {
        public string VaccineName { get; set; } = string.Empty;

        public string VaccineDose { get; set; } = string.Empty;

        public int VaccineId { get; set; } = 0;

        public int CompanyId { get; set; } = 0;             

        public int Action { get; set; } = 0;

        public int Username { get; set; } = 0;
    }
}
