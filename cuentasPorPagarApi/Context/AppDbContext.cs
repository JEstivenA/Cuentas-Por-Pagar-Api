using cuentasPorPagarApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace cuentasPorPagarApi.Context
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) 
        {
        }

        public DbSet<Factura> Facturas { get; set; }
        public DbSet<MovimientosDeCuentas> MovimientosDeCuentas { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
