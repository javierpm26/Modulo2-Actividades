using System;
using System.Collections.Generic;
using System.Text;

namespace Plataforma_Streaming.Entidades
{
    public class Audiolibro : Contenido
    {
        public string? Autor {get; set;}
        public string? Narrador {get; set;}

        public Audiolibro(string? titulo, int duracion, int reproducciones, string? autor, string? narrador) : base(titulo, duracion, reproducciones)
        {
            Autor = autor;
            Narrador = narrador;
        }

        public override void Reproducir()
        {
            this.Reproducciones++;

            Console.WriteLine($"Reproduciendo audiolibro: {this.Titulo}");
            Console.WriteLine($"Autor: {this.Autor}");
            Console.WriteLine($"Narrador: {this.Narrador}");
            Console.WriteLine($"Reproducciones: {this.Reproducciones}");
        }

    }  
                
}
