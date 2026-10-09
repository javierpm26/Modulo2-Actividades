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

        // Ejercicio 5 - Navegador web
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

        //Ejercicio 6 - Paréntesis correctos
        public static void ParentesisCorrectos()
        {
            Stack<string> expresionesAritm = new Stack<string>();

            expresionesAritm.Push("(2 + 3) * (4 + 5)");
            expresionesAritm.Push("((10 + 5) * 2)");
            expresionesAritm.Push("(10 + 5) + 5)");
            expresionesAritm.Push("((10 + 5)");

            int parentesisApertura = 0;
            int parentesisCierre = 0;

           foreach(string formula in expresionesAritm.Reverse())
            {
                parentesisApertura=0;
                parentesisCierre=0;

                for(int i = 0; i < formula.Length; i++)
                {
                    if(formula[i] != '(' && formula[i] != ')')
                    {
                        continue;
                    }
                    else
                    {
                        if(formula[i] == '(')
                        {
                            parentesisApertura++;
                        }
                        else
                        {
                            parentesisCierre++;
                        }
                    }
                }

                if(parentesisApertura == parentesisCierre)
                {
                    Console.WriteLine(formula + " → Correcta");
                }
                else
                {
                    Console.WriteLine(formula + " → Incorrecta");
                }
            }
            
        }

    }

}