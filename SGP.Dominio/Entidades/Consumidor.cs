namespace SGP.Dominio.Entidades
{
    public class Consumidor : BaseEntity
    {
        public string Nombre { get; set; }

        public string Email { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Telefono { get; set; }

        public double TopeGasto { get; set; }

        public virtual List<Tarjeta> Tarjetas { get; set; }

        public virtual List<Cuenta> Cuentas { get; set; }
    }
}
