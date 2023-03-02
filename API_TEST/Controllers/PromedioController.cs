using Microsoft.AspNetCore.Mvc;

namespace API_TEST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PromedioController : Controller
    {
        [HttpGet] //Ejercicio 6
        [Route("Promedio/{Calif1:double}/{Calif2:double}/{Calif3:Double}")]
        public IActionResult Promedio(double Calif1, double Calif2, double Calif3)
        {
            List<double> lstCalificaciones = new List<double> {};
            lstCalificaciones.Add(Calif1);
            lstCalificaciones.Add(Calif2);
            lstCalificaciones.Add(Calif3);

            double Promedio = lstCalificaciones.Average();
            string Mensaje = "Promedio: " + Promedio;

            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }
    }
}
