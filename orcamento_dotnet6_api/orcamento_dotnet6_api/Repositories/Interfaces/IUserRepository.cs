using orcamento_dotnet6_api.Models;

namespace orcamento_dotnet6_api.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>    
    {
         Task<User> SignIn(Login login);
    }
}
