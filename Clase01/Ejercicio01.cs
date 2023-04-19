using System.Xml.Schema;

namespace Clase01
{
    internal class Ejercicio01
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.ReadKey();
            //Ingresar 5 numeros, sacar el maximo, el minimo y el promedio de todos

            string numeroIngresado;
            int numeroConvertido;
            int numeroMayor = int.MinValue;
            int numeroMenor = int.MaxValue;
            bool resultadoConversion;
            int cantNumeros = 0;
            float promedio = 0;
            float total = 0;


            //Console.WriteLine("ingrese un numero");
            //numeroIngresado = Console.ReadLine();
            ;

            for (int i=0; i<5; i++)
            {
                Console.WriteLine("ingrese un numero");
                numeroIngresado = Console.ReadLine();
                cantNumeros += 1;
                resultadoConversion = int.TryParse(numeroIngresado, out numeroConvertido);
                if (resultadoConversion) {
                    
                    if (numeroConvertido > numeroMayor)
                    {
                        numeroMayor = numeroConvertido;
                    }
                    if (numeroConvertido < numeroMenor) 
                    {
                        numeroMenor = numeroConvertido;
                    }
                    total += numeroConvertido;
                }
            
            }
            promedio = total / cantNumeros;
            Console.WriteLine("El numero mayor es {0}, y el numero menor es {1}. El promedio de todos los numeros es {2}", numeroMayor, numeroMenor,promedio);
            Console.WriteLine(cantNumeros);        
        }   


    }
}