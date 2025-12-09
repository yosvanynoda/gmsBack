using GMS.DBModels.PRJ;
using GMS.Objects.API;
using GMS.Objects.PRJ;
using GMS.Objects.STD;

namespace GMS.Business.PRJ
{
    public interface IPRJService
    {

        Task<BaseResponse> CreateStudioSubject(string cn, CreateStudioSubjectRequest request);

        Task<BaseResponse> CreateVisit(string cn, CreateVisitRequest request);

        Task<BaseResponse> CancelVisit(string cn, CancelVisitRequest request);

        Task<BaseResponse> GetVisitSchedule(string cn, int companyId, int siteId, DateTime startDate, DateTime endDate);

        Task<BaseResponse> CreateSubjectChecking(string cn, CreateCheckingRequest request);

        Task<BaseResponse> CreateSubjectVisitCompleted(string cn, CreateCheckingRequest request);


    }
}
