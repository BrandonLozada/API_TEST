using Microsoft.AspNetCore.Mvc;

namespace API_TEST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ElevarAlCuadradoController : Controller
    {
        [HttpGet] //Ejercicio 7
        [Route("ElevarAlCuadrado/{Num:double}")]
        public IActionResult ElevarAlCuadrado(double Num)
        {
            double Resultado = Math.Pow(Num, 2);
            String Mensaje = "El número: " + Num + " elevado al cuadrado es " + Resultado;

            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }
    }
}
