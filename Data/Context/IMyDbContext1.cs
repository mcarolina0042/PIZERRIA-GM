using Microsoft.EntityFrameworkCore;
using PIZERRIAGM.Data.Entities;

namespace PIZERRIAGM.Data.Context
{
    public interface IMyDbContext1
    {
       public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}