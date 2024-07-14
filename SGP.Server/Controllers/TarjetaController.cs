using Microsoft.AspNetCore.Mvc;
using SGP.Aplicacion.Dtos;
using SGP.Aplicacion.Services.Interfaces;

namespace SGP.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarjetaController : GenericController<ITarjetaService, TarjetaDto>
    {
        private readonly ITarjetaService _tarjetaService;

        public TarjetaController(ITarjetaService tarjetaService)
            : base(tarjetaService)
        {
            _tarjetaService = tarjetaService;
        }
    }
}
