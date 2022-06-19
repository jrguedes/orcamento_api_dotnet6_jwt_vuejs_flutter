using Microsoft.EntityFrameworkCore;
using orcamento_dotnet6_api.Models;

namespace orcamento_dotnet6_api.AppDbContextSQLite
{
     

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Orcamento> Orcamentos { get; set; }
        public DbSet<ItemOrcamento> ItensOrcamento { get; set; }
        public DbSet<User> Users { get; set; }
        
    }
}
