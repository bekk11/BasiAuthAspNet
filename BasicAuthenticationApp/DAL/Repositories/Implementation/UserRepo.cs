using BasicAuthenticationApp.DAL.DBContext;
using BasicAuthenticationApp.Domain.Entities;
using Dapper;

namespace BasicAuthenticationApp.DAL.Repositories.Implementation;

public class UserRepo(AppDBContext dbContext) : IUserRepo
{
    public async Task<User?> GetUserByUsername(string username)
    {
        const string sql = "select * from base_auth_user where username = @Username";

        try
        {
            using var connection = dbContext.CreateConnection();
            return await connection.QuerySingleOrDefaultAsync(sql, new { Username = username });
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}