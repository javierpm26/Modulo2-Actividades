using System.Collections;

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

        //Ejercicio 8 - Servicio de soporte
        public static void servicioSoporte()
        {
            Queue<string> colaSoporte = new Queue<string>();
            int opcionMenu = 0;

            colaSoporte.Enqueue("Isabel");
            colaSoporte.Enqueue("Luis");
            colaSoporte.Enqueue("Carlos");
            colaSoporte.Enqueue("Marta");

            while( opcionMenu != 5)
            {
                Console.WriteLine("=== SOPORTE TÉCNICO ===");

                Console.WriteLine("1. Añadir solicitud");
                Console.WriteLine("2. Atender solicitud");
                Console.WriteLine("3. Mostrar siguiente");
                Console.WriteLine("4. Mostrar pendientes");
                Console.WriteLine("5. Salir");

                Console.WriteLine();

                Console.WriteLine("¿Qué quieres hacer?");
                opcionMenu = int.Parse(Console.ReadLine() ?? "");

                Console.WriteLine();

                Console.WriteLine($"Opción escogida: {opcionMenu}");

                Console.WriteLine();

                switch (opcionMenu)
                {
                    case 1:
                        Console.WriteLine("¿De qué cliente quieres añadir la solicitud?");
                        string clienteSolicitud = Console.ReadLine() ?? "";
                        colaSoporte.Enqueue(clienteSolicitud);

                        Console.WriteLine();

                        break;

                    case 2:
                        Console.WriteLine($"Atendiendo a: {colaSoporte.Peek()}");
                        colaSoporte.Dequeue();

                        Console.WriteLine();
                        
                        break;

                    case 3:
                        Console.WriteLine($"Siguiente cliente por atender: {colaSoporte.Peek()}");

                        Console.WriteLine();

                        break;

                    case 4:
                        Console.WriteLine("Solicitudes pendientes: ");
                        
                        foreach (string cliente in colaSoporte)
                        {
                            Console.WriteLine(cliente);
                        };

                        Console.WriteLine();

                        break;

                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        Console.WriteLine($"Solicitudes por atender: {colaSoporte.Count()}");

                        Console.WriteLine();

                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
            }
        }

        public static void entradasConcierto()
        {
            Queue<string> colaConcierto = new Queue<string>();
            colaConcierto.Enqueue("Laura");
            colaConcierto.Enqueue("Mario");
            colaConcierto.Enqueue("Sara");
            colaConcierto.Enqueue("David");
            colaConcierto.Enqueue("Lucía");

            Console.WriteLine("=== ACCESO AL CONCIERTO ===\n");

            string personaQueMasEspera = colaConcierto.Last();
            Console.WriteLine($"Persona que más espera: {personaQueMasEspera}");

            Console.WriteLine("Esperando:");
            // Mostrar la cola de espera
            foreach (string persona in colaConcierto)
            {
                Console.WriteLine(persona);
            }

            // Dejar pasar a la primera persona de la cola
            Console.WriteLine($"Entrando: {colaConcierto.Peek()}");
            colaConcierto.Dequeue();

            // Escaner para que el usuario meta una nueva persona a la cola
            Console.WriteLine("¿Nueva persona?: ");
            string respuestaSIoNO = Console.ReadLine() ?? "";
            if (respuestaSIoNO == "Si" || respuestaSIoNO == "SI")
            {
                Console.WriteLine("Nombre: ");
                string nuevaPersona = Console.ReadLine() ?? "";
                colaConcierto.Enqueue(nuevaPersona);
            }
            else
            {
                Console.WriteLine("Cancelado");
            }

            Console.WriteLine("=== PERSONAS QUE SIGUEN ESPERANDO ===");
            foreach (string personasEsperando in colaConcierto)
            {
                Console.WriteLine(personasEsperando);
            }


            


            
        }
    }
}