namespace GMS.Objects.CMN
{
    public class CreateRelationTypeRequest
    {
        public string RelationType { get; set; }

        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int Action { get; set; }

        public int Username { get; set; }

        public CreateRelationTypeRequest()
        {
            RelationType = "";
        }
    }
}





