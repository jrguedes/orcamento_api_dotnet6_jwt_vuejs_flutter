using orcamento_dotnet6_api.Models;

namespace orcamento_dotnet6_api.Repositories.Interfaces
{
    public interface IRepository<T> where T: ModelBase
    {
         Task<T> InsertAsync(T model);
         Task<T> UpdateAsync(T model);         
         Task<bool> DeleteAsync(int id);
         Task<T> GetAsync(int id, string include = null);
         Task<IEnumerable<T>> GetAsync(string include = null);
         Task<bool> ExistsAsync(int id);
    }
}
