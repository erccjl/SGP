namespace SGP.Dominio.Entidades
{
    public class Cuenta : BaseEntity
    {
        public DateTime Periodo { get; set; }

        public double TopeGatos { get; set; }

        public bool IsActive { get; set; }

        public int ConsumidorId { get; set; }

        public virtual Consumidor Consumidor { get; set; }

        public virtual List<Movimiento> Movimientos { get; set; }

    }
}
