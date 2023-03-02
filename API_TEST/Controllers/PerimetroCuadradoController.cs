using Microsoft.AspNetCore.Mvc;

namespace API_TEST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PerimetroCuadradoController : Controller
    {
        [HttpGet] // Ejercicio 9
        [Route("PerimetroCuadrado/{Lado:double}")]
        public IActionResult PerimetroCuadrado(double Lado)
        {
            String Resultado = "El perímetro del cuadrado es: " + (Lado * 4);

            return StatusCode(StatusCodes.Status200OK, Resultado);
        }
    }
}
