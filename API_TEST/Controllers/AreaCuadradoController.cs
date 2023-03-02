using Microsoft.AspNetCore.Mvc;

namespace API_TEST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AreaCuadradoController : Controller
    {
        [HttpGet] // Ejercicio 8
        [Route("AreaCuadrado/{Lado:double}")]
        public IActionResult AreaCuadrado(double Lado)
        {
            string Resultado = "El área del cuadrado es: " + (Lado * Lado);

            return StatusCode(StatusCodes.Status200OK, Resultado);
        }
    }
}
