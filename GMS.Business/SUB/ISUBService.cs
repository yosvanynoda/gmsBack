using GMS.Objects.API;
using GMS.Objects.SUB;
using GMS.Objects.VLT;


namespace GMS.Business.SUB
{
    public interface ISUBService
    {
        Task<BaseResponse> CreateContact(string cn, CreateContactRequest request);

        Task<BaseResponse> CreateRandomCode(string cn, CreateRandomCodeRequest request);

        Task<BaseResponse> GetSubjectList(string cn, SiteRequest request);

        Task<BaseResponse> CreateSubject(string cn, CreateSubjectRequest request, string subjectCode);

        Task<BaseResponse> GetSubjectData(string cn, SubjectRequest request);

        Task<BaseResponse> GetVisitPlanList(string cn, SubjectStudyRequest request);

        Task<BaseResponse> UpdateSubject(string cn, UpdateSubjectRequest request);
    }
}
