namespace GMS.Objects.CMN
{
    public class RelationTypeBaseResponse
    {
        public int Id { get; set; }

        public string RelationType { get; set; }

        public int? Companyid { get; set; }

        public int? UserName { get; set; }

        public DateTime ActionDateTime { get; set; }

        public bool Active { get; set; }

        public DateTime? LastUpdateAt { get; set; }

        public RelationTypeBaseResponse()
        {
            RelationType = "";

        }
    }
}
