namespace GMS.Objects.STD
{
    public class PreAssignVolunteersToStudyRequest
    {
        public int CompanyId { get; set; }

        public int SiteId { get; set; }

        public int StudyId { get; set; }

        public List<int> VolunteerIds { get; set; } = [];

        public int Username { get; set; }
    }
}
