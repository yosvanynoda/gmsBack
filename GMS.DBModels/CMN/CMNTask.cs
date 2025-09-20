namespace GMS.DBModels.CMN
{
    public class CMNTask
    {
        public int TaskId { get; set; }

        public string TaskName { get; set; }

        public int TaskTypeId { get; set; }

        public int? CompanyId { get; set; }

        public int? UserName { get; set; }

        public DateTime ActionDateTime { get; set; }

        public bool? Active { get; set; }

        public DateTime? LastUpdateAt { get; set; }

        public string TaskTypeName { get; set; }

        public CMNTask()
        {
            TaskName = "";

            TaskTypeName = "";

        }
    }
}
