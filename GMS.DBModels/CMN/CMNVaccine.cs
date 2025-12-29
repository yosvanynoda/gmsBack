namespace GMS.DBModels.CMN
{
    public class CMNVaccine
    {
        public int VaccineId { get; set; }
        public string VaccineName { get; set; }
        public string VaccineDose { get; set; }
        public int? Companyid { get; set; }
        public int? UserName { get; set; }
        public DateTime ActionDateTime { get; set; }
        public bool Active { get; set; }
        public DateTime? LastUpdateAt { get; set; }

        public CMNVaccine()
        {
            VaccineName = "";

            VaccineDose = "";
        }
    }
}
