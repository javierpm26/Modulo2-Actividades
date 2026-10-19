using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Singleton_Marcador
{
    class Marcador
    {
        private static Marcador? instancia = null;

        public int Puntos = 0;

        private Marcador()
        {
            Console.WriteLine("Marcador creado");
        }

        public static Marcador ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Marcador();
            }

            return instancia;
        }
    }
}