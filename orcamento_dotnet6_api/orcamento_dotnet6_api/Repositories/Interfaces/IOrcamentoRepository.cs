using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using orcamento_dotnet6_api.Models;

namespace orcamento_dotnet6_api.Repositories.Interfaces
{
    public interface IOrcamentoRepository : IRepository<Orcamento>
    {
        Task<Orcamento> GetOrcamentoComItensAsync(int id);
    }
}
