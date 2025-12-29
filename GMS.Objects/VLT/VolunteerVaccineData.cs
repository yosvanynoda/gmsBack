namespace GMS.Objects.VLT
{
    public class VolunteerVaccineData
    {

        public int CompanyId { get; set; } = 0;
       
        public int VId { get; set; } = 0;

        public int VaccineId { get; set; } = 0;

        public string DrogName { get; set; }

        public string DrogDose { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int UserName { get; set; } = 0;

        public bool Active { get; set; }

        public int SiteId { get; set; } = 0;
        

        public VolunteerVaccineData()
        {
            DrogName = "";

            DrogDose = "";
        }
    }
}
