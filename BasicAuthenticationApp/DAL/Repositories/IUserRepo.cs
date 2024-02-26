using BasicAuthenticationApp.Domain.Entities;

namespace BasicAuthenticationApp.DAL.Repositories;

public interface IUserRepo
{
    Task<User?> GetUserByUsername(string username);
}