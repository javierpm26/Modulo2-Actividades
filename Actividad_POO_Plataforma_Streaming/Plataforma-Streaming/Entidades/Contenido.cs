using System;
using System.Collections.Generic;
using System.Text;

namespace Plataforma_Streaming.Entidades
{
    public abstract class Contenido
    {
        protected Contenido(string? titulo, int duracion, int reproducciones)
        {
            Titulo = titulo;
            Duracion = duracion;
            Reproducciones = reproducciones;
        }

        public string? Titulo { get; set; }

        public int Duracion { get; set; }

        public int Reproducciones { get; set; }



        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Titulo: {this.Titulo}");
            Console.WriteLine($"Duración: {this.Duracion}");
            Console.WriteLine($"Reproducciones Totales: {this.Reproducciones}");
        }
    }
}
