using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Dominio.Entidades
{
    public class MovimientoTarjeta : Movimiento
    {
        public int TarjetaId { get; set; }
        public virtual Tarjeta Tarjeta { get; set; }
    }
}
