using SGP.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Aplicacion.Dtos
{
    public class CategoriaDto : BaseEntityDto
    {
        public string Descripcion { get; set; }

        public bool EsSuma { get; set; }

        public List<MovimientoDto>? Movimientos { get; set; }
    }
}
