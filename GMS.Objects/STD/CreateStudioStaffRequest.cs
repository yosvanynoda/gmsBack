namespace GMS.Objects.STD
{
    public class CreateStudioStaffRequest
    {

        public int StudioId { get; set; } = 0;
        public int StaffId { get; set; } = 0;
        public int RoleId { get; set; } = 0;
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int CompanyId { get; set; } = 0;

        public int SiteId { get; set; } = 0;

        public int UserName { get; set; } = 0;

        public int Action { get; set; } = 0;


    }
}
