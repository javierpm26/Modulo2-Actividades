using System;
using System.Collections.Generic;
using System.Text;

namespace Plataforma_Streaming.Entidades
{
    public class Podcast : Contenido
    {

        public string? Presentador { get; set; }

        public int numeroEpisodio { get; set; }
        public Podcast(string? titulo, int duracion, int reproducciones, string? presentador, int numeroEpisodio) : base(titulo, duracion, reproducciones)
        {
            Presentador = presentador;
            this.numeroEpisodio = numeroEpisodio;
        }

        public override void Reproducir()
        {
            this.Reproducciones++;
            Console.WriteLine($"Reproduciendo podcast: {this.Titulo}\nPresentador: {this.Presentador}\nEpisodio: {this.numeroEpisodio}\nReproducciones: {this.Reproducciones}");
        }

    }  
           
      
}
