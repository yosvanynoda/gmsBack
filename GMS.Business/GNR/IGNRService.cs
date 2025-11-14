using GMS.Objects.API;
using GMS.Objects.VLT;


namespace GMS.Business.GNR
{
    public interface IGNRService
    {
       
        Task<BaseResponse> GetDashboardStudyStats(string cn, SiteRequest request);

        Task<BaseResponse> GetActiveSubjectsCount(string cn, SiteRequest request);

        Task<BaseResponse> GetTodayVisitStatistics(string cn, SiteRequest request);

    }
}
