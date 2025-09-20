namespace GMS.Objects.CMN
{
    public class CreateDiseaseRequest
    {
        public string DiseaseName { get; set; } = string.Empty;

        public int DiseaseId { get; set; } = 0;

        public int CompanyId { get; set; } = 0;             

        public int Action { get; set; } = 0;

        public int Username { get; set; } = 0;
    }
}
