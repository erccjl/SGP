using Microsoft.AspNetCore.Mvc;
using SGP.Aplicacion.Dtos;
using SGP.Aplicacion.Services.Implementaciones;

namespace SGP.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly JwtService _tokenUtils;

        public AuthController(JwtService tokenUtils)
        {
            _tokenUtils = tokenUtils;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UserLoginDto userLogin)
        {
            // Aquí iría la lógica para validar las credenciales del usuario
            if (userLogin.Username == "admin" && userLogin.Password == "password") // Simulación de validación
            {
                var token = _tokenUtils.GenerateJwtToken(userLogin.Username);
                return Ok(new { Token = token });
            }
            return Unauthorized();
        }
    }
}
