using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Aplicacion.Dtos
{
    public class MovimientoTarjetaDto : MovimientoDto
    {
        public int TarjetaId { get; set; }

        public string TarjetaName { get; set; }
    }
}
