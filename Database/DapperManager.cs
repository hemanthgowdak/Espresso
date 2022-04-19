using Dapper;
using System.Data;
using System.Data.OracleClient;

namespace TestAPI.Database
{
    public class DapperManager : IDapperManager
    {

        string connectionString=@"User Id=system;Password=root;Data Source=ORCL";

        public DapperManager(IConfiguration config)
        {
            // _config = config;
            // var configSettings = JsonConvert.DeserializeObject<ConfigSettings>(_config.GetValue<string>("ConfigSettings"));
            // connectionString = configSettings.ConnectionStrings;
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.Text)
        {
            throw new NotImplementedException();
        }

        public Task<DataSet> GetAllAsync(string sp, DynamicParameters parms, List<string> tableNames, CommandType commandType = CommandType.Text)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.Text)
        {
            throw new NotImplementedException();
        }

        public int Insert(string sql, DynamicParameters dynamicParameters)
        {


              using (OracleConnection connection = new OracleConnection(connectionString))
            {
                int rowsAffected = connection.Execute(sql, dynamicParameters);
                return rowsAffected;

            }
            

            
        }

        public Task<T> InsertAsync<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.Text)
        {
            throw new NotImplementedException();
        }

        // public async Task<T> InsertAsync<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.Text)
        // {
        //     using (var connection = new OracleConnection(connectionString))
        //     {
        //         await connection.OpenAsync();
        //         int result = (await connection.ExecuteAsync(sp, param: parms, commandType: commandType));
        //       //  return result;
        //     }
        // }

        public Task UpdateAsync(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.Text)
        {
            throw new NotImplementedException();
        }
    }
}