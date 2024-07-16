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

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Tarjeta> Tarjetas { get; set;}

        public DbSet<Consumidor> Consumidores { get; set;}

        public DbSet<Cuenta> Cuentas { get; set;}

        public DbSet<MovimientoTarjeta> MovimientosTarjeta { get; set;}

        public DbSet<MovimientoEfectivo> MovimientosEfectivo { get; set;}

        public DbSet<Cuota> Cuotas { get; set;}

        public DbSet<Usuario> Usuarios { get; set;}


    }
}
