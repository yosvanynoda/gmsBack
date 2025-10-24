using Dapper;
using GMS.DBModels.Helper;
using GMS.DBModels.SUB;
using System.Data;

namespace GMS.Data.DataHelper
{
    public partial class DataHelper : IDataHelper
    {

        /// <summary>
        /// SUB_CreateContact
        /// </summary>
        /// <param name="cn"></param>
        /// <param name="subjectId"></param>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="relation"></param>
        /// <param name="companyId"></param>
        /// <returns></returns>
        public async Task<BaseResult> SUB_CreateContact(string cn, int subjectId, string name, string phone, int relation, int companyId)
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
                if (string.IsNullOrWhiteSpace(name))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Contact( Name is invalid."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@SubjectId", subjectId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Name", name, DbType.String, ParameterDirection.Input);

                parameters.Add("@Phone", phone, DbType.String, ParameterDirection.Input);

                parameters.Add("@Relation", relation, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "SUB_CreateContact", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Contact created successfully."
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

        /// <summary>
        /// SUB_CreateRandomCode
        /// </summary>
        /// <param name="cn"></param>
        /// <param name="subjectId"></param>
        /// <param name="studioId"></param>
        /// <param name="code"></param>
        /// <param name="companyId"></param>
        /// <returns></returns>
        public async Task<BaseResult> SUB_CreateRandomCode(string cn, int subjectId, int studioId, string code, int companyId)
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
                if (string.IsNullOrWhiteSpace(code))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Random Code is invalid."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@SubjectId", subjectId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@StudioId", studioId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Code", code, DbType.String, ParameterDirection.Input, size: 250);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "SUB_CreateRandomCode", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Random Code created successfully."
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

        /// <summary>
        /// SUB_CreateSubject
        /// </summary>
        /// <param name="cn"></param>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="dob"></param>
        /// <param name="ssNumber"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="addressId"></param>
        /// <param name="id"></param>
        /// <param name="companyId"></param>
        /// <returns></returns>
        public async Task<BaseResult> SUB_CreateSubject(string cn,DataTable dtSubject, string subjectCode)
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
                if ( dtSubject == null || dtSubject.Rows.Count == 0)
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Subject is invalid."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@SubDataUDT", dtSubject.AsTableValuedParameter());

                parameters.Add("@SubjectCode", subjectCode, DbType.String, ParameterDirection.Input, size: 150);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "SUB_CreateSubject", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Subject created successfully."
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

        public async Task<PayloadResult?> SUB_GetSubjectList(string cn, int companyId, int siteId)
        {
            var response = new PayloadResult();

            try
            {
                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@SiteId", siteId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<SUBSubjectList>(cn, "SUB_GetSubjectList", parameters, 0);

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


        public async Task<PayloadResult?> SUB_GetSubjectData(string cn, int companyId, int siteId, int subjectId)
        {
            var response = new PayloadResult();

            try
            {
                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@SiteId", siteId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@SubjectId", subjectId, DbType.Int32, ParameterDirection.Input);

                var payload = new SUBSubjectResponse();

                var result = await QueryMultipleStoreProcedure(cn, "SUB_GetSubjectData", parameters, 0);

                if (result != null)
                {
                    payload.Header = result.GridReader.Read<SUBSubject>().FirstOrDefault() ?? new();
                    payload.Consent = result.GridReader.Read<SUBConsent>().ToList() ?? [];
                    payload.Deviation = result.GridReader.Read<SUBDeviation>().ToList() ?? [];
                    payload.Adverse = result.GridReader.Read<SUBAdverse>().ToList() ?? [];

                    response.Result = 0;
                    response.ResultMessage = "Success";
                    response.Data = payload;
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

        public async Task<PayloadResult?> SUB_GetVisitPlanList(string cn, int companyId, int siteId, int subjectId, int studyId)
        {
            var response = new PayloadResult();

            try
            {
                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@SiteId", siteId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@SubjectId", subjectId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@StudyId", studyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<SUBVisitPlanList>(cn, "SUB_GetVisitPlanList", parameters, 0);

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

        public async Task<BaseResult> SUB_UpdateSubject(string cn, DataTable subDataUDT, DataTable dtConsent, DataTable dtEvent, DataTable dtDeviation)
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
                if (subDataUDT == null || subDataUDT.Rows.Count == 0)
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Subject is invalid."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@SUBDataUDT", subDataUDT.AsTableValuedParameter());

                parameters.Add("@SUBConsent", dtConsent.AsTableValuedParameter());

                parameters.Add("@SUBEvent", dtEvent.AsTableValuedParameter());

                parameters.Add("@SUBDeviation", dtDeviation.AsTableValuedParameter());

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "SUB_UpdateSubjectData", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Subject created successfully."
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
