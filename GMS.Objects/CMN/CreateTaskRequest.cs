namespace GMS.Objects.CMN
{
    public class CreateTaskRequest
    {
        public string TaskName { get; set; }

        public int TaskId { get; set; }

        public int TaskTypeId { get; set; }

        public int CompanyId { get; set; }

        public int Action { get; set; }

        public int Username { get; set; }

        public CreateTaskRequest()
        {
            TaskName = "";
        }
    }
}
