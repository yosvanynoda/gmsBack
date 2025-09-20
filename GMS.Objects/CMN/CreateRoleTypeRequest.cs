namespace GMS.Objects.CMN
{
    public class CreateRoleTypeRequest
    {
        public string RoleTypeName { get; set; }

        public int RoleTypeId { get; set; }

        public int CompanyId { get; set; }

        public int Action { get; set; }

        public int Username { get; set; }

        public CreateRoleTypeRequest()
        {
            RoleTypeName = "";
        }
    }
}





