﻿namespace GMS.DBModels.VLT
{
    public class VLTDocumentation
    {
        public int DocumentId { get; set; }

        public string DocType { get; set; } = "";

        public string DocName { get; set; } = "";

        public string DocDate { get; set; } = "";

        public string DocVersion { get; set; } = "";

        public string Notes { get; set; } = "";

        public int VolunteerId { get; set; }

        public int? CompanyId { get; set; }

        public int? SiteId { get; set; }
    }
}
