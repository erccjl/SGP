using SGP.Dominio.Enums;

namespace SGP.Dominio.Entidades
{
    public class Movimiento : BaseEntity
    {
        public string Nombre { get; set; }

        public string Descipcion { get; set; }

        public double Monto { get; set; }

        public FormaPago FormaPago { get; set; }

        public int CuentaId { get; set; }

        public virtual Cuenta Cuenta { get; set; }

        public int? CuotaId { get; set; }

        public virtual Cuota Cuota { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }

    }
}
