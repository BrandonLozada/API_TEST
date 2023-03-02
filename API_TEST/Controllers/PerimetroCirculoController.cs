using Microsoft.AspNetCore.Mvc;

namespace API_TEST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PerimetroCirculoController : Controller
    {
        [HttpGet] // Ejercicio 11
        [Route("PerimetroCirculo/{Radio:double}")]
        public IActionResult PerimetroCirculo(double Radio)
        {
            double Resultado = 2 * Math.PI * Radio;

            string Mensaje = "El perímetro del círculo es: " + Resultado;

            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }
    }
}
