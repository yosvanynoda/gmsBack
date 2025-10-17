namespace GMS.DBModels.VLT
{
    public class VLTVolunteerHistoryResponse
    {
       

        public List<VLTStudies> Studies { get; set; }

        public List<VLTSelections> Selections { get; set; }

       

        public VLTVolunteerHistoryResponse()
        {


            Studies = [];

            Selections = [];

            
        }
    }
}
