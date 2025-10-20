using Dapper;
using GMS.DBModels.CMN;
using GMS.DBModels.Helper;
using GMS.DBModels.STD;
using System.ComponentModel.Design;
using System.Data;


namespace GMS.Data.DataHelper
{
    public partial class DataHelper : IDataHelper
    {

        public async Task<BaseResult> STD_CrudMonitor(string cn, string fName, string lName, string email, string phone, string role, int companyId, int siteId, int id, int username, int sponsorId, int action)
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
                if (string.IsNullOrWhiteSpace(fName))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Monitor Name is invalid."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@Id", id, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@FName", fName, DbType.String, ParameterDirection.Input, size: 150);

                parameters.Add("@LName", lName, DbType.String, ParameterDirection.Input, size: 150);

                parameters.Add("@Email", email, DbType.String, ParameterDirection.Input, size: 150);

                parameters.Add("@Phone", phone, DbType.String, ParameterDirection.Input, size: 50);

                parameters.Add("@Role", role, DbType.String, ParameterDirection.Input, size: 50);

                parameters.Add("@SponsorId", sponsorId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@SiteId", siteId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@UserName", username, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Action", action, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "STD_CrudMonitor", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Monitor created successfully."
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


        public async Task<BaseResult> STD_CrudProtocol(string cn, int id, string protocol, DateTime dateCreated, string version, string notes, DateTime? startDate, DateTime? endDate, int companyId, int username, int action, int? siteId)
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
                if (string.IsNullOrWhiteSpace(protocol))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Protocol Name is invalid."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@Id", id, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Name", protocol, DbType.String, ParameterDirection.Input);

                parameters.Add("@DateCreated", dateCreated, DbType.DateTime, ParameterDirection.Input);

                parameters.Add("@Version", version, DbType.String, ParameterDirection.Input);

                parameters.Add("@Notes", notes, DbType.String, ParameterDirection.Input);

                parameters.Add("@StartDate", startDate, DbType.DateTime, ParameterDirection.Input);

                parameters.Add("@EndDate", endDate, DbType.DateTime, ParameterDirection.Input);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@SiteId", siteId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@UserName", username, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Action", action, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "STD_CrudProtocol", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Protocol created successfully."
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


        public async Task<BaseResult> STD_CrudSponsor(string cn, string name, int typeId, string? contactName, string? contactEmail, string? contactPhone, int companyId, int siteId, int id, int username, int action)
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
                        ResultMessage = "Sponsor Name is invalid."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@Id", id, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Name", name, DbType.String, ParameterDirection.Input);

                parameters.Add("@TypeId", typeId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@ContactName", contactName, DbType.String, ParameterDirection.Input);

                parameters.Add("@ContactEmail", contactEmail, DbType.String, ParameterDirection.Input);

                parameters.Add("@ContactPhone", contactPhone, DbType.String, ParameterDirection.Input);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@SiteId", siteId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@UserName", username, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Action", action, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "STD_CrudSponsor", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Sponsor created successfully."
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
        /// STD_CreateStudioData
        /// </summary>
        /// <param name="cn"></param>
        /// <param name="dtGeneralData"></param>
        /// <param name="dtDocumentation"></param>
        /// <param name="dtMonitor"></param>
        /// <param name="dtProtocol"></param>
        /// <param name="dtArms"></param>
        /// <param name="dtVisits"></param>
        /// <param name="companyId"></param>
        /// <param name="siteId"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        public async Task<BaseResult> STD_CreateStudioData(string cn, DataTable dtGeneralData, DataTable dtDocumentation, DataTable dtMonitor, DataTable dtProtocol, DataTable dtArms,
                                              DataTable dtVisits, int companyId, int siteId, int userName)
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

                var parameters = new DynamicParameters();

                parameters.Add("@STDGeneralData", dtGeneralData.AsTableValuedParameter());

                parameters.Add("@STDDocumentation", dtDocumentation.AsTableValuedParameter());

                parameters.Add("@STDMonitor", dtMonitor.AsTableValuedParameter());

                parameters.Add("@STDProtocol", dtProtocol.AsTableValuedParameter());

                parameters.Add("@STDArms", dtArms.AsTableValuedParameter());

