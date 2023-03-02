using Microsoft.AspNetCore.Mvc;

namespace API_TEST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConversionUSDController : Controller
    {
        [HttpGet] //Ejercicio 15
        [Route("ConversionUSDaMXN/{Dollars:decimal}")]
        public IActionResult ConversionUSDaMXN(decimal Dollars)
        {

            decimal precioDollar = 18.37m;
            decimal Resultado = Dollars * precioDollar;
            string Mensaje = "La conversión de " + Dollars + " USD es igual a " + Resultado + " MXN";

            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }

        [HttpGet] //Ejercicio 16
        [Route("ConversionUSDaEUR/{Dollars:decimal}")]
        public IActionResult ConversionUSDaEUR(decimal Dollars)
        {

            decimal precioDollar = 0.94m;
            decimal Resultado = Dollars * precioDollar;
            string Mensaje = "La conversión de " + Dollars + " USD es igual a " + Resultado + " EUR";

            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }
    }
}
