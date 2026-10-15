using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ImplementacionDiagramaUM.Models
{
    internal class Prestamo
    {
        private int IdPrestamo { get; set; }
        private DateTime FechaSolicitud { get; set; }
        private DateTime FechaInicioPrevista { get; set; }
        private DateTime FechaEntregaReal { get; set; }
        private DateTime FechaDevolucionReal { get; set; }

        public void RegistrarEntrega(DateTime fecha)
        {

        }

        public void RegistrarDevolucion (DateTime fecha)
        {

        }

        public bool EstaFueraDePlazo()
        {
            
        }

    }
}
