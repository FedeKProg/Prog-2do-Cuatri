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

            Console.WriteLine("Ingrese la edad de la mascota (1-12)");
            int.TryParse(Console.ReadLine(), out edadMascota);
            while (edadMascota < 1 || edadMascota > 12)
            {
                Console.WriteLine("La edad ingresada no es valida. Ingrese un valor entre 1-12");
                int.TryParse(Console.ReadLine(), out edadMascota);
            }

            Console.WriteLine("Ingrese el tipo de la mascota de la mascota (gato, perro o hamster)");
            tipoMascota = Console.ReadLine();
            while (tipoMascota != "gato" && tipoMascota != "perro" && tipoMascota != "hamster")
            {
                Console.WriteLine("el tipo ingresado no es valido. Ingrese un valor entre (gato, perro o hamster)");
                tipoMascota = Console.ReadLine();
            }

            Console.WriteLine("Ingrese el peso de la mascota");
            int.TryParse(Console.ReadLine(), out pesoMascota);
            while (pesoMascota < 0 || pesoMascota > 50)
            {
                Console.WriteLine("El peso ingresado no es valido. Ingrese un valor entre 0-50");
                int.TryParse(Console.ReadLine(), out pesoMascota);
            }

            Console.WriteLine("Ingrese el diagnostico de la mascota de la mascota (otitis, alergias, parasitos)");
            diagnostico = Console.ReadLine();
            while (diagnostico != "otitis" && diagnostico != "alergias" && diagnostico != "parasitos")
            {
                Console.WriteLine("el tipo ingresado no es valido. Ingrese el diagnostico de la mascota de la mascota (otitis, alergias, parasitos)");
                diagnostico = Console.ReadLine();
            }

            Console.WriteLine(NombreMascota);
            Console.WriteLine(edadMascota);
            Console.WriteLine(tipoMascota);
            Console.WriteLine(diagnostico);
        }
    }
}