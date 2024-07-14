namespace SGP.Aplicacion.Dtos
{
    public class ConsumidorDto : BaseEntityDto
    {
        public string Nombre { get; set; }

        public List<TarjetaDto> Tarjetas { get; set; }

        public List<CuentaDto> Cuentas { get; set; }
    }
}
