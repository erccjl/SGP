namespace SGP.Aplicacion.Dtos
{
    public class CuentaDto : BaseEntityDto
    {
        public DateTime Periodo { get; set; }

        public double TopeGatos { get; set; }

        public bool IsActive { get; set; }

        public int ConsumidorId { get; set; }

        public ConsumidorDto Consumidor { get; set; }

        public List<MovimientoDto> Movimientos { get; set; }
    }
}
