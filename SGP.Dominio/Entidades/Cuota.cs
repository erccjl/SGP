namespace SGP.Dominio.Entidades
{
    public class Cuota : BaseEntity
    {
        public int NumeroCuotas { get; set; }

        public DateTime MesInicio { get; set; }

       // public bool Finalizada {  get; set; } //TODO: Modificar para mejorar los tiempos al momento de buscar los movimientos

    }
}
