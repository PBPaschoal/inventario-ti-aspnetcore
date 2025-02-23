namespace InventarioTI.Data
{
    using Microsoft.EntityFrameworkCore;
    using global::InventarioTI.Data.Models;

    namespace InventarioTI.Data
    {
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

            public DbSet<Equipamento> Equipamentos { get; set; }
        }
    }
}
