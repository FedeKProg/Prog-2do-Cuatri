namespace ConsoleApp1
{
    internal class Ejercicio_mathpow
    {
        static void Main(string[] args)
        {
            string numeroIngresado;
            double cubo;
            double cuadrado;
            int numeroConvertido;
            bool resultadoConversion;

            Console.WriteLine("Ingrese un numero mayor a 0:");
            numeroIngresado = Console.ReadLine();
            resultadoConversion = int.TryParse(numeroIngresado, out numeroConvertido);

            if (resultadoConversion){
                while (numeroConvertido < 1)
                {
                    Console.WriteLine("ERROR, el numero ingresado es menor a 0");
                    Console.WriteLine("Ingrese un numero mayor a 0:");
                    numeroIngresado = Console.ReadLine();
                    int.TryParse(numeroIngresado, out numeroConvertido);
                }
            }

            cuadrado = Math.Pow(numeroConvertido, 2);
            cubo = Math.Pow(numeroConvertido, 3);

            Console.WriteLine("El cuadrado es {0} y el cubo es {1}",cuadrado, cubo);

            Console.ReadKey();
        }
    }
}