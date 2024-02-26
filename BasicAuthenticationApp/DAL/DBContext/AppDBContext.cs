using System.Data;
using Npgsql;

namespace BasicAuthenticationApp.DAL.DBContext;

public class AppDBContext(IConfiguration configuration)
{
    private readonly string _connectionString = configuration.GetConnectionString("PostgresConn") ?? throw new InvalidOperationException("Postgresql Connection string invalid!");

    public IDbConnection CreateConnection() => new NpgsqlConnection(_connectionString);
}