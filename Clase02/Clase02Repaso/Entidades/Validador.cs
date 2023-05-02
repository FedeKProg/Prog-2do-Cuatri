namespace Entidades
{
    public class Validador
    {
        public static void validarNumero(string mensaje, out int valor, int min, int max)
        {
            Console.WriteLine(mensaje);

            int.TryParse(Console.ReadLine(), out valor);
            while (valor < min || valor > max)
            {
                Console.WriteLine($"El valor es invalido. Ingresar valor entre {min}-{max}");
                Console.WriteLine(mensaje);
                int.TryParse(Console.ReadLine(), out valor);
            }
        }
        public static void validarStrings(string mensaje, out string valor, params string[] valores)
        {
            Console.WriteLine(mensaje);
            valor = Console.ReadLine();

            while (!valores.Contains(valor))
            {
                Console.WriteLine($"el tipo ingresado no es valido. Ingrese unvalor valido");
                valor = Console.ReadLine();
            }

        }
    }
}