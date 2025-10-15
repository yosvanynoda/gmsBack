using Dapper;
using GMS.DBModels.Helper;
using GMS.DBModels.VLT;
using System.Data;

namespace GMS.Data.DataHelper
{
    public partial class DataHelper : IDataHelper
    {
        public async Task<BaseResult> VLT_CreateVolunteerData(string cn, DataTable dtGd, DataTable dtAllergy, DataTable dtDisease,
                DataTable dtDoc, DataTable dtEmergc, DataTable dtMed)
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

                if (dtGd == null || dtGd.Rows.Count == 0)
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Volunteer Data is invalid."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@VLTDataUDT", dtGd.AsTableValuedParameter());

                parameters.Add("@VLTEmergencyContact", dtEmergc.AsTableValuedParameter());

                parameters.Add("@VLTDeseases", dtDisease.AsTableValuedParameter());

                parameters.Add("@VLTAllergies", dtAllergy.AsTableValuedParameter());

                parameters.Add("@VLTMedications", dtMed.AsTableValuedParameter());

                parameters.Add("@VLTDocuments", dtDoc.AsTableValuedParameter());

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                var result = await ExecuteStoreProcedureWithResult(cn, "VLT_CreateVolunteerData", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Volunteer Data created successfully."
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

        public async Task<BaseResult> VLT_UpdateVolunteerData(string cn, DataTable dtGd, DataTable dtAllergy, DataTable dtDisease,
               DataTable dtDoc, DataTable dtEmergc, DataTable dtMed, int companyId, int siteId, int username)
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

                if (dtGd == null || dtGd.Rows.Count == 0)
                {
                    return new BaseResult
                    {
                        Result = -99,
                        ResultMessage = "Volunteer Data is invalid."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@VLTDataUDT", dtGd.AsTableValuedParameter());

                parameters.Add("@VLTEmergencyContact", dtEmergc.AsTableValuedParameter());

                parameters.Add("@VLTDeseases", dtDisease.AsTableValuedParameter());

                parameters.Add("@VLTAllergies", dtAllergy.AsTableValuedParameter());

                parameters.Add("@VLTMedications", dtMed.AsTableValuedParameter());

                parameters.Add("@VLTDocuments", dtDoc.AsTableValuedParameter());

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@SiteId", siteId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Username", username, DbType.String, ParameterDirection.Input, size: 150);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 300);

                var result = await ExecuteStoreProcedureWithResult(cn, "VLT_UpdateVolunteerData", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Volunteer Data updated successfully."
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

        public async Task<PayloadResult?> VLT_GetVolunteerList(string cn, int companyId, int siteId)
        {
            var response = new PayloadResult();

            try
            {
                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@SiteId", siteId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<VLTVolunteerList>(cn, "VLT_GetVolunteerList", parameters, 0);

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

        public async Task<PayloadResult?> VLT_GetVolunteerData(string cn, int companyId, int siteId, int volunteerId)
        {
            var response = new PayloadResult();

            try
            {
                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@SiteId", siteId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@VolunteerId", volunteerId, DbType.Int32, ParameterDirection.Input);

                var payload = new VLTVolunteerResponse();

                var result = await QueryMultipleStoreProcedure(cn, "VLT_GetVolunteerData", parameters, 0);

                if (result != null)
                {
                    payload.Header = result.GridReader.Read<VLTVolunteerData>().FirstOrDefault() ?? new ();
                    payload.EmergencyContacts = result.GridReader.Read<VLTEmergencyContact>().ToList() ?? [];
                    payload.Documentations = result.GridReader.Read<VLTDocumentation>().ToList() ?? [];
                    payload.Allergies = result.GridReader.Read<VLTAllergy>().ToList() ?? [];
                    payload.Diseases = result.GridReader.Read<VLTDisease>().ToList() ?? [];
                    payload.Medications = result.GridReader.Read<VLTMedication>().ToList() ?? [];

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

        public async Task<PayloadResult?> VLT_GetVLTStatusDropList(string cn, int companyId)
        {
            var response = new PayloadResult();

            try
            {

                var parameters = new DynamicParameters();

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                var result = await QueryStoreProcedure<DropListBaseResponse>(cn, "VLT_GetStatusDropList", parameters, 0);

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
