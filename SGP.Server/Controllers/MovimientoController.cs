using Microsoft.AspNetCore.Mvc;
using SGP.Aplicacion.Dtos;
using SGP.Aplicacion.Services.Interfaces;

namespace SGP.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovimientoController : GenericController<IMovimientoService, MovimientoDto>
    {
        private readonly IMovimientoService _movimientoService;


        public MovimientoController(IMovimientoService movimientoService)
            : base(movimientoService)
        {
            _movimientoService = movimientoService;
        }

    }
}
