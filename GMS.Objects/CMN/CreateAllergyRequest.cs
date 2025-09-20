namespace GMS.Objects.CMN
{
    public class CreateAllergyRequest
    {
        public string Allergy { get; set; }

        public string? Comment { get; set; }

        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int Action { get; set; }

        public int Username { get; set; }

        public CreateAllergyRequest()
        {
            Allergy = "";

        }
    }
}
