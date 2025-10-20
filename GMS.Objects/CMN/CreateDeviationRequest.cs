namespace GMS.Objects.CMN
{
    public class CreateDeviationRequest
    {
        public string DeviationName { get; set; } = string.Empty;

        public int DeviationId { get; set; } = 0;

        public int CompanyId { get; set; } = 0;             

        public int Action { get; set; } = 0;

        public int Username { get; set; } = 0;

        public string DeviationCode { get; set; } = string.Empty;
    }
}
