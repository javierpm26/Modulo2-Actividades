namespace Singleton_Marcador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SINGLETON ===");

            Marcador pantalla1 = Marcador.ObtenerInstancia();
            Marcador pantalla2 = Marcador.ObtenerInstancia();

            pantalla1.Puntos = 10;

            Console.WriteLine("Puntos en pantalla 1: " + pantalla1.Puntos);
            Console.WriteLine("Puntos en pantalla 2: " + pantalla2.Puntos);

            bool mismoObjeto = ReferenceEquals(pantalla1, pantalla2);

            Console.WriteLine("¿Es el mismo objeto? " + mismoObjeto);
        }
    }
}