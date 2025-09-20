namespace GMS.Objects.STD
{
    public class STDMonitorUDT
    {
        public int STDId { get; set; } = 0;

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Role { get; set; } = string.Empty;

        public int CompanyId { get; set; } = 0;

        public int UserName { get; set; } = 0;

        public bool Active { get; set; } = false;

        public int SiteId { get; set; } = 0;
    }
}
