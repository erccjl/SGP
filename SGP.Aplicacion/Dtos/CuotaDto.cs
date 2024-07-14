using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Aplicacion.Dtos
{
    public class CuotaDto : BaseEntityDto
    {
        public int NumeroCuotas { get; set; }

        public DateTime MesInicio { get; set; }

        // public bool Finalizada {  get; set; } //TODO: Modificar para mejorar los tiempos al momento de buscar los movimientos

    }
}
