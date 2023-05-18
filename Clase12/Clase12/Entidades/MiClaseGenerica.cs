namespace Entidades
{
    public class MiClaseGenerica<T> where T : Persona,new()
    {
       public void ImprimirValor(T generico)
        {
            Console.WriteLine(generico);
        }
    }
}