using SGP.Dominio.Entidades;
using SGP.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Aplicacion.Dtos
{
    public class MovimientoDto : BaseEntityDto
    {
        public string Nombre { get; set; }

        public string Descipcion { get; set; }

        public FormaPago FormaPago { get; set; }

        public int CuentaId { get; set; }

        public CuentaDto? Cuenta { get; set; }

        public int? CuotaId { get; set; }

        public  CuotaDto Cuotas { get; set; }

        public int CategoriaId { get; set; }

        public CategoriaDto? Categoria { get; set; }

    }
}
