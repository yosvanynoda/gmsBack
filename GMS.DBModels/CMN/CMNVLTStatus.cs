﻿namespace GMS.DBModels.CMN
{
    public class CMNVLTStatus
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// DocType
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// CompanyId
        /// </summary>
        public int CompanyId { get; set; }

        public int? UserName { get; set; }

        public DateTime ActionDateTime { get; set; }

        public bool? Active { get; set; }

        public DateTime? LastUpdateAt { get; set; }

        public CMNVLTStatus()
        {
            Name = "";

            Comment = "";
        }
    }
}
