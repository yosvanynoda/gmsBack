﻿namespace GMS.Objects.CMN
{
    public class DeviationBaseResponse
    {
        public int DeviationId { get; set; }

        public string DeviationName { get; set; }

        public int? Companyid { get; set; }

        public int? UserName { get; set; }

        public DateTime ActionDateTime { get; set; }

        public bool Active { get; set; }

        public DateTime? LastUpdateAt { get; set; }

        public string DeviationCode { get; set; }

        public DeviationBaseResponse()
        {
            DeviationName = "";
            DeviationCode = "";
        }
    }
}



