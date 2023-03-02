using Microsoft.AspNetCore.Mvc;

namespace API_TEST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MensajeController : Controller
    {
        [HttpGet] // Ejercicio 1
        [Route("Mensaje/{Nombre}")]
        public IActionResult Mensaje(string Nombre)
        {
            string Mensaje = "Hola " + Nombre + " esta es mi primer WEB API :)";

            //return StatusCode(StatusCodes.Status200OK, new { Mensaje });
            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }
    }
}