                parameters.Add("@STDVisits", dtVisits.AsTableValuedParameter());

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@SiteId", siteId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Username", userName, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "STD_CreateStudioData", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Studio Data created successfully."
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
        /// STD_UpdateStudioData
        /// </summary>
        /// <param name="cn"></param>
        /// <param name="dtGeneralData"></param>
        /// <param name="dtDocumentation"></param>
        /// <param name="dtMonitor"></param>
        /// <param name="dtProtocol"></param>
        /// <param name="dtArms"></param>
        /// <param name="dtVisits"></param>
        /// <param name="companyId"></param>
        /// <param name="siteId"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        public async Task<BaseResult> STD_UpdateStudioData(string cn, DataTable dtGeneralData, DataTable dtDocumentation, DataTable dtMonitor, DataTable dtProtocol, DataTable dtArms,
                                              DataTable dtVisits, int companyId, int siteId, int userName)
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

                var parameters = new DynamicParameters();

                parameters.Add("@STDGeneralData", dtGeneralData.AsTableValuedParameter());

                parameters.Add("@STDDocumentation", dtDocumentation.AsTableValuedParameter());

                parameters.Add("@STDMonitor", dtMonitor.AsTableValuedParameter());

                parameters.Add("@STDProtocol", dtProtocol.AsTableValuedParameter());

                parameters.Add("@STDArms", dtArms.AsTableValuedParameter());

                parameters.Add("@STDVisits", dtVisits.AsTableValuedParameter());

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@SiteId", siteId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Username", userName, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "STD_UpdateStudioData", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Studio Data created successfully."
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
        /// STD_CreateStudioDoc
        /// </summary>
        /// <param name="cn"></param>
        /// <param name="studioId"></param>
        /// <param name="name"></param>
        /// <param name="typeId"></param>
        /// <param name="docDate"></param>
        /// <param name="version"></param>
        /// <param name="notes"></param>
        /// <param name="companyId"></param>
        /// <returns></returns>
        public async Task<BaseResult> STD_CreateStudioDoc(string cn, int id, int studioId, string name, int typeId, DateTime docDate, string version, string notes, int companyId, int username, int action, int? siteId)
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
                        ResultMessage = "Studio Doc Name is invalid."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@DocID", id, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@StudioId", studioId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Name", name, DbType.String, ParameterDirection.Input);

