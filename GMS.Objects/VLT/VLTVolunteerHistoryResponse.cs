namespace GMS.Objects.VLT
{
    public class VLTVolunteerHistoryResponse
    {
        public List<VolunteerStudiesData> Studies { get; set; }
        public List<VolunteerSelectionsData> Selections { get; set; }

        public VLTVolunteerHistoryResponse()
        {
            Studies = new List<VolunteerStudiesData>();
            Selections = new List<VolunteerSelectionsData>();
        }
    }
}
