using Microsoft.EntityFrameworkCore;
using SGP.Dominio.Entidades;

namespace SGP.Datos.Context
{
    public class PresupuestoContext : DbContext
    {
        public PresupuestoContext(DbContextOptions<PresupuestoContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Categoria> Categotias { get; set; }

        public DbSet<Tarjeta> Tarjetas { get; set;}

        public DbSet<Consumidor> Consumidores { get; set;}

        public DbSet<Cuenta> Cuentas { get; set;}

        public DbSet<Movimiento> Movimientos { get; set;}

        public DbSet<Cuota> Cuotas { get; set;}

        public DbSet<Usuario> Usuarios { get; set;}


    }
}
