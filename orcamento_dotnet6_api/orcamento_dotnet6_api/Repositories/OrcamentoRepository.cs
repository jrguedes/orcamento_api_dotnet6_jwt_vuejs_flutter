using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using orcamento_dotnet6_api.AppDbContextSQLite;
using orcamento_dotnet6_api.Models;
using orcamento_dotnet6_api.Repositories.Interfaces;

namespace orcamento_dotnet6_api.Repositories
{
    public class OrcamentoRepository : RepositoryBase<Orcamento>, IOrcamentoRepository
    {
        public OrcamentoRepository(AppDbContext context) : base(context)
        {
            _dataset = _context.Set<Orcamento>();
        }

        public async Task<Orcamento> GetOrcamentoComItensAsync(int id)
        {
            try
            {
                return await _dataset.Where(p => p.Id == id).Include(i => i.ItensOrcamento).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
