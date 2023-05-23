using Microsoft.EntityFrameworkCore;
using PIZERRIAGM.Data.Entities;

namespace PIZERRIAGM.Data.Context
{
    public class MyDbContext : DbContext, IMyDbContext, IMyDbContext1
    {
        private readonly IConfiguration confg;

        public MyDbContext(IConfiguration confg)
        {
            this.confg = confg;
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(config.GetConnectionString("MSSQL"));
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
