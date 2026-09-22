using System;
using System.Collections.Generic;
using System.Text;
using PlataformaStreaming.Interfaces;

namespace Plataforma_Streaming.Entidades
{
    public class Cancion : Contenido, IDescargable
    {
        public string? Artista { get; set; }
        public string? Genero { get; set; }
        public bool EstaDescargado { get; set; }

        public Cancion(string? titulo, int duracion, int reproducciones, string? artista, string? genero, bool estaDescargado) : base(titulo, duracion, reproducciones)
        {
            Artista = artista;
            Genero = genero;
            this.EstaDescargado = estaDescargado;
        }

        public override void Reproducir()
        {
            Console.WriteLine($"Reproduciendo: {this.Titulo}\nArtista: {this.Artista}");
            this.Reproducciones++;
            Console.WriteLine($"Reproducciones: {this.Reproducciones}");
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
