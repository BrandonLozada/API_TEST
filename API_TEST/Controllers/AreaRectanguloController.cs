using Microsoft.AspNetCore.Mvc;

namespace API_TEST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AreaRectanguloController : Controller
    {
        [HttpGet] // Ejercicio 12
        [Route("AreaRectangulo/{Base:double}/{Altura:double}")]
        public IActionResult AreaRectangulo(double Base, double Altura)
        {
            string Resultado = "El área del rectángulo es: " + (Base * Altura);

            return StatusCode(StatusCodes.Status200OK, Resultado);
        }
    }
}
