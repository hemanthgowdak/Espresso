

using System.Data;
using Dapper;

namespace TestAPI.Database

{
    public interface IDapperManager : IDisposable
    {
        // Task<T> GetAsync<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.Text);
        // Task<List<T>> GetAllAsync<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.Text);
        // Task<DataSet> GetAllAsync(string sp, DynamicParameters parms, List<string> tableNames, CommandType commandType = CommandType.Text);
        // Task UpdateAsync(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        // Task<T> InsertAsync<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.Text);
        // Task<T> UpdateAsync<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.Text);
        
        
        
        
        int Insert(string sql, DynamicParameters dynamicParameters);

    }
}