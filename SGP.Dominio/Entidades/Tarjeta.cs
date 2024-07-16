namespace SGP.Dominio.Entidades
{
    public class Tarjeta : BaseEntity
    {
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int ConsumidorId { get; set; }

        public virtual Consumidor Consumidor { get; set; }

    }
}
