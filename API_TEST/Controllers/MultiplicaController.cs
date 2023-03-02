using Microsoft.AspNetCore.Mvc;

namespace API_TEST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MultiplicaController : Controller
    {
        [HttpGet] // Ejercicio 5
        [Route("Multiplica/{Num1:int}/{Num2:int}")]
        public IActionResult Multiplica(int Num1, int Num2)
        {
            String Resultado = "La multiplicación es : " + (Num1 * Num2);

            return StatusCode(StatusCodes.Status200OK, Resultado);
        }
    }
}
