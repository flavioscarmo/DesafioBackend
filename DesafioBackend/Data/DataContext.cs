using DesafioBackend.Model;
using Microsoft.EntityFrameworkCore;

namespace DesafioBackend.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
                
        }

        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<TipoDeClienteModel> TipodeClientes { get; set; }
        public DbSet<TipoMaterialModel> TipoMaterial { get; set; }
        public DbSet<DddModel> Ddd { get; set; }
    }
}
