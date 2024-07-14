using SGP.Dominio.Enums;

namespace SGP.Dominio.Entidades
{
    public class Movimiento : BaseEntity
    {
        public string Descipcion { get; set; }

        public TipoMovimiento TipoMovimiento { get; set; }

        public bool IsSuma { get; set; }

        public int? CuentaId { get; set; }

        public virtual Cuenta? Cuenta { get; set; }

        public int? CuotaId { get; set; }

        public virtual Cuota? Cuotas { get; set; }

        public int? CategoriaId { get; set; }

        public virtual Categoria? Categoria { get; set; }

        public int? TarjetaId { get; set; }

        public virtual Tarjeta? Tarjeta { get; set; }

    }
}
