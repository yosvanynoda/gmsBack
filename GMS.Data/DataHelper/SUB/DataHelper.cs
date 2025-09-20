using Dapper;
using GMS.DBModels.Helper;
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

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output);

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

                parameters.Add("@Code", code, DbType.String, ParameterDirection.Input);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output);

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
        public async Task<BaseResult> SUB_CreateSubject(string cn, string fName, string lName, DateTime dob, string ssNumber, string email, string phone, int addressId, string id, int companyId)
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
                        ResultMessage = "Subject Name is invalid."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@FName", fName, DbType.String, ParameterDirection.Input);

                parameters.Add("@LName", lName, DbType.String, ParameterDirection.Input);

                parameters.Add("@Dob", dob, DbType.DateTime, ParameterDirection.Input);

                parameters.Add("@SSNumber", ssNumber, DbType.String, ParameterDirection.Input);

                parameters.Add("@Email", email, DbType.String, ParameterDirection.Input);

                parameters.Add("@Phone", phone, DbType.String, ParameterDirection.Input);

                parameters.Add("@AddressId", addressId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Id", id, DbType.String, ParameterDirection.Input);

                parameters.Add("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input);

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output);

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

        /// <summary>
        /// SUB_CreateSubjectData
        /// </summary>
        /// <param name="cn"></param>
        /// <param name="subDataUDT"></param>
        /// <returns></returns>
        public async Task<BaseResult> SUB_CreateSubjectData(string cn, DataTable subDataUDT)
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
                        ResultMessage = "Subject Data is invalid."
                    };
                }

                var parameters = new DynamicParameters();

                parameters.Add("@SubDataUDT", subDataUDT.AsTableValuedParameter());

                parameters.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output);

                var result = await ExecuteStoreProcedureWithResult(cn, "SUB_CreateSubjectData", parameters);

                if (result.Result >= 0)
                {
                    return new BaseResult
                    {
                        Result = 0,
                        ResultMessage = "Subject Data created successfully."
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
