namespace SGP.Dominio.Entidades
{
    public class Cuenta : BaseEntity
    {
        public int ConsumidorId { get; set; }

        public virtual Consumidor Consumidor { get; set; }

        public virtual List<Movimiento> Movimientos { get; set; }

    }
}
