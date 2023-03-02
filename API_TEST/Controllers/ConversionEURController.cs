using Microsoft.AspNetCore.Mvc;

namespace API_TEST.Controllers
{
    public class ConversionEURController : Controller
    {
        [HttpGet] //Ejercicio 19
        [Route("ConversionEURaMXN/{Euros:decimal}")]
        public IActionResult ConversionEURaMXN(decimal Euros)
        {

            decimal precioEuro = 19.46m;
            decimal Resultado = Euros * precioEuro;
            string Mensaje = "La conversión de " + Euros + " EUR es igual a " + Resultado + " MXN";

            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }

        [HttpGet] //Ejercicio 20
        [Route("ConversionEURaUSD/{Euros:decimal}")]
        public IActionResult ConversionEURaUSD(decimal Euros)
        {

            decimal precioEuro = 1.06m;
            decimal Resultado = Euros * precioEuro;
            string Mensaje = "La conversión de " + Euros + " EUR es igual a " + Resultado + " USD";

            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }
    }
}
