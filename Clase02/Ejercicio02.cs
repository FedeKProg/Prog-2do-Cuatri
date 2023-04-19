using System.ComponentModel.DataAnnotations;
using Ejercicio02;

namespace Clase02
{

    internal class Ejercicio02
    //Nombre de la mascota
    //Edad(Validar 1 - 12)
    //Tipo: (Validar “gato”, “perro”, “hamster”)
    //Peso: (Validar 0 - 50)
    //Diagnostico: (Validar  “otitis”, “alergias”, “parasitos”,)

    //Informes:

    //Nombre de la mascota más vieja
    //Cantidad de mascotas con parásitos
    //Nombre, edad y diagnóstico de la mascota más joven ingresada.
    {
        static void Main(string[] args)
        {
            //string nombre;
            //int edad;
            //string tipoMascota;
            //float peso;
            //string diagnostico;

            //Console.WriteLine("Ingrese el nombre de su mascota");
            //nombre = Console.ReadLine();

            //Console.WriteLine("Ingrese la edad de su mascota");
            //int.TryParse(Console.ReadLine(), out edad);

            //while ( edad<1 || edad > 12)
            //{
            //    Console.WriteLine("Edad ingresada invalida. Ingrese una edad entre 1-12");
            //    int.TryParse(Console.ReadLine(), out edad);
            //}

            //Console.WriteLine("Ingrese el tipo de mascota. Gato, Perro o  Hamster");
            //tipoMascota = Console.ReadLine();

            //while (tipoMascota != "gato" && tipoMascota != "perro" && tipoMascota != "hamster")
            //{
            //    Console.WriteLine("tipo ingreasdo no es valido. Ingrese Gato, Perro o  Hamster");
            //    tipoMascota = Console.ReadLine();
            //}

            //Console.WriteLine(edad);
            //Console.WriteLine(nombre);
            //Console.WriteLine(tipoMascota);

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

            for (int i = 0; i <10; i++)
            {
                Console.WriteLine("ingrese un numero");
                numeroIngresado = Console.ReadLine();
                cantNumeros += 1;
                resultadoConversion = int.TryParse(numeroIngresado, out numeroConvertido);
                if (resultadoConversion)
                {

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
            Console.WriteLine("El numero mayor es {0}, y el numero menor es {1}. El promedio de todos los numeros es {2}", numeroMayor, numeroMenor, promedio);
            Console.WriteLine(cantNumeros);

            Console.ReadKey();

        }
    }

}