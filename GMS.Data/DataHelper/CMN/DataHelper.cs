using Dapper;
using GMS.DBModels.CMN;
using GMS.DBModels.Helper;
using System.Data;

namespace GMS.Data.DataHelper
{
    public partial class DataHelper : IDataHelper
    {

        public async Task<BaseResult> CMN_CreateCompany(string cn, int companyId, string companyName, int username, int action)
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

                if (string.IsNullOrEmpty(companyName))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Company name is null or empty."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@Id", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Name", companyName, DbType.String, ParameterDirection.Input, size: 150);

                parameters.Add("@UserName", username, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Action", action, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "CMN_CrudCompany", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Company created successfully."
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

        public async Task<BaseResult> CMN_CreateDisease(string cn, int diseaseId, string diseaseName, int companyId, int username, int action, string diseaseCode)
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

                if (string.IsNullOrEmpty(diseaseName))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Disease name is null or empty."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@Id", diseaseId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@DiseaseName", diseaseName, DbType.String, ParameterDirection.Input, size: 150);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@UserName", username, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Action", action, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@DiseaseCode", diseaseCode, DbType.String, ParameterDirection.Input, size: 150);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "CMN_CrudDisease", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Disease created successfully."
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

        public async Task<BaseResult> CMN_CreateDocType(string cn, int docTypeId, string docType, string comment, int applyFor, int companyId, int username, int action)
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

                if (string.IsNullOrEmpty(docType))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Document Type is null or empty."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@Id", docTypeId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@DocType", docType, DbType.String, ParameterDirection.Input, size: 150);

                parameters.Add("@Notes", comment, DbType.String, ParameterDirection.Input, size: 400);

                parameters.Add("@Apply", applyFor, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@UserName", username, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Action", action, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "CMN_CrudDocType", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Document Type created successfully."
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

        public async Task<BaseResult> CMN_CreateRelationType(string cn, int id, string relationType, int companyId, int username, int action)
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

                if (string.IsNullOrEmpty(relationType))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Disease name is null or empty."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@Id", id, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@RelationType", relationType, DbType.String, ParameterDirection.Input, size: 150);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@UserName", username, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Action", action, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "CMN_CrudRelationType", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Relation Type created successfully."
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

        public async Task<BaseResult> CMN_CreateRoleType(string cn, int roleTypeId, string roleType, int companyId, int username, int action)
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

                if (string.IsNullOrEmpty(roleType))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Role Type is null or empty."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@Id", roleTypeId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@RoleType", roleType, DbType.String, ParameterDirection.Input, size: 150);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@UserName", username, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Action", action, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "CMN_CrudRoleType", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Role Type created successfully."
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

        public async Task<BaseResult> CMN_CreateAllergy(string cn, int allergyId, string allergy, string? comment, int companyId, int username, int action)
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

                if (string.IsNullOrEmpty(allergy))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Allergy is null or empty."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@Id", allergyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Allergy", allergy, DbType.String, ParameterDirection.Input, size: 150);

                parameters.Add("@Comment", comment, DbType.String, ParameterDirection.Input, size: 400);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@UserName", username, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Action", action, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "CMN_CrudAllergy", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Allergy created successfully."
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

        public async Task<BaseResult> CMN_CreateLanguage(string cn, int id, string language, string comment, int companyId, int username, int action)
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

                if (string.IsNullOrEmpty(language))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Language is null or empty."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@Id", id, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Language", language, DbType.String, ParameterDirection.Input, size: 150);

                parameters.Add("@Comment", comment, DbType.String, ParameterDirection.Input, size: 400);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@UserName", username, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Action", action, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "CMN_CrudLanguage", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Language created successfully."
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

        public async Task<BaseResult> CMN_CreateMedication(string cn, int medicationId, string medicationName, string medicationDose, int companyId, int username, int action)
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

                if (string.IsNullOrEmpty(medicationName))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Medication name is null or empty."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@Id", medicationId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@MedicationName", medicationName, DbType.String, ParameterDirection.Input, size: 150);

                parameters.Add("@MedicationDose", medicationDose, DbType.String, ParameterDirection.Input, size: 150);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@UserName", username, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Action", action, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "CMN_CrudMedication", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Medication created successfully."
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

        public async Task<BaseResult> CMN_CreateSite(string cn, int siteId, string siteName, string address, string contact, string phone, string email, string code, int companyId, int username, int action)
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

                if (string.IsNullOrEmpty(siteName))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Site is null or empty."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@Id", siteId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Name", siteName, DbType.String, ParameterDirection.Input);

                parameters.Add("@SiteAddress", address, DbType.String, ParameterDirection.Input);

                parameters.Add("@SiteContact", contact, DbType.String, ParameterDirection.Input);

                parameters.Add("@SitePhone", phone, DbType.String, ParameterDirection.Input);

                parameters.Add("@SiteEmail", email, DbType.String, ParameterDirection.Input);

                parameters.Add("@SiteCode", code, DbType.String, ParameterDirection.Input);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@UserName", username, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Action", action, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "CMN_CrudSite", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Site created successfully."
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

        public async Task<BaseResult> CMN_CreateSponsorType(string cn, int id, string sponsorType, int companyId, int username, int action)
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

                if (string.IsNullOrEmpty(sponsorType))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Sponsor Type is null or empty."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@Type", sponsorType, DbType.String, ParameterDirection.Input, size: 150);

