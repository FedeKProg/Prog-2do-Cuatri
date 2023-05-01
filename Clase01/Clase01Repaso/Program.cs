namespace Clase01Repaso
{

    internal class Clase01Repaso
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numeros = new int[3];

            //numeros[0] = 10;
            //numeros[1] = 20;
            //numeros[2] = 30;
            //foreach (var numero in numeros)
            //{
            //    Console.WriteLine(numero);
            //}


            //Console.WriteLine("hola fede");
            //string saludo;
            //Console.WriteLine("ingrese un saludo");
            //saludo = Console.ReadLine();
            //Console.WriteLine("el saludo ingresado es {0}", saludo);

            //Console.ReadKey();

            string numeroIngresado;
            int resultado;
            int numConvert;
            bool resultadoConversion;

            Console.Title = "Practica de fede";

            Console.WriteLine("Ingrese un numero");
            numeroIngresado = Console.ReadLine();
            resultadoConversion= int.TryParse(numeroIngresado, out numConvert);
            resultado = numConvert + 10;

            if (resultadoConversion)
            {
                Console.WriteLine("la suma del numero ingresado + 10 es: {0}", resultado);
            }
            else
            {
                Console.WriteLine("No se ingreso un numero");
            }
           

        }


    }




}