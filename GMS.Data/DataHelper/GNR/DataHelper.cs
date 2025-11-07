using Dapper;
using GMS.DBModels.CMN;
using GMS.DBModels.GNR;
using GMS.DBModels.Helper;
using GMS.DBModels.STD;
using GMS.Objects.GNR;
using System.Data;

namespace GMS.Data.DataHelper
{
    public partial class DataHelper : IDataHelper
    {

        
        public async Task<PayloadResult?> GNR_GetDashboardStudyStats(string cn, int companyId, int siteId)
        {
            var response = new PayloadResult();

           try
            {
                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@SiteId", siteId, DbType.Int32, ParameterDirection.Input);

                var query = await QueryMultipleStoreProcedure(cn, "GNR_GetDashboardStudyStats", parameters, 0);

                if (query == null)
                {
                    response.Result = -99;
                    response.ResultMessage = "No data found.";
                    return response;
                }

                var result = new
                {
                    Header = query.GridReader.Read<GNRStudiesCardHeader>()?.FirstOrDefault(),
                    StatusCounts = query.GridReader.Read<GNRStudyStatusCount>()?.ToList(),
                    
                };

                response.Result = 0;
                response.ResultMessage = "Success";
                response.Data = result;              

            }
            catch (Exception ex)
            {

                response.Result = -99;
                response.ResultMessage = ex.Message;
            }

            return response;
        }

        public async Task<PayloadResult?> GNR_GetActiveSubjectsCount(string cn, int companyId, int siteId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@SiteId", siteId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<GetActiveSubjectsCount>(cn, "GNR_GetActiveSubjectsCount", parameters, 0);

                if (result != null && result.Any())
                {
                    response.Result = 0;
                    response.ResultMessage = "Success";
                    response.Data = result.ToList();
                }
                else
                {
                    response.Result = -99;
                    response.ResultMessage = "No data found.";
                }

            }
            catch (Exception ex)
            {

                response.Result = -99;
                response.ResultMessage = ex.Message;
            }

            return response;
        }

        public async Task<PayloadResult?> GNR_GetTodayVisitStatistics(string cn, int companyId, int siteId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@SiteId", siteId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<GetTodayVisitStatistics>(cn, "GNR_GetTodayVisitStatistics", parameters, 0);

                if (result != null && result.Any())
                {
                    response.Result = 0;
                    response.ResultMessage = "Success";
                    response.Data = result.ToList();
                }
                else
                {
                    response.Result = -99;
                    response.ResultMessage = "No data found.";
                }

            }
            catch (Exception ex)
            {

                response.Result = -99;
                response.ResultMessage = ex.Message;
            }

            return response;
        }




    }
}
