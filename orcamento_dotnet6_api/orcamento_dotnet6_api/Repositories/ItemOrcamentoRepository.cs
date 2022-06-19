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
    public class ItemOrcamentoRepository : RepositoryBase<ItemOrcamento>, IItemOrcamentoRepository
    {
        public ItemOrcamentoRepository(AppDbContext context) : base(context)
        {
            _dataset = _context.Set<ItemOrcamento>();
        }

        public async Task<IEnumerable<ItemOrcamento>> GetItensByOrcamentoAsync(int orcamentoId)
        {
            try
            {
                return await _dataset.Where(p => p.OrcamentoId == orcamentoId).Include(i => i.Orcamento).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
