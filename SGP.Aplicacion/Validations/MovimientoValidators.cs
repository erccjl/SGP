using FluentValidation;
using SGP.Aplicacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Aplicacion.Validations
{
    public class MovimientoValidators : AbstractValidator<MovimientoDto>
    {
        public MovimientoValidators()
        {
            RuleFor(c => c.Descipcion).NotNull().NotEmpty();
        }
    }
}
