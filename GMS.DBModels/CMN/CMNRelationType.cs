namespace GMS.DBModels.CMN
{
    public class CMNRelationType
    {
        public int Id { get; set; }

        public string RelationType { get; set; }

        public int CompanyId { get; set; }

        public int UserName { get; set; }

        public DateTime ActionDateTime { get; set; }

        public bool Active { get; set; }

        public DateTime? LastUpdateAt { get; set; }

        public CMNRelationType()
        {
            RelationType = "";
        }
    }
}
