namespace GMS.DBModels.CMN
{
    public class CMNTaskType
    {
        public int TaskTypeId { get; set; }

        public string TaskTypeName { get; set; }

        public int? CompanyId { get; set; }

        public int? UserName { get; set; }

        public DateTime ActionDateTime { get; set; }

        public bool? Active { get; set; }

        public DateTime? LastUpdateAt { get; set; }

        public CMNTaskType()
        {
            TaskTypeName = "";
        }
    }
}
