namespace DEVisIT.SiFatto.Infrastructure.Repositories
{
    using Dapper;
    using DEVisIT.SiFatto.ApplicationCore.Interfaces.Repositories;
    using DEVisIT.SiFatto.Domain.Entities;
    using Microsoft.Data.SqlClient;
    using Microsoft.Extensions.Configuration;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /*
     TABELLA Questions
        id                  uniqueidentifier
        user_id             nvarchar(450)
        title               nvarchar(250)
        description         nvarchar(max)
        created_date        datetime
        last_updated_date   datetime
     */

    public class QuestionRepository : IQuestionRepository
    {
        private readonly string _connectionString;

        public QuestionRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<Question>> GetAllAsync()
        {
            const string query = @"
SELECT 
    id          as Id,
    user_id     as UserId,
    title       as Title,
    description as Description,
    created_date as CreatedDate,
    last_updated_date as LastUpdatedDate
FROM 
    Questions";
            using var connection = new SqlConnection(_connectionString);
            return await connection.QueryAsync<Question>(query);
        }

        public async Task<Question> GetByIdAsync(Guid id)
        {
            const string query = @"
SELECT 
    id          as Id,
    user_id     as UserId,
    title       as Title,
    description as Description,
    created_date as CreatedDate,
    last_updated_date as LastUpdatedDate
FROM 
    Questions
WHERE
    id = @id
";
            using var connection = new SqlConnection(_connectionString);
            return await connection.QueryFirstOrDefaultAsync<Question>(query, new { id });
        }

        public async Task<IEnumerable<Question>> GetQuestionsByUserAsync(string userId)
        {
            const string query = @"
SELECT 
    id          as Id,
    user_id     as UserId,
    title       as Title,
    description as Description,
    created_date as CreatedDate,
    last_updated_date as LastUpdatedDate
FROM 
    Questions
WHERE 
    user_id = @userId";
            using var connection = new SqlConnection(_connectionString);
            return await connection.QueryAsync<Question>(query, new { userId });
        }

        public async Task DeleteAsync(Guid id)
        {
            const string query = "DELETE FROM Questions WHERE id = @id";
            using var connection = new SqlConnection(_connectionString);
            await connection.ExecuteAsync(query, new { id });
        }

        public async Task InsertAsync(Question entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.LastUpdatedDate = entity.CreatedDate;

            const string query = @"
INSERT INTO Questions (id, user_id, title, description, created_date, last_updated_date)
VALUES (@Id, @UserId, @Title, @Description, @CreatedDate, @LastUpdatedDate)";

            using var connection = new SqlConnection(_connectionString);
            await connection.ExecuteAsync(query, entity);
        }

        public async Task UpdateAsync(Question entity)
        {
            entity.LastUpdatedDate = DateTime.Now;

            const string query = @"
UPDATE Questions 
SET 
    user_id = @UserId, 
    title = @Title, 
    description = @Description, 
    last_updated_date = @LastUpdatedDate)
WHERE id = @Id";

            using var connection = new SqlConnection(_connectionString);
            await connection.ExecuteAsync(query, entity);
        }

        public async Task<long> Count()
        {
            const string query = "SELECT Count(*) FROM Questions";
            using var connection = new SqlConnection(_connectionString);
            return await connection.ExecuteScalarAsync<long>(query);
        }
    }
}