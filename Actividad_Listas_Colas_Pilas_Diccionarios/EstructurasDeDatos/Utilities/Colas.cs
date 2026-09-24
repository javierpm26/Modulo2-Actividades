namespace EstructurasDeDatos.Utilities
{
    public static class Colas
    {
        // Ejercicio 7 - Cola del Supermecado
        public static void colaSupermercado()
        {
            Queue<string> colaDelSuper = new Queue<string>();
            colaDelSuper.Enqueue("Isabel");
            colaDelSuper.Enqueue("Luis");
            colaDelSuper.Enqueue("Carlos");
            colaDelSuper.Enqueue("Marta");

            Console.WriteLine("=== COLA DEL SUPERMERCADO ===\n");
            Console.WriteLine($"Primera persona: {colaDelSuper.Peek()}");
            colaDelSuper.Enqueue("Pedro");
            Console.WriteLine($"\nNueva persona: {colaDelSuper.Last()}");

            Console.WriteLine($"\nAtendiendo a: {colaDelSuper.Peek()}");
            colaDelSuper.Dequeue();
            Console.WriteLine($"Atendiendo a: {colaDelSuper.Peek()}");
            colaDelSuper.Dequeue();
            Console.WriteLine($"Ahora le toca a : {colaDelSuper.Peek()}");
            
            Console.WriteLine($"\nPersonas esperando: {colaDelSuper.Count()}");

        }
    }
}