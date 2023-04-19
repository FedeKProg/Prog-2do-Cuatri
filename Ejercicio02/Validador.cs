namespace Ejercicio02
{
    public class Validador
    {
        public void ValidadorEnteros(string mensaje, out int valor, int min, int max)
        {
            Console.WriteLine(mensaje);
            int.TryParse(Console.ReadLine(), out valor);
            while (valor < min || valor > max)
            {
                Console.WriteLine($"Error. Valor ingresado no es valido, intente nuevamente con un valor entre {min} - {max}");
                Console.WriteLine(mensaje);
                int.TryParse (Console.ReadLine(), out valor);
            }
        }
    }
}