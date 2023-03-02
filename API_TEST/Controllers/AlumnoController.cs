using Microsoft.AspNetCore.Mvc;

namespace API_TEST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlumnoController : ControllerBase
    {
        [HttpGet] // Ejemplo del maestro
        [Route("ListadoAlumno")]
        public IActionResult ListadoAlumno()
        {
            List<string> lstAlumno = new List<string> ();
            lstAlumno.Add("Sasha Grey");
            lstAlumno.Add("Mia Malkova");
            lstAlumno.Add("Abella Danger");
            lstAlumno.Add("Riley Reid");

            return StatusCode(StatusCodes.Status200OK, new { Codigo = "00", response = lstAlumno });
        }
    }
}
