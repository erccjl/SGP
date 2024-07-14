namespace SGP.Dominio.Entidades
{
    public class Consumidor : BaseEntity
    {
        public string Nombre { get; set; }

        public virtual List<Tarjeta> Tarjetas { get; set; }

        public virtual List<Cuenta> Cuentas { get; set; }
    }
}
