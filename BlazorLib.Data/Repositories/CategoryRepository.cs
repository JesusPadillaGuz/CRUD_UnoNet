using BlazorLib.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace BlazorLib.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private SqlConfiguration _connectionString;

        public CategoryRepository(SqlConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(_connectionString.ConnectionString);
        }

        public async Task<bool> DeleteCategory(int id)
        {
            var db = dbConnection();
            var sql = @"DELETE Categories
                        WHERE Id = @Id";

            var result = await db.ExecuteAsync(sql, new { Id = id });
            return result > 0;
        }

        public async Task<IEnumerable<Categories>> GetAllCategories()
        {
            var db = dbConnection();
            var sql = @" SELECT Id,Name FROM Categories";
            return await db.QueryAsync<Categories>(sql, new { });
        }

        public async Task<Categories> GetCategory(int id)
        {
            var db = dbConnection();
            var sql = @" SELECT Id,Name FROM Categories
                        WHERE Id=@id";
            return await db.QueryFirstOrDefaultAsync<Categories>(sql, new { Id = id});
        }

        public async Task<bool> InsertCategory(Categories category)
        {
            var db = dbConnection();
            var sql = @"INSERT INTO Categories (Name)
                            VALUES (@Name)";
           
                var result = await db.ExecuteAsync(sql, new { category.Name });
                return result > 0;
          
           

           
        }

        public async Task<bool> UpdateCategory(Categories category)
        {
            var db = dbConnection();
            var sql = @"UPDATE Categories
                            SET Name = @Name
                            WhERE Id = @Id";

            var result = await db.ExecuteAsync(sql, new { category.Name, category.Id });

            return result > 0;
        }
    }
}
