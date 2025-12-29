namespace GMS.Objects.CMN
{
    public class SurgicalBaseResponse
    {
        public int SurgicalId { get; set; }

        public string SurgicalName { get; set; }

        public string SurgicalDose { get; set; }

        public int? Companyid { get; set; }

        public int? UserName { get; set; }

        public DateTime ActionDateTime { get; set; }

        public bool Active { get; set; }

        public DateTime? LastUpdateAt { get; set; }

        public SurgicalBaseResponse()
        {
            SurgicalName = "";

            SurgicalDose = "";
        }
    }
}



