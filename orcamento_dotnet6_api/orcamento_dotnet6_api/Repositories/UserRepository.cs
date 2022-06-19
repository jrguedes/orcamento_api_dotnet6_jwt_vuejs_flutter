using Microsoft.EntityFrameworkCore;
using orcamento_dotnet6_api.AppDbContextSQLite;
using orcamento_dotnet6_api.Models;
using orcamento_dotnet6_api.Repositories.Interfaces;

namespace orcamento_dotnet6_api.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
            _dataset = _context.Set<User>();
        }

        public async Task<User> SignIn(Login login)
        {
            try
            {
                return await _dataset.SingleOrDefaultAsync(p => p.Email.Equals(login.Email) && p.Password.Equals(login.Password));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
