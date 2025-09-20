using Newtonsoft.Json;

namespace GMS.DBModels.Helper
{
    public class DBObject
    {
        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("engine")]
        public string Engine { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("port")]
        public int? Port { get; set; }

        [JsonProperty("dbname")]
        public string DbName { get; set; }

        public DBObject()
        {
            UserName = "";

            Password = "";

            Engine = "";

            Host = "";

            Port = 0;

            DbName = "";
        }

        public string GetConnectionString()
        {
            string? connString = null;

            switch (Engine)
            {
                case "mysql":
                    connString = $"Server={Host}; Port={Port}; database={DbName}; UID={UserName}; password={Password};";
                    break;
                case "sqlserver":
                    connString = $"Data Source={Host}; Initial Catalog={DbName}; User ID={UserName}; Password={Password}";
                    break;
            }

            return connString ?? "";
        }

        ///// <summary>
        ///// Verify is all properties have correct values.
        ///// </summary>
        ///// <param name="cn"></param>
        ///// <returns></returns>
        //static public bool IsValid(DBObject dbObject)
        //{
        //    return dbObject != null &&
        //        !string.IsNullOrWhiteSpace(dbObject.UserName) &&
        //        !string.IsNullOrWhiteSpace(dbObject.Password) &&
        //        !string.IsNullOrWhiteSpace(dbObject.Engine) &&
        //        !string.IsNullOrWhiteSpace(dbObject.Host) &&
        //        dbObject.Port.HasValue &&
        //        !string.IsNullOrWhiteSpace(dbObject.DbName);
        //}
    }
}
