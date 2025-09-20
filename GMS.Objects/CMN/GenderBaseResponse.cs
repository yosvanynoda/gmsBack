namespace GMS.Objects.CMN
{
    public class GenderBaseResponse
    {
        public int Id { get; set; }

        public string Gender { get; set; }

        public string? Comment { get; set; }

        public int CompanyId { get; set; }

        public int? UserName { get; set; }

        public DateTime ActionDateTime { get; set; }

        public bool? Active { get; set; }

        public DateTime? LastUpdateAt { get; set; }

        public GenderBaseResponse()
        {
            Gender = "";
        }
    }
}
