using Dapper;
using GMS.DBModels.Helper;
using Microsoft.Data.SqlClient;
using System.Data;
using static Dapper.SqlMapper;

namespace GMS.Data.DataHelper
{
    public partial class DataHelper : IDataHelper
    {
        private int storeProcedureTimeout = 120; // In seconds.

        /// <summary>
        /// use to execute SP and return one dataset
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cn"></param>
        /// <param name="storeProcedureName"></param>
        /// <param name="parameters"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public async Task<IEnumerable<T>?> QueryStoreProcedure<T>(string cn, string storeProcedureName, DynamicParameters parameters, int timeout = 0)
        {
            using var con = new SqlConnection(cn);

            IEnumerable<T>? results = await con.QueryAsync<T>(storeProcedureName, parameters, null, storeProcedureTimeout, CommandType.StoredProcedure);

            await con.CloseAsync();

            await con.DisposeAsync();

            return results;
        }

        /// <summary>
        /// use to execute SP and return only result and resultmessage (insert, delete, or update only)
        /// </summary>
        /// <param name="cn"></param>
        /// <param name="storeProcedureName"></param>
        /// <param name="parameters"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public async Task<BaseResult> ExecuteStoreProcedureWithResult(string cn, string storeProcedureName, DynamicParameters parameters, int timeout = 0)
        {

            using var con = new SqlConnection(cn);
            await con.ExecuteAsync(storeProcedureName, parameters, null, storeProcedureTimeout, CommandType.StoredProcedure);
            var result = parameters.Get<int>("Result");
            var resultMessage = parameters.Get<string>("ResultMessage");
            var resultResponse = new BaseResult()
            {
                Result = result,
                ResultMessage = resultMessage
            };
            await con.CloseAsync();
            await con.DisposeAsync();

            return resultResponse;
        }

        /// <summary>
        /// use to execute SP and return only rowsAffected (insert, delete, or update only)
        /// </summary>
        /// <param name="cn"></param>
        /// <param name="storeProcedureName"></param>
        /// <param name="parameters"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public async Task<int> ExecuteStoreProcedure(string cn, string storeProcedureName, DynamicParameters parameters, int timeout = 0)
        {

            using var con = new SqlConnection(cn);
            var rowsAffected = await con.ExecuteAsync(storeProcedureName, parameters, null, storeProcedureTimeout, CommandType.StoredProcedure);

            await con.CloseAsync();

            await con.DisposeAsync();

            return rowsAffected;
        }

        /// <summary>
        /// use to execute SP and return multiples dataset 
        /// </summary>
        /// <param name="cn"></param>
        /// <param name="storeProcedureName"></param>
        /// <param name="parameters"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public async Task<QueryMultipleResponse?> QueryMultipleStoreProcedure(string cn, string storeProcedureName, DynamicParameters parameters, int timeout = 0)
        {
            var con = new SqlConnection(cn);

            QueryMultipleResponse? queryMultipleResponse = new QueryMultipleResponse()
            {
                AliveConnection = con,
                GridReader = await con.QueryMultipleAsync(storeProcedureName, parameters, null, storeProcedureTimeout, CommandType.StoredProcedure)
            };

            return queryMultipleResponse;
        }

    }
}
