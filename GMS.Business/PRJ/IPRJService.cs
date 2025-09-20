using GMS.Objects.API;
using GMS.Objects.PRJ;

namespace GMS.Business.PRJ
{
    public interface IPRJService
    {

        Task<BaseResponse> CreateStudioSubject(string cn, CreateStudioSubjectRequest request);
    }
}
