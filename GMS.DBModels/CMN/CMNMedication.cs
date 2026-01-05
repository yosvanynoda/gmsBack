namespace GMS.DBModels.CMN
{
    public class CMNMedication
    {
        public int MedicationId { get; set; }
        public string MedicationName { get; set; }       
        public int? Companyid { get; set; }
        public int? UserName { get; set; }
        public DateTime ActionDateTime { get; set; }
        public bool Active { get; set; }
        public DateTime? LastUpdateAt { get; set; }

        public CMNMedication()
        {
            MedicationName = "";
            
        }
    }
}
