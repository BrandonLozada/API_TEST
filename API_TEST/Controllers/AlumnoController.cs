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

        [HttpGet] // Ejercicio 1
        [Route("Mensaje/{Nombre}")]
        public IActionResult Mensaje(String Nombre)
        {
            String Mensaje = "Hola " + Nombre + " esta es mi primer WEB API :)";

            //return StatusCode(StatusCodes.Status200OK, new { Mensaje });
            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }

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

        [HttpGet] // Ejercicio 3
        [Route("Suma/{Num1:int}/{Num2:int}")]
        public IActionResult Suma(int Num1, int Num2)
        {
            String Resultado = "La suma es : " + (Num1 + Num2);

            return StatusCode(StatusCodes.Status200OK, Resultado);
            //return StatusCode(StatusCodes.Status200OK, new { Resultado });
        }

        [HttpGet] // Ejercicio 4
        [Route("Resta/{Num1:int}/{Num2:int}")]
        public IActionResult Resta(int Num1, int Num2)
        {
            String Resultado = "La resta es : " + (Num1 - Num2);

            return StatusCode(StatusCodes.Status200OK, Resultado);
        }

        [HttpGet] // Ejercicio 5
        [Route("Multiplica/{Num1:int}/{Num2:int}")]
        public IActionResult Multiplica(int Num1, int Num2)
        {
            String Resultado = "La multiplicación es : " + (Num1 * Num2);

            return StatusCode(StatusCodes.Status200OK, Resultado);
        }

        [HttpGet] //Ejercicio 15
        [Route("ConversionUSDaMXN/{Dollars:decimal}")]
        public IActionResult ConversionUSDaMXN(decimal Dollars)
        {

            decimal precioDollar = 18.37m;
            decimal Resultado = Dollars * precioDollar;
            String Mensaje = "La conversión de " + Dollars + " USD es igual a " + Resultado + " MXN";

            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }

        [HttpGet] //Ejercicio 16
        [Route("ConversionUSDaEUR/{Dollars:decimal}")]
        public IActionResult ConversionUSDaEUR(decimal Dollars)
        {

            decimal precioDollar = 0.94m;
            decimal Resultado = Dollars * precioDollar;
            String Mensaje = "La conversión de " + Dollars + " USD es igual a " + Resultado + " EUR";

            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }

        [HttpGet] //Ejercicio 17
        [Route("ConversionMXNaUSD/{Pesos:decimal}")]
        public IActionResult ConversionMXNaUSD(decimal Pesos)
        {

            decimal precioPeso = 0.054m;
            decimal Resultado = Pesos * precioPeso;
            String Mensaje = "La conversión de " + Pesos + " MXN es igual a " + Resultado + " USD";

            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }

        [HttpGet] //Ejercicio 18
        [Route("ConversionMXNaEUR/{Pesos:decimal}")]
        public IActionResult ConversionMXNaEUR(decimal Pesos)
        {

            decimal precioPeso = 0.051m;
            decimal Resultado = Pesos * precioPeso;
            String Mensaje = "La conversión de " + Pesos + " MXN es igual a " + Resultado + " EUR";

            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }

        [HttpGet] //Ejercicio 19
        [Route("ConversionEURaMXN/{Euros:decimal}")]
        public IActionResult ConversionEURaMXN(decimal Euros)
        {

            decimal precioEuro = 19.46m;
            decimal Resultado = Euros * precioEuro;
            String Mensaje = "La conversión de " + Euros + " EUR es igual a " + Resultado + " MXN";

            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }

        [HttpGet] //Ejercicio 20
        [Route("ConversionEURaUSD/{Euros:decimal}")]
        public IActionResult ConversionEURaUSD(decimal Euros)
        {

            decimal precioEuro = 1.06m;
            decimal Resultado = Euros * precioEuro;
            String Mensaje = "La conversión de " + Euros + " EUR es igual a " + Resultado + " USD";

            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }

    }
}
