using Dapper;
using GMS.DBModels.CMN;
using GMS.DBModels.Helper;
using GMS.DBModels.PRJ;
using GMS.DBModels.STD;
using System.Data;

namespace GMS.Data.DataHelper
{
    public partial class DataHelper : IDataHelper
    {
        /// <summary>
        /// PRJ_CreateStudioSubject
        /// </summary>
        /// <param name="cn"></param>
        /// <param name="subjectId"></param>
        /// <param name="studioId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="companyId"></param>
        /// <returns></returns>
        public async Task<BaseResult> PRJ_CreateStudioSubject(string cn, int subjectId, int studioId, DateTime startDate, DateTime endDate, int companyId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cn))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Database object is null."
                    };
                }
                if (subjectId <= 0)
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Subject ID is invalid."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@SubjectId", subjectId);

                parameters.Add("@StudioId", studioId);

                parameters.Add("@StartDate", startDate);

                parameters.Add("@EndDate", endDate);

                parameters.Add("@CompanyId", companyId);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output);

                var result = await ExecuteStoreProcedureWithResult(cn, "PRJ_CreateStudioSubject", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Studio Subject created successfully."
                    };
                }
                else
                {
                    return new BaseResult
                    {
                        Result = result.Result,
                        ResultMessage = result.ResultMessage
                    };
                }
            }
            catch (Exception ex)
            {

                return new BaseResult
                {
                    Result = -99,
                    ResultMessage = ex.Message
                };
            }
        }


        public async Task<BaseResult> PRJ_CreateVisit(string cn, int visitId, int subjectId, int studioId, int staffId, DateTime visitDate, string notes)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cn))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Database object is null."
                    };
                }
                if (visitId <= 0)
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Visit ID is invalid."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@VisitId", visitId);

                parameters.Add("@SubjectId", subjectId);

                parameters.Add("@StudyId", studioId);

                parameters.Add("@StaffId", staffId);

                parameters.Add("@VisitDate", visitDate);

                parameters.Add("@Notes", notes);
                
                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "PRJ_CreateVisit", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Visit created successfully."
                    };
                }
                else
                {
                    return new BaseResult
                    {
                        Result = result.Result,
                        ResultMessage = result.ResultMessage
                    };
                }
            }
            catch (Exception ex)
            {

                return new BaseResult
                {
                    Result = -99,
                    ResultMessage = ex.Message
                };
            }
        }


        public async Task<BaseResult> PRJ_CancelVisit(string cn, int visitId, int subjectId, int studioId, string notes)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cn))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Database object is null."
                    };
                }
                if (visitId <= 0)
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Visit ID is invalid."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@VisitId", visitId);

                parameters.Add("@SubjectId", subjectId);

                parameters.Add("@StudyId", studioId);

                parameters.Add("@Notes", notes);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "PRJ_CreateVisitCancelation", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Visit canceled successfully."
                    };
                }
                else
                {
                    return new BaseResult
                    {
                        Result = result.Result,
                        ResultMessage = result.ResultMessage
                    };
                }
            }
            catch (Exception ex)
            {

                return new BaseResult
                {
                    Result = -99,
                    ResultMessage = ex.Message
                };
            }
        }

        public async Task<PayloadResult?> PRJ_GetVisitSchedule(string cn, int companyId, int siteId, DateTime  scheduleDate )
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@SiteId", siteId, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@Date", scheduleDate);

                var result = await QueryStoreProcedure<SubjectVisitDetails>(cn, "PRJ_GetVisitSchedule", parameters, 0);

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

        public async Task<BaseResult> PRJ_CreateSubjectChecking(string cn, int visitId, int subjectId, int studioId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cn))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Database object is null."
                    };
                }
                if (visitId <= 0)
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Visit ID is invalid."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@VisitId", visitId);

                parameters.Add("@SubjectId", subjectId);

                parameters.Add("@StudyId", studioId);                    

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "PRJ_SubjectChecking", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Checking created successfully."
                    };
                }
                else
                {
                    return new BaseResult
                    {
                        Result = result.Result,
                        ResultMessage = result.ResultMessage
                    };
                }
            }
            catch (Exception ex)
            {

                return new BaseResult
                {
                    Result = -99,
                    ResultMessage = ex.Message
                };
            }
        }
    }
}
