namespace GMS.Objects.CMN
{
    public class CreateTaskTypeRequest
    {
        public string TaskTypeName { get; set; }

        public int TaskTypeId { get; set; } = 0;

        public int CompanyId { get; set; } = 0;

        public int Action { get; set; } = 0;

        public int Username { get; set; } = 0;

        public CreateTaskTypeRequest()
        {
            TaskTypeName = "";
        }
    }
}
