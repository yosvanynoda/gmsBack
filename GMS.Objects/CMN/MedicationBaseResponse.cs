namespace GMS.Objects.CMN
{
    public class MedicationBaseResponse
    {
        public int MedicationId { get; set; }

        public string MedicationName { get; set; }

        public string MedicationDose { get; set; }

        public int? Companyid { get; set; }

        public int? UserName { get; set; }

        public DateTime ActionDateTime { get; set; }

        public bool Active { get; set; }

        public DateTime? LastUpdateAt { get; set; }

        public MedicationBaseResponse()
        {
            MedicationName = "";

            MedicationDose = "";
        }
    }
}