                parameters.Add("@TypeId", typeId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@DocDate", docDate, DbType.DateTime, ParameterDirection.Input);

                parameters.Add("@Version", version, DbType.String, ParameterDirection.Input);

                parameters.Add("@Notes", notes, DbType.String, ParameterDirection.Input);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@SiteId", siteId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@UserName", username, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Action", action, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "STD_CrudStudioDoc", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Doc created successfully."
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
        /// STD_GetMonitorList
        /// </summary>
        /// <param name="cn"></param>
        /// <param name="companyId"></param>
        /// <returns></returns>
        public async Task<PayloadResult?> STD_GetMonitorList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<STDGetMonitorList>(cn, "STD_GetMonitorList", parameters, 0);

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

        /// <summary>
        /// STD_GetProtocolList
        /// </summary>
        /// <param name="cn"></param>
        /// <param name="companyId"></param>
        /// <returns></returns>
        public async Task<PayloadResult?> STD_GetProtocolList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<STDGetProtocolList>(cn, "STD_GetProtocolList", parameters, 0);

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

        /// <summary>
        /// STD_GetSponsorList
        /// </summary>
        /// <param name="cn"></param>
        /// <param name="companyId"></param>
        /// <returns></returns>
        public async Task<PayloadResult?> STD_GetSponsorList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<STDGetSponsorList>(cn, "STD_GetSponsorList", parameters, 0);

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

        /// <summary>
        /// STD_GetStudioList
        /// </summary>
        /// <param name="cn"></param>
        /// <param name="companyId"></param>
        /// <returns></returns>
        public async Task<PayloadResult?> STD_GetStudioList(string cn, int companyId, int siteId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@SiteId", siteId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<STDGetStudioList>(cn, "STD_GetStudioList", parameters, 0);

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

        /// <summary>
        /// STD_GetSubjectList
        /// </summary>
        /// <param name="cn"></param>
        /// <param name="companyId"></param>
        /// <returns></returns>
        public async Task<PayloadResult?> STD_GetSubjectList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<STDGetSubjectList>(cn, "STD_GetSubjectList", parameters, 0);

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

        public async Task<PayloadResult?> STD_GetStudioDocList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<STDDocumentation>(cn, "STD_GetDocList", parameters, 0);

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


        public async Task<PayloadResult?> STD_GetMonitorDropList(string cn, int companyId, int sponsorId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@SponsorId", sponsorId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<DropListBaseResponse>(cn, "STD_GetMonitorDropList", parameters, 0);

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

        public async Task<PayloadResult?> STD_GetSponsorDropList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<DropListBaseResponse>(cn, "STD_GetSponsorDropList", parameters, 0);

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

        public async Task<PayloadResult?> STD_GetDiseaseDropList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<DropListBaseResponse>(cn, "STD_GetDiseaseDropList", parameters, 0);

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

        public async Task<PayloadResult?> STD_GetCroDropList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<DropListBaseResponse>(cn, "STD_GetCroDropList", parameters, 0);

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

        public async Task<PayloadResult?> STD_GetStaffDropList(string cn, int companyId, int siteId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@SiteId", siteId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<DropListBaseResponse>(cn, "STD_GetStaffDropList", parameters, 0);

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

        public async Task<PayloadResult?> STD_GetStudioDropList(string cn, int companyId, int siteId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@SiteId", siteId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<DropListBaseResponse>(cn, "STD_GetStudioDropList", parameters, 0);

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

        public async Task<BaseResult> STD_CreateStudioStaff(string cn, int studioId, int staffId, int roleId, DateTime? startDate, DateTime? endDate, int companyId, int siteId, int username, int action)
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

                if (studioId == null | staffId == null)
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Studio Staff relation is invalid."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@StaffId", staffId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@StudioId", studioId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@RoleId", roleId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@StartDate", startDate, DbType.DateTime, ParameterDirection.Input);

                parameters.Add("@EndDate", endDate, DbType.DateTime, ParameterDirection.Input);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@SiteId", siteId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Action", action, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@UserName", username, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "STD_CrudStudioStaff", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Studio Staff created successfully."
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

        public async Task<PayloadResult?> STD_GetProtocolVersionList(string cn, int companyId, int protocolId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@ProtocolId", protocolId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<STDGetProtocolVersionList>(cn, "STD_GetProtocolVersionList", parameters, 0);

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


        public async Task<PayloadResult?> STD_GetStudioData(string cn, int companyId, int siteId, int studyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@SiteId", siteId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@StudyId", studyId, DbType.Int32, ParameterDirection.Input);

                var query = await QueryMultipleStoreProcedure(cn, "STD_GetStudio", parameters, 0);

                if (query == null)
                {
                    response.Result = -99;
                    response.ResultMessage = "No data found.";
                    return response;
                }

                var result = new
                {
                    Header = query.GridReader.Read<STDGeneralData>()?.FirstOrDefault(),
                    Arms = query.GridReader.Read<STDArms>()?.ToList(),
                    Monitors = query.GridReader.Read<STDMonitor>()?.ToList(),
                    Staffs = query.GridReader.Read<CMNStaff>()?.ToList(),
                    Documentation = query.GridReader.Read<STDDocumentation>()?.ToList(),
                    VisitDefinition = query.GridReader.Read<STDVisitDefinition>()?.ToList()
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

        public async Task<BaseResult> VLT_PreAssignVolunteersToStudy(string cn, int companyId, int siteId, int studyId,
            DataTable volunteerIds, int userId)
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

                if (volunteerIds == null || volunteerIds.Rows.Count == 0)
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "No volunteers selected for pre-assignment."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@SiteId", siteId, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@StudyId", studyId, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@VolunteerIds", volunteerIds.AsTableValuedParameter());
                parameters.Add("@UserId", userId, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);
                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 250);

                var result = await ExecuteStoreProcedureWithResult(cn, "VLT_PreAssignVolunteersToStudy", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = $"{result.Result} volunteer(s) pre-assigned to study successfully."
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

        public async Task<BaseResult> VLT_RemovePreAssigned(string cn, int companyId, int siteId, int studyId, int volunteerId, int userId)
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

                if (volunteerId == null || studyId == null)
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "No volunteers selected for remove pre-assignment."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@SiteId", siteId, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@StudyId", studyId, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@VolunteerId", volunteerId, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@UserId", userId, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);
                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 250);

                var result = await ExecuteStoreProcedureWithResult(cn, "VLT_RemovePreAssigned", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Volunteer removed  successfully."
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
