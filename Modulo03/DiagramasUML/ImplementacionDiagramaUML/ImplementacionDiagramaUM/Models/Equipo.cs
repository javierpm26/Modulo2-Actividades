using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementacionDiagramaUM.Models
{
    public class Equipo
    {
        public int IdEquipo { get; set; }

        public string Codigo { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;
        private int IdEquipo { get; set; }
        private string Codigo { get; set; } = string.Empty;
        private string Descripcion { get; set; } = string.Empty;
    }
}
