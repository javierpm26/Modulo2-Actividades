namespace EstructurasDeDatos.Estructuras
{
    public static class Listas
    {
        // Ejercicio 1 - Playlist
        public static void Playlist()
        {
            int numeroCancion = 0;
            int opcion = 0;

            List<string> canciones =
            [
                "Espresso",
                "APT.",
                "Blinding Lights"
            ];

            while (opcion < 3)
            {
                Console.WriteLine("Añade una nueva canción a la playlist (3 Máximo): ");
                string nuevaCancion = Console.ReadLine() ?? "";

                opcion++;
                canciones.Add(nuevaCancion);
            }

            canciones.Insert(1, "Cruel Summer");
            canciones[1] = "Poker Face";
            canciones.Remove("APT.");

            Console.WriteLine("=== MI PLAYLIST ===\n");

            foreach (string cancion in canciones)
            {
                numeroCancion++;
                Console.WriteLine($"{numeroCancion}. {cancion}");
            }

            Console.WriteLine($"\nTotal de canciones: {canciones.Count()}");
        }


        // Ejercicio 2 - Lista de la compra
        public static void listaCompra()
        {
            int opcionMenu = 0;

            List<string> carritoCompra = 
            [
                "Leche",
                "Pan",
                "Huevos",
                "Pasta",
                "Arroz"
            ];

            foreach (var item in carritoCompra)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            while (opcionMenu != 4)
            {
                Console.WriteLine("1. Mostrar lista productos");
                Console.WriteLine("2. Añadir productos");
                Console.WriteLine("3. Eliminar productos");
                Console.WriteLine("4. Checkout");

                Console.WriteLine();

                Console.WriteLine("Elige una opción:");
                opcionMenu = int.Parse(Console.ReadLine() ?? "");

                Console.WriteLine();

                switch(opcionMenu)
                {
                    case 1:
                        Console.WriteLine("=== LISTA DE LA COMPRA ===");
                    
                        foreach (var item in carritoCompra)
                        {
                            Console.WriteLine(item);
                        }
            
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("¿Qué producto quieres añadir?");
                        string productoAnadido = Console.ReadLine() ?? "";
                        carritoCompra.Add(productoAnadido);

                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("¿Qué producto quieres eliminar?");
                        string productoEliminado = Console.ReadLine() ?? "";
                        carritoCompra.Remove(productoEliminado);

                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine("=== LISTA FINAL ===");

                        foreach (var item in carritoCompra)
                        {
                            Console.WriteLine(item);
                        }

                        Console.WriteLine();
                        Console.WriteLine($"Productos restantes: {carritoCompra.Count}");
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }


        // Ejercicio 3 - Gestor de Tareas
        public static void gestorTareas()
        {
            int opcionUsuario = 0;

            List<string> tareas =
            [
                "Estudiar C#",
                "Hacer ejercicio",
                "Comprar comida",
                "Ver una película"
            ];

            while (opcionUsuario != 6)
            {
                Console.WriteLine("=== MIS TAREAS ===\n");
                Console.WriteLine("1. Mostrar tareas");
                Console.WriteLine("2. Añadir tarea");
                Console.WriteLine("3. Completar tarea");
                Console.WriteLine("4. Buscar tarea");
                Console.WriteLine("5. Ordenar tarea");
                Console.WriteLine("6. Salir");

                Console.WriteLine("Escoge una opción poniendo su número: ");
                opcionUsuario = int.Parse(Console.ReadLine() ?? "");

                switch (opcionUsuario)
                {
                    case 1:
                        Console.WriteLine("=== MIS TAREAS PENDIENTES ===");

                        foreach (string tarea in tareas)
                        {
                            Console.WriteLine(tarea);
                        }

                        break;

                    case 2:
                        Console.WriteLine("=== AÑADIR NUEVA TAREA ===");
                        Console.WriteLine("Escribe el nombre de la nueva tarea: ");

                        string nuevaTarea = Console.ReadLine() ?? "";

                        tareas.Add(nuevaTarea);

                        Console.WriteLine(
                            $"\nTarea {nuevaTarea} añadida correctamente."
                        );

                        break;

                    case 3:
                        Console.WriteLine("=== COMPLETAR UNA TAREA ===");
                        Console.WriteLine("¿Qué tarea has completado?: ");

                        string tareaCompletada = Console.ReadLine() ?? "";

                        Console.WriteLine(
                            $"Tarea {tareaCompletada} completada. Eliminándola de la lista..."
                        );

                        tareas.Remove(tareaCompletada);

                        break;

                    case 4:
                        Console.WriteLine("=== BUSCAR TAREA ===");
                        Console.WriteLine("Introduce el nombre de la tarea que quieres buscar: ");

                        string buscarTarea = Console.ReadLine() ?? "";

                        if (tareas.Contains(buscarTarea))
                        {
                            Console.WriteLine(
                                $"¡¡Tarea {buscarTarea} existe!!"
                            );
                        }
                        else
                        {
                            Console.WriteLine(
                                $"Tarea {buscarTarea} no existe en la lista actual de tareas"
                            );
                        }

                        break;

                    case 5:
                        tareas.Sort();

                        Console.WriteLine(
                            "=== MIS TAREAS PENDIENTES (ORDENADO ALFABÉTICAMENTE) ==="
                        );

                        foreach (string tareaOrdenada in tareas)
                        {
                            Console.WriteLine(tareaOrdenada);
                        }

                        break;

                    case 6:
                        Console.WriteLine("Saliendo del programa... ¡Hasta luego!");
                        break;

                    default:
                        Console.WriteLine(
                            "¡¡OPCIÓN NO VÁLIDA!!, ¡ESCOGE UNA DEL MENÚ!"
                        );

                        break;
                }
            }
        }
    }
}



