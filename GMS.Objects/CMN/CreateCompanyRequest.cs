namespace GMS.Objects.CMN
{
    public class CreateCompanyRequest
    {
        /// <summary>
        /// CompanyName
        /// </summary>
        public string CompanyName { get; set; }

        public int CompanyId { get; set; }

        public int Action { get; set; }

        public int Username { get; set; }

       
        public CreateCompanyRequest()
        {
            CompanyName = "";
        }
    }
}
