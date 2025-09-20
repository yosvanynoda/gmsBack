namespace GMS.Objects.STD
{
    public class SubjectBaseResponse
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime SubjectDOB { get; set; }

        public string SubjectSS { get; set; }

        public string Phone { get; set; }

        public int AddressId { get; set; }

        public string SubjectEmail { get; set; }

        public int SubjectId { get; set; }

        public DateTime DateCreated { get; set; }

        public int CompanyId { get; set; }

        public string CurrentStatus { get; set; }

        public string Weight { get; set; }

        public string Height { get; set; }

        public string LegalRepresentative { get; set; }

        public int UserName { get; set; }

        public DateTime ActionDateTime { get; set; }

        public bool Active { get; set; }

        public DateTime LastUpdatedAt { get; set; }

        public int SiteId { get; set; }

        public string SiteName { get; set; }

        public SubjectBaseResponse()
        {
            FirstName = "";

            LastName = "";

            SubjectSS = "";

            Phone = "";

            SubjectEmail = "";

            CurrentStatus = "";

            Weight = "";

            Height = "";

            LegalRepresentative = "";

            SiteName = "";
        }
    }
}
