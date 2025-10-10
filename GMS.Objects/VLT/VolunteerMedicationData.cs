﻿namespace GMS.Objects.VLT
{
    public class VolunteerMedicationData
    {

        public int CompanyId { get; set; } = 0;
       
        public int VId { get; set; } = 0;

        public int MedicationId { get; set; } = 0;

        public string DrogName { get; set; }

        public string DrogDose { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int UserName { get; set; } = 0;

        public bool Active { get; set; }

        public int SiteId { get; set; } = 0;
        

        public VolunteerMedicationData()
        {
            DrogName = "";

            DrogDose = "";
        }
    }
}
