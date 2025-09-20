using GMS.Objects.API;
using GMS.Objects.SUB;

namespace GMS.Business.SUB
{
    public interface ISUBService
    {
        Task<BaseResponse> CreateContact(string cn, CreateContactRequest request);

        Task<BaseResponse> CreateRandomCode(string cn, CreateRandomCodeRequest request);

        Task<BaseResponse> CreateSubjectData(string cn, CreateSubjectDataRequest request);

        Task<BaseResponse> CreateSubject(string cn, CreateSubjectRequest request);
    }
}
