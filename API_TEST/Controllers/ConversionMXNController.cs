using Microsoft.AspNetCore.Mvc;

namespace API_TEST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConversionMXNController : Controller
    {
        [HttpGet] //Ejercicio 17
        [Route("ConversionMXNaUSD/{Pesos:decimal}")]
        public IActionResult ConversionMXNaUSD(decimal Pesos)
        {

            decimal precioPeso = 0.054m;
            decimal Resultado = Pesos * precioPeso;
            string Mensaje = "La conversión de " + Pesos + " MXN es igual a " + Resultado + " USD";

            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }

        [HttpGet] //Ejercicio 18
        [Route("ConversionMXNaEUR/{Pesos:decimal}")]
        public IActionResult ConversionMXNaEUR(decimal Pesos)
        {

            decimal precioPeso = 0.051m;
            decimal Resultado = Pesos * precioPeso;
            string Mensaje = "La conversión de " + Pesos + " MXN es igual a " + Resultado + " EUR";

            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }
    }
}
