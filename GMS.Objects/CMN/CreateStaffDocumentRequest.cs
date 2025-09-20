using GMS.Objects.VLT;

namespace GMS.Objects.CMN
{
    public class CreateStaffDocumentRequest
    {
        public int StaffId { get; set; }
        public List<StaffDocumentData> StaffDocumentData { get; set; } = [];

    }
}
