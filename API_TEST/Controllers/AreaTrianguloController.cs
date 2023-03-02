using Microsoft.AspNetCore.Mvc;

namespace API_TEST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AreaTrianguloController : Controller
    {
        [HttpGet] // Ejercicio 13
        [Route("AreaTriangulo/{Base:double}/{Altura:double}")]
        public IActionResult AreaTriangulo(double Base, double Altura)
        {
            string Resultado = "El área del triángulo es: " + ((Base * Altura)/2);

            return StatusCode(StatusCodes.Status200OK, Resultado);
        }
    }
}
