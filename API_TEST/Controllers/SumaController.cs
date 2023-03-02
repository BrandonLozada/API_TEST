using Microsoft.AspNetCore.Mvc;

namespace API_TEST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SumaController : Controller
    {
        [HttpGet] // Ejercicio 3
        [Route("Suma/{Num1:int}/{Num2:int}")]
        public IActionResult Suma(int Num1, int Num2)
        {
            String Resultado = "La suma es : " + (Num1 + Num2);

            return StatusCode(StatusCodes.Status200OK, Resultado);
            //return StatusCode(StatusCodes.Status200OK, new { Resultado });
        }
    }
}
