using Entidades;

namespace Clase03Repaso
{
    class Program { 
        static void Main(string[] args)
        {
            ConsoleColor colorOriginalDeConsola = Console.ForegroundColor;
            string dibujo; //Variable para dibujar


            Boligrafo boligrafoDarkYellow = new Boligrafo(100, ConsoleColor.DarkYellow);
            Console.ForegroundColor = boligrafoDarkYellow.GetColor();
            boligrafoDarkYellow.Pintar(50, out dibujo);
            Console.WriteLine(dibujo);

            Console.ForegroundColor = colorOriginalDeConsola;
            Console.WriteLine($"El nivel de tinta del boligrafo DarkYellow es {boligrafoDarkYellow.GetTinta()}");
            boligrafoDarkYellow.Pintar(25, out dibujo);
            Console.ForegroundColor = boligrafoDarkYellow.GetColor();

            Console.WriteLine(dibujo);

            Console.ForegroundColor = colorOriginalDeConsola;

            Console.WriteLine($"El nivel de tinta del boligrafo DarkYellow es {boligrafoDarkYellow.GetTinta()}");
            Console.WriteLine("\n\nIntentamos volver a gastar tinta");
            boligrafoDarkYellow.Pintar(3, out dibujo);
            Console.WriteLine(dibujo);
            Console.ReadKey();

        }
}
}