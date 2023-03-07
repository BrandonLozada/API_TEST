using Microsoft.AspNetCore.Mvc;

namespace API_TEST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppController : ControllerBase
    {
        [HttpGet] // Ejercicio 1
        [Route("Mensaje/{Nombre}")]
        public IActionResult Mensaje(string Nombre)
        {
            string Mensaje = "Hola " + Nombre + " esta es mi primer WEB API :)";

            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }

        [HttpGet] // Ejercicio 2
        [Route("Contacto/{Nombre}/{Edad}/{Direccion}")] // Note that the parameters at the "endpoint" do not need to specify the data type
        public IActionResult Contacto(string Nombre, string Edad, string Direccion)
        {
            Dictionary<string, string> dictContacto = new Dictionary<string, string>();

            dictContacto.Add("nombre", Nombre);
            dictContacto.Add("edad", Edad);
            dictContacto.Add("dirección", Direccion);

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
            string Resultado = "La suma es : " + (Num1 + Num2);

            return StatusCode(StatusCodes.Status200OK, Resultado);
        }

        [HttpGet] // Ejercicio 4
        [Route("Resta/{Num1:int}/{Num2:int}")]
        public IActionResult Resta(int Num1, int Num2)
        {
            string Resultado = "La resta es : " + (Num1 - Num2);

            return StatusCode(StatusCodes.Status200OK, Resultado);
        }

        [HttpGet] // Ejercicio 5
        [Route("Multiplica/{Num1:int}/{Num2:int}")]
        public IActionResult Multiplica(int Num1, int Num2)
        {
            string Resultado = "La multiplicación es : " + (Num1 * Num2);

            return StatusCode(StatusCodes.Status200OK, Resultado);
        }

        [HttpGet] //Ejercicio 6
        [Route("Promedio/{Calif1:double}/{Calif2:double}/{Calif3:Double}")]
        public IActionResult Promedio(double Calif1, double Calif2, double Calif3)
        {
            List<double> lstCalificaciones = new List<double> { };
            lstCalificaciones.Add(Calif1);
            lstCalificaciones.Add(Calif2);
            lstCalificaciones.Add(Calif3);

            double Promedio = lstCalificaciones.Average();
            string Mensaje = "Promedio: " + Promedio;

            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }

        [HttpGet] //Ejercicio 7
        [Route("ElevarAlCuadrado/{Num:double}")]
        public IActionResult ElevarAlCuadrado(double Num)
        {
            double Resultado = Math.Pow(Num, 2);
            string Mensaje = "El número: " + Num + " elevado al cuadrado es " + Resultado;

            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }

        [HttpGet] // Ejercicio 8
        [Route("AreaCuadrado/{Lado:double}")]
        public IActionResult AreaCuadrado(double Lado)
        {
            string Resultado = "El área del cuadrado es: " + (Lado * Lado);

            return StatusCode(StatusCodes.Status200OK, Resultado);
        }

        [HttpGet] // Ejercicio 9
        [Route("PerimetroCuadrado/{Lado:double}")]
        public IActionResult PerimetroCuadrado(double Lado)
        {
            string Resultado = "El perímetro del cuadrado es: " + (Lado * 4);

            return StatusCode(StatusCodes.Status200OK, Resultado);
        }

        [HttpGet] // Ejercicio 10
        [Route("AreaCirculo/{Radio:double}")]
        public IActionResult AreaCirculo(double Radio)
        {
            double Resultado = Math.PI * (Radio * Radio);

            string Mensaje = "El área del círculo es: " + Resultado;

            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }

        [HttpGet] // Ejercicio 11
        [Route("PerimetroCirculo/{Radio:double}")]
        public IActionResult PerimetroCirculo(double Radio)
        {
            double Resultado = 2 * Math.PI * Radio;

            string Mensaje = "El perímetro del círculo es: " + Resultado;

            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }

        [HttpGet] // Ejercicio 12
        [Route("AreaRectangulo/{Base:double}/{Altura:double}")]
        public IActionResult AreaRectangulo(double Base, double Altura)
        {
            string Resultado = "El área del rectángulo es: " + (Base * Altura);

            return StatusCode(StatusCodes.Status200OK, Resultado);
        }

        [HttpGet] // Ejercicio 13
        [Route("AreaTriangulo/{Base:double}/{Altura:double}")]
        public IActionResult AreaTriangulo(double Base, double Altura)
        {
            string Resultado = "El área del triángulo es: " + ((Base * Altura) / 2);

            return StatusCode(StatusCodes.Status200OK, Resultado);
        }

        [HttpGet] // Ejercicio 14
        [Route("PorcentajeCantidad/{Cantidad:double}/{Porcentaje:double}")]
        public IActionResult PorcentajeCantidad(double Cantidad, double Porcentaje)
        {
            double Resultado = (Cantidad * Porcentaje) / 100;
            string Mensaje = "El " + Porcentaje + " % de " + Cantidad + " es: " + Resultado;

            return StatusCode(StatusCodes.Status200OK, Mensaje);
        }

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
