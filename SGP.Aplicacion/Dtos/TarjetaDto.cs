namespace SGP.Aplicacion.Dtos
{
    public class TarjetaDto : BaseEntityDto
    {
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public List<MovimientoTarjetaDto>? Movimientos { get; set; }

        public int ConsumidorId { get; set; }

        public string ConsumidorName { get; set; }
    }
}
