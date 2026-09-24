namespace EstructurasDeDatos.Utilities
{
    public static class Pilas
    {
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
    }
}