namespace SGP.Dominio.Entidades
{
    public class Cuota : BaseEntity
    {
        public int NumeroCuotas { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin
        {
            get { return FechaInicio.AddMonths(NumeroCuotas); }
        }
    }
}
