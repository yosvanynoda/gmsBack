namespace GMS.DBModels.CMN
{
    public class CMNStaffStudio
    {
        public int Id { get; set; }
        public int StudioId { get; set; }
        public int StaffId { get; set; }
        public int RoleId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int CompanyId { get; set; }
        public int UserName { get; set; }
        public DateTime ActionDateTime { get; set; }
        public bool Active { get; set; }
        public DateTime? LastUpdateAt { get; set; }
        public int SiteId { get; set; }

        // Joined fields from the SP
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty; // Studio name
        public string RoleType { get; set; } = string.Empty;
    }
}
