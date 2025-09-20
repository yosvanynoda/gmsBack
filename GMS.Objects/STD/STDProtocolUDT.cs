﻿namespace GMS.Objects.STD
{
    public class STDProtocolUDT
    {
        public string Name { get; set; } = string.Empty;

        public DateTime DateCreated { get; set; } = DateTime.MinValue;

        public string Version { get; set; } = string.Empty;

        public int CompanyId { get; set; } = 0;

        public int UserName { get; set; } = 0;

        public int SiteId { get; set; } = 0;

        public string Notes { get; set; } = string.Empty;

        public DateTime StartDate { get; set; } = DateTime.MinValue;

        public DateTime EndDate { get; set; } = DateTime.MinValue;

        public int NumVisit { get; set; } = 0;

        public DateTime ApprovedDate { get; set; } = DateTime.MinValue;

        public int StudyId { get; set; } = 0;
    }
}
