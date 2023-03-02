using Microsoft.AspNetCore.Mvc;

namespace API_TEST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactoController : Controller
    {
        [HttpGet] // Ejercicio 2
        [Route("Contacto/{Nombre}/{Edad}/{Direccion}")] // Note that the parameters at the "endpoint" do not need to specify the data type
        public IActionResult Contacto(string Nombre, string Edad, string Direccion)
        {
            Dictionary<string, string> dictContacto = new Dictionary<string, string>();

            dictContacto.Add("Nombre", Nombre);
            dictContacto.Add("Edad", Edad);
            dictContacto.Add("Direccion", Direccion);

            List<string> lstResultado = new List<string>();

            foreach (var (key, value) in dictContacto)
            {
                lstResultado.Add("Tu " + key + " es " + value);
            }
            return StatusCode(StatusCodes.Status200OK, lstResultado);
        }
    }
}
