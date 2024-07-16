namespace SGP.Aplicacion.Dtos
{
    public class ConsumidorDto : BaseEntityDto
    {
        public string Nombre { get; set; }

        public string Email { get; set; }

        public DateTime FechaNacimiento { get; set; }
        
        public string Telefono { get; set; }

        public double TopeGasto { get; set; }

        public List<TarjetaDto> Tarjetas { get; set; }

        public List<CuentaDto> Cuentas { get; set; }
    }
}
