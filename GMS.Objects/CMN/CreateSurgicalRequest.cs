namespace GMS.Objects.CMN
{
    public class CreateSurgicalRequest
    {
        public string SurgicalName { get; set; } = string.Empty;

        public string SurgicalDose { get; set; } = string.Empty;

        public int SurgicalId { get; set; } = 0;

        public int CompanyId { get; set; } = 0;             

        public int Action { get; set; } = 0;

        public int Username { get; set; } = 0;
    }
}
