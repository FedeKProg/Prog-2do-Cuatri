using Entidades;

namespace Clase12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MiClaseGenerica<Persona> miClaseGenerica = new MiClaseGenerica<Persona>();
            MiClaseGenerica<Animal> miClaseGenerica2 = new MiClaseGenerica<Animal>();
            miClaseGenerica.ImprimirValor(Persona);

            Console.WriteLine("Hello, World!");
        }
    }
}