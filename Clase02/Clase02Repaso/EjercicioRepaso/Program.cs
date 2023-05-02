using System.Linq;
using Entidades;
namespace EjercicioRepaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NombreMascota;
            int edadMascota;
            string tipoMascota;
            int pesoMascota;
            string diagnostico;

            Console.WriteLine("Ingrese el nombre de la mascota");
            NombreMascota = Console.ReadLine();


            Validador.validarNumero("Ingrese la edad de la mascota (1-12)", out edadMascota, 1, 12);


            Validador.validarStrings("Ingrese el tipo de la mascota de la mascota (gato, perro o hamster)", out tipoMascota, "gato", "perro", "hamster");

            Validador.validarNumero("Ingrese el peso de la mascota (0-50)", out pesoMascota, 0, 50);

            Validador.validarStrings("Ingrese el diagnostico tipo de la mascota de la mascota (parasitos, otitis, alergias)", out diagnostico, "parasitos", "otitis", "alergias");


            Console.WriteLine(NombreMascota);
            Console.WriteLine(edadMascota);
            Console.WriteLine(tipoMascota);
            Console.WriteLine(pesoMascota);
            Console.WriteLine(diagnostico);

            Console.ReadKey();
        }
    }
}