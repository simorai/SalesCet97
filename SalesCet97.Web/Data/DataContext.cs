using Microsoft.EntityFrameworkCore;
using SalesCet97.Web.Data.Entities;

namespace SalesCet97.Web.Data
{
    public class DataContext : DbContext
    {
        // Constructor para inicializar o contexto com as opções fornecidas por injeção de dependência
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        // Propriedade DbSet para a entidade Country
        public DbSet<Country> Countries { get; set; }
    }
}
