using System;
using System.Collections.Generic;
using System.Text;

namespace Plataforma_Streaming.Entidades
{
    public class Cancion : Contenido
    {
        public string? Artista { get; set; }
        public string? Genero { get; set; }

        public Cancion(string? titulo, int duracion, int reproducciones, string? artista, string? genero) : base(titulo, duracion, reproducciones)
        {
            Artista = artista;
            Genero = genero;
        }

        public override void Reproducir()
        {
            Console.WriteLine($"Reproduciendo: {this.Titulo}\nArtista: {this.Artista}");
            this.Reproducciones++;
            Console.WriteLine($"Reproducciones: {this.Reproducciones}");
        }

    }

}
