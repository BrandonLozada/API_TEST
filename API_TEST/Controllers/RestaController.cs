using Microsoft.AspNetCore.Mvc;

namespace API_TEST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaController : Controller
    {
        [HttpGet] // Ejercicio 4
        [Route("Resta/{Num1:int}/{Num2:int}")]
        public IActionResult Resta(int Num1, int Num2)
        {
            String Resultado = "La resta es : " + (Num1 - Num2);

            return StatusCode(StatusCodes.Status200OK, Resultado);
        }
    }
}
