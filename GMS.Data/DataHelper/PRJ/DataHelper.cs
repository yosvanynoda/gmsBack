﻿using Dapper;
using GMS.DBModels.Helper;
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

                parameters.Add("@SubjectId", subjectId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@StudioId", studioId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@StartDate", startDate, DbType.DateTime, ParameterDirection.Input);

                parameters.Add("@EndDate", endDate, DbType.DateTime, ParameterDirection.Input);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

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
    }
}
