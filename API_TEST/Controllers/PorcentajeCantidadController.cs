using Microsoft.AspNetCore.Mvc;

namespace API_TEST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PorcentajeCantidadController : Controller
    {
        [HttpGet] // Ejercicio 14
        [Route("PorcentajeCantidad/{Cantidad:double}/{Porcentaje:double}")]
        public IActionResult PorcentajeCantidad(double Cantidad, double Porcentaje)
        {
            double Resultado = (Cantidad * Porcentaje) / 100;
            string Mensaje = "El " + Porcentaje + " % de " + Cantidad + " es: " + Resultado;

            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }
    }
}
