namespace SGP.Aplicacion.Dtos
{
    public class CuentaDto : BaseEntityDto
    {
        public int ConsumidorId { get; set; }

        public ConsumidorDto Consumidor { get; set; }

        public List<MovimientoDto> Movimientos { get; set; }
    }
}
