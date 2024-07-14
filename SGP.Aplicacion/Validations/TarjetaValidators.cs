using FluentValidation;
using SGP.Aplicacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Aplicacion.Validations
{
    public class TarjetaValidators : AbstractValidator<TarjetaDto>
    {
        public TarjetaValidators()
        {
            RuleFor(c => c.Nombre).NotNull().NotEmpty();
        }
    }
}
