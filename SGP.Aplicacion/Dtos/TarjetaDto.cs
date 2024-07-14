namespace SGP.Aplicacion.Dtos
{
    public class TarjetaDto : BaseEntityDto
    {
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public List<MovimientoDto>? Movimientos { get; set; }

        public int? ConsumidorId { get; set; }

        public ConsumidorDto? Consumidor { get; set; }
    }
}
