namespace GMS.Objects.CMN
{
    public class AllergyBaseResponse
    {
        public int Id { get; set; }

        public string Allergy { get; set; }

        public string Comment { get; set; }

        public int? Companyid { get; set; }

        public int? UserName { get; set; }

        public DateTime ActionDateTime { get; set; }

        public bool Active { get; set; }

        public DateTime? LastUpdateAt { get; set; }

        public AllergyBaseResponse()
        {
            Allergy = "";

            Comment = "";
        }
    }
}
