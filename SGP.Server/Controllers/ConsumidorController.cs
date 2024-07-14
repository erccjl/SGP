using Microsoft.AspNetCore.Mvc;
using SGP.Aplicacion.Dtos;
using SGP.Aplicacion.Services.Implementaciones;
using SGP.Aplicacion.Services.Interfaces;

namespace SGP.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConsumidorController : GenericController<IConsumidorService, ConsumidorDto>
    {
        private readonly IConsumidorService _consumidorService;

        public ConsumidorController(IConsumidorService consumidorService)
            : base(consumidorService)
        {
            _consumidorService = consumidorService;
        }


    }
}
