namespace EstructurasDeDatos.Utilities
{
    public static class Diccionarios
    {
        //Ejercicio 10 - Puntuaciones
        public static void PuntuacionesJugadores()
        {
            int opcionMenu = 0;
            Dictionary<string, int> scoreboard = new Dictionary<string, int>();

            scoreboard.Add("Isabel", 1200);
            scoreboard.Add("Luis", 950);
            scoreboard.Add("Carlos", 1430);
            scoreboard.Add("Marta", 1100);


            while( opcionMenu != 6)
            {
                Console.WriteLine("=== PUNTUACIONES ===");

                foreach (KeyValuePair<string, int> jugador in scoreboard)
                {
                    Console.WriteLine($"Nombre jugador: {jugador.Key}, Puntuación: {jugador.Value}");
                }

                Console.WriteLine();

                Console.WriteLine("1. Buscar puntuación de un jugador");
                Console.WriteLine("2. Modificar puntuación de un jugador");
                Console.WriteLine("3. Añadir nuevo jugador");
                Console.WriteLine("4. Eliminar jugador");
                Console.WriteLine("5. Mostrar jugadores registrados");
                Console.WriteLine("6. Salir");

                Console.WriteLine();

                Console.WriteLine("¿Qué quieres hacer?");
                opcionMenu = int.Parse(Console.ReadLine() ?? "");

                Console.WriteLine();

                switch (opcionMenu)
                {
                    case 1:

                        Console.WriteLine("¿De qué jugador quieres consultar su puntuación?");
                        string jugadorBuscado = Console.ReadLine() ?? "";

                        scoreboard.TryGetValue(jugadorBuscado, out int puntuacionBuscada);
                        Console.WriteLine($"La puntuación de {jugadorBuscado} es {puntuacionBuscada}");

                        break;

                    case 2:
                        Console.WriteLine("¿De qué jugador quieres modificar su puntuación?");
                        string jugadorModificado = Console.ReadLine() ?? "";

                        Console.WriteLine("¿Cuál es su nueva puntuación?");
                        int puntuacionModificada = int.Parse(Console.ReadLine() ?? "");

                        scoreboard[jugadorModificado] = puntuacionModificada;

                        Console.WriteLine();
                        
                        break;

                    case 3:
                        Console.WriteLine("Escribe el nombre del nuevo jugador: ");
                        string nuevoJugador = Console.ReadLine() ?? "";

                        Console.WriteLine("¿Cuál es su puntuación?");
                        int nuevaPuntuacion = int.Parse(Console.ReadLine() ?? "");

                        scoreboard.Add(nuevoJugador, nuevaPuntuacion);
                        Console.WriteLine();

                        break;

                    case 4:
                        Console.WriteLine("Escribe el nombre del jugador que quieras eliminar: ");
                        string borrarJugador = Console.ReadLine() ?? "";

                        scoreboard.Remove(borrarJugador);
                        Console.WriteLine("Jugador eliminado");

                        Console.WriteLine();

                        break;

                    case 5:
                        foreach(string jugador in scoreboard.Keys)
                        {
                            Console.WriteLine($"Jugador registrado: {jugador}");
                        }

                        Console.WriteLine();

                        break;

                    case 6:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
            }
        }
    }
}