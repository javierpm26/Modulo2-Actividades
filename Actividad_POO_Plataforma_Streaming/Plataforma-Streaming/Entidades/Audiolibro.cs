using System;
using System.Collections.Generic;
using System.Text;
using PlataformaStreaming.Interfaces;

namespace Plataforma_Streaming.Entidades
{
    public class Audiolibro : Contenido, IDescargable
    {
        public string? Autor {get; set;}
        public string? Narrador {get; set;}
        public bool EstaDescargado { get; set; }

        public Audiolibro(string? titulo, int duracion, int reproducciones, string? autor, string? narrador, bool estaDescargado) : base(titulo, duracion, reproducciones)
        {
            Autor = autor;
            Narrador = narrador;
            this.EstaDescargado = estaDescargado;
        }

        public override void Reproducir()
        {
            this.Reproducciones++;

            Console.WriteLine($"Reproduciendo audiolibro: {this.Titulo}");
            Console.WriteLine($"Reproducciones: {this.Reproducciones}");
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Titulo: {this.Titulo}");
            Console.WriteLine($"Duración: {this.Duracion}");
            Console.WriteLine($"Reproducciones Totales: {this.Reproducciones}");
            Console.WriteLine($"Autor: {this.Autor}");
            Console.WriteLine($"Narrador: {this.Narrador}");
        }

        public void Descargar()
        {
            this.EstaDescargado = true;
        }

        public void EliminarDescarga()
        {
            this.EstaDescargado = false;
        }

    }  
                
}
