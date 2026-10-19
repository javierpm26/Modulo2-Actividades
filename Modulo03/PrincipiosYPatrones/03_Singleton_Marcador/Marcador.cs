using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Marcador
{
    class Marcador
    {
        private static Marcador instancia = new Marcador();

        public int Puntos = 0;

        private Marcador()
        {
            Console.WriteLine("Marcador creado");
        }

        public static Marcador ObtenerInstancia()
        {
            return instancia;
        }
    }
}