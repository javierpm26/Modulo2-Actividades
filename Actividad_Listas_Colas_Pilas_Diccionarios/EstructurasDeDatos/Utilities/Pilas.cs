namespace EstructurasDeDatos.Utilities
{
    public static class Pilas
    {
        // Ejercicio 4 - Deshacer cambios
        public static void DeshacerCambios()
        {
            Stack<string> accionesUsuario = new Stack<string>();
            accionesUsuario.Push("Escribir texto");
            accionesUsuario.Push("Cambiar color");
            accionesUsuario.Push("Insertar imagen");
            accionesUsuario.Push("Eliminar imagen");


            Console.WriteLine();

            Console.WriteLine("=== HISTORIAL ===");
            Console.WriteLine($"Última acción: {accionesUsuario.Peek()}");

            Console.WriteLine();

            Console.WriteLine($"Deshaciendo: {accionesUsuario.Peek()}");
            accionesUsuario.Pop();

            Console.WriteLine();

            Console.WriteLine($"Nueva última acción: {accionesUsuario.Peek()}");

            Console.WriteLine();

            accionesUsuario.Push("Cambiar tamaño");
            Console.WriteLine($"Nueva acción: {accionesUsuario.Peek()}");

            Console.WriteLine();

            Console.WriteLine("=== HISTORIAL FINAL ===");

            foreach(string accion in accionesUsuario)
            {
                Console.WriteLine(accion);
            }

        }

        public static void NavegadorWeb()
        {
            Stack<string> historialNavegador = new Stack<string>();

            historialNavegador.Push("www.google.com");
            historialNavegador.Push("www.youtube.com");
            historialNavegador.Push("www.instagram.com");
            historialNavegador.Push("www.github.com");

            Console.WriteLine("=== NAVEGADOR ===\n");
            Console.WriteLine($"Página actual: {historialNavegador.Peek()}");
            Console.WriteLine("Pulsando ATRÁS...");
            historialNavegador.Pop();
            Console.WriteLine($"Pagina actual: {historialNavegador.Peek()}");
            Console.WriteLine("Pulsando ATRÁS...");
            historialNavegador.Pop();
            Console.WriteLine($"Pagina actual: {historialNavegador.Peek()}");

         
            historialNavegador.Push("www.tiktok.com");
            Console.WriteLine("Nueva visita: www.tiktok.com");

            Console.WriteLine($"Pagina actual: {historialNavegador.Peek()}");
        }



    }



}