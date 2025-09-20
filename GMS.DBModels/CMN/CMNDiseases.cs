namespace GMS.DBModels.CMN
{
    public class CMNDiseases
    {
        public int DiseaseId { get; set; }
        public string DiseaseName { get; set; }
        public int? Companyid { get; set; }
        public int? UserName { get; set; }
        public DateTime ActionDateTime { get; set; }
        public bool Active { get; set; }
        public DateTime? LastUpdateAt { get; set; }

        public CMNDiseases()
        {
            DiseaseName = "";
        }
    }
}
