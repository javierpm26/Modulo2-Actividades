using Plataforma_Streaming.Entidades;
using PlataformaStreaming.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlataformaStreaming.Entidades
{
    public class Video : Contenido, IDescargable
    {

        public string? Tematica { get; set; }

        public int TasaFotogramasPorSegundo { get; set; }

        public bool EstaDescargado { get; set; }
        public Video(string? titulo, int duracion, int reproducciones, string? tematica, int tasaFotogramasPorSegundo, bool estaDescargado) : base (titulo, duracion, reproducciones)
        {
            Tematica = tematica;
            TasaFotogramasPorSegundo = tasaFotogramasPorSegundo;
            this.EstaDescargado = estaDescargado;
        }

        public override void Reproducir()
        {
            Console.WriteLine($"Reproduciendo el video {this.Titulo}");
            this.Reproducciones++;
            Console.WriteLine($"Reproducciones: {this.Reproducciones}");
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Titulo: {this.Titulo}");
            Console.WriteLine($"Duración: {this.Duracion}");
            Console.WriteLine($"Reproducciones: {this.Reproducciones}");
            Console.WriteLine($"Temática: {this.Tematica}");
            Console.WriteLine($"Tasa de Fotogramas por Segundo: {this.TasaFotogramasPorSegundo}");
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
