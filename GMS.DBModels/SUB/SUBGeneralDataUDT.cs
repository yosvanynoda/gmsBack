namespace GMS.DBModels.SUB
{
    public class SUBGeneralDataUDT
    {

        public int SubjectId { get; set; }

        public DateTime DateCrated { get; set; }

        public int CompanyId { get; set; }

        public string CurrentStatus { get; set; } = string.Empty;

        public int UserName { get; set; }

        public bool Active { get; set; }

        public int SiteId { get; set; }

        public int VolunteerId { get; set; }

        public int StudyId { get; set; }


    }
}
