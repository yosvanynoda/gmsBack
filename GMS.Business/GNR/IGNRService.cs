using GMS.Objects.API;
using GMS.Objects.VLT;


namespace GMS.Business.GNR
{
    public interface IGNRService
    {
       
        Task<BaseResponse> GetDashboardStudyStats(string cn, SiteRequest request);

      
    }
}
