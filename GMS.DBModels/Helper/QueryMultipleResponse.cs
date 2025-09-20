using System.Data.Common;
using static Dapper.SqlMapper;

namespace GMS.DBModels.Helper
{
    public class QueryMultipleResponse
    {
        public required DbConnection AliveConnection { get; set; }

        public required GridReader GridReader { get; set; }

    }
}
