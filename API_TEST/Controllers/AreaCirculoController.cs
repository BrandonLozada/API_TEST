using Microsoft.AspNetCore.Mvc;

namespace API_TEST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AreaCirculoController : Controller
    {
        [HttpGet] // Ejercicio 10
        [Route("AreaCirculo/{Radio:double}")]
        public IActionResult AreaCirculo(double Radio)
        {
            double Resultado = Math.PI * (Radio * Radio);

            string Mensaje = "El área del círculo es: " + Resultado;

            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }
    }
}
