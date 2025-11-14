using GMS.Data.DataHelper;
using GMS.Objects.API;
using GMS.Objects.VLT;



namespace GMS.Business.GNR
{
    public class GNRService(IDataHelper dataHelper) : IGNRService
    {
        private readonly IDataHelper _dataHelper = dataHelper;

       
        public async Task<BaseResponse> GetDashboardStudyStats(string cn, SiteRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.GNR_GetDashboardStudyStats(cn, request.CompanyId, request.SiteId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No DATA found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }


        public async Task<BaseResponse> GetActiveSubjectsCount(string cn, SiteRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.GNR_GetActiveSubjectsCount(cn, request.CompanyId, request.SiteId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No DATA found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetTodayVisitStatistics(string cn, SiteRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.GNR_GetTodayVisitStatistics(cn, request.CompanyId, request.SiteId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No DATA found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }


    }
}