                parameters.Add("@Id", id, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@UserName", username, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Action", action, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "CMN_CrudSponsorType", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Sponsor Type created successfully."
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

        public async Task<BaseResult> CMN_CreateTaskType(string cn, int taskTypeId, string taskType, int companyId, int username, int action)
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

                if (string.IsNullOrEmpty(taskType))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Task Type is null or empty."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@Id", taskTypeId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@TaskType", taskType, DbType.String, ParameterDirection.Input, size: 150);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@UserName", username, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Action", action, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "CMN_CrudTaskType", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Task Type created successfully."
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


        public async Task<BaseResult> CMN_CreateStaffDocument(string cn, DataTable cmnStaffDocumentUDT, int staffId)
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

                if (cmnStaffDocumentUDT == null || cmnStaffDocumentUDT.Rows.Count == 0)
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Staff document data is invalid."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@Documents", cmnStaffDocumentUDT.AsTableValuedParameter());

                parameters.Add("@StaffId", staffId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output);

                var result = await ExecuteStoreProcedureWithResult(cn, "CMN_CreateStaffDocuments", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Staff Doc created successfully."
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


        public async Task<BaseResult> CMN_CreateTask(string cn, int taskId, string taskName, int taskTypeId, int companyId, int username, int action)
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

                if (string.IsNullOrEmpty(taskName))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Task is null or empty."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@Id", taskId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@TaskName", taskName, DbType.String, ParameterDirection.Input, size: 150);

                parameters.Add("@TaskType", taskTypeId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@UserName", username, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Action", action, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "CMN_CrudTask", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Task created successfully."
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


        public async Task<BaseResult> CMN_CreateStaff(string cn, int staffId, string firstName, string lastName, string phone, string email, string role, string department,
                                                     int companyId, int site, string status, int username, int action)
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

                if (string.IsNullOrEmpty(firstName))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Site is null or empty."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@Id", staffId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@FName", firstName, DbType.String, ParameterDirection.Input);

                parameters.Add("@LName", lastName, DbType.String, ParameterDirection.Input);

                parameters.Add("@Phone", phone, DbType.String, ParameterDirection.Input);

                parameters.Add("@Email", email, DbType.String, ParameterDirection.Input);

                parameters.Add("@Role", role, DbType.String, ParameterDirection.Input);

                parameters.Add("@Site", site, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Dept", department, DbType.String, ParameterDirection.Input);

                parameters.Add("@Status", status, DbType.String, ParameterDirection.Input);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@UserName", username, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Action", action, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "CMN_CrudStaff", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Staff member created successfully."
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

        public async Task<PayloadResult?> CMN_GetDiseaseList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<CMNDiseases>(cn, "CMN_GetDiseaseList", parameters, 0);

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

        public async Task<BaseResult> CMN_CreateStaffDocument(string cn, DataTable cmnStaffDocUDT)
        {
            return null;
        }


        public async Task<PayloadResult?> CMN_GetDocTypeList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<CMNDocType>(cn, "CMN_GetDocType", parameters, 0);

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

        public async Task<PayloadResult?> CMN_GetRoleTypeList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<CMNRoleType>(cn, "CMN_GetRoleType", parameters, 0);

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

        public async Task<PayloadResult?> CMN_GetRelationTypeList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<CMNRelationType>(cn, "CMN_GetRelationType", parameters, 0);

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

        public async Task<PayloadResult?> CMN_GetSiteList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<CMNSites>(cn, "CMN_GetSites", parameters, 0);

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

        public async Task<PayloadResult?> CMN_GetSponsorTypeList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<CMNSponsorType>(cn, "CMN_GetSponsorType", parameters, 0);

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

        public async Task<PayloadResult?> CMN_GetAllergyList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<CMNAllergy>(cn, "CMN_GetAllergyList", parameters, 0);

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

        public async Task<PayloadResult?> CMN_GetMedicationList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<CMNMedication>(cn, "CMN_GetMedicationList", parameters, 0);

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


        public async Task<PayloadResult?> CMN_GetStaffStudio(string cn, int companyId, int siteId, int? staffId, int? studioId)
        {
            var response = new PayloadResult();

            try
            {
                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@SiteId", siteId, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@StaffId", staffId, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@StudioId", studioId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<CMNStaffStudio>(cn, "CMN_GetStaffStudio", parameters, 0);

                if (result != null && result.Any())
                {
                    response.Result = 0;
                    response.ResultMessage = "Success";
                    response.Data = result.ToList();
                }
                else
                {
                    response.Result = 0;
                    response.ResultMessage = "No data found.";
                    response.Data = new List<CMNStaffStudio>();
                }

            }
            catch (Exception ex)
            {
                response.Result = -99;
                response.ResultMessage = ex.Message;
            }

            return response;
        }

        public async Task<PayloadResult?> CMN_GetStaffList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<CMNStaff>(cn, "CMN_GetStaff", parameters, 0);

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

        public async Task<PayloadResult?> CMN_GetStaffDocumentList(string cn, int companyId, int staffId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@StaffId", staffId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<CMNStaffDocument>(cn, "CMN_GetStaffdDocument", parameters, 0);

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


        public async Task<PayloadResult?> CMN_GetTaskList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<CMNTask>(cn, "CMN_GetTask", parameters, 0);

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

        public async Task<PayloadResult?> CMN_GetTaskTypeList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<CMNTaskType>(cn, "CMN_GetTaskType", parameters, 0);

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

        public async Task<PayloadResult?> CMN_GetGenderList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<CMNGender>(cn, "CMN_GetGender", parameters, 0);

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


        public async Task<PayloadResult?> CMN_GetLanguageList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<CMNLanguage>(cn, "CMN_GetLanguage", parameters, 0);

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


        public async Task<PayloadResult?> CMN_GetRaceList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<CMNRace>(cn, "CMN_GetRace", parameters, 0);

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


        public async Task<PayloadResult?> CMN_GetEthnicityList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<CMNEthnicity>(cn, "CMN_GetEthnicity", parameters, 0);

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

        public async Task<BaseResult> CMN_CreateEthnicity(string cn, int id, string ethnicity, string comment, int companyId, int username, int action)
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

                if (string.IsNullOrEmpty(ethnicity))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Ethnicity is null or empty."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@Id", id, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Ethnicity", ethnicity, DbType.String, ParameterDirection.Input, size: 150);

                parameters.Add("@Comment", comment, DbType.String, ParameterDirection.Input, size: 400);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@UserName", username, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Action", action, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "CMN_CrudEthnicity", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Ethnicity created successfully."
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

        public async Task<BaseResult> CMN_CreateGender(string cn, int id, string gender, string comment, int companyId, int username, int action)
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

                if (string.IsNullOrEmpty(gender))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Gender is null or empty."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@Id", id, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Gender", gender, DbType.String, ParameterDirection.Input, size: 150);

                parameters.Add("@Comment", comment, DbType.String, ParameterDirection.Input, size: 400);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@UserName", username, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Action", action, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "CMN_CrudGender", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Gender created successfully."
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

        public async Task<BaseResult> CMN_CreateRace(string cn, int id, string race, string comment, int companyId, int username, int action)
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

                if (string.IsNullOrEmpty(race))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Race is null or empty."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@Id", id, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Race", race, DbType.String, ParameterDirection.Input, size: 150);

                parameters.Add("@Comment", comment, DbType.String, ParameterDirection.Input, size: 400);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@UserName", username, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Action", action, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "CMN_CrudRace", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Race created successfully."
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

        public async Task<PayloadResult?> CMN_GetCROList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<CMNCRO>(cn, "CMN_GetCRO", parameters, 0);

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

        public async Task<BaseResult> CMN_CreateCRO(string cn, int id, string cro, string comment, int companyId, int username, int action)
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

                if (string.IsNullOrEmpty(cro))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Contract research org is null or empty."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@Id", id, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@CRO", cro, DbType.String, ParameterDirection.Input, size: 150);

                parameters.Add("@Comment", comment, DbType.String, ParameterDirection.Input, size: 400);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@UserName", username, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Action", action, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "CMN_CrudCRO", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Contract research org created successfully."
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

        public async Task<PayloadResult?> CMN_GetFlagDropList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);                

                var result = await QueryStoreProcedure<DropListBaseResponse>(cn, "CMN_GetFlagDropList", parameters, 0);

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

        public async Task<PayloadResult?> CMN_GetVLTStatusList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<CMNVLTStatus>(cn, "CMN_GetVLTStatus", parameters, 0);

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

        public async Task<BaseResult> CMN_CreateVLTStatus(string cn, int id, string name, string comment, int companyId, int username, int action)
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

                if (string.IsNullOrEmpty(name))
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Contract research org is null or empty."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@Id", id, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Name", name, DbType.String, ParameterDirection.Input, size: 150);

                parameters.Add("@Comment", comment, DbType.String, ParameterDirection.Input, size: 400);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@UserName", username, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Action", action, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "CMN_CrudVLTStatus", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Volunteer status created successfully."
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
