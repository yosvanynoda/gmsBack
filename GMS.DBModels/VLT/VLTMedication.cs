﻿namespace GMS.DBModels.VLT
{
    public class VLTMedication
    {
        public int MedicationId { get; set; }

        public string DrogName { get; set; } = "";

        public string DrogDose { get; set; } = "";

        public string StartDate { get; set; } = "";

        public string? EndDate { get; set; } = "";

        public int VolunteerId { get; set; }

        public int CompanyId { get; set; }

        public int SiteId { get; set; }
    }
}
