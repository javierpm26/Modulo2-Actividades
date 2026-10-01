using System.Drawing;
using System.Windows.Forms;

namespace MonitorDispositivos
{
    public class RatonControlador : IControladorDispositivo
    {
        public string Nombre => "Ratón";
        public bool Disponible { get; private set; } = true;
        public int PosicionX { get; private set; } = 0;
        public int PosicionY { get; private set; } = 0;
        public string UltimoBoton { get; private set; } = "Ninguno";
        public int Clics { get; private set; } = 0;

        public void ProcesarMovimiento (Point posicion)
        {
            try
            {
                PosicionX = posicion.X;
                PosicionY = posicion.Y;
            }
            catch
            {
                Disponible = false;
            }
        }

        public void ProcesarClic(MouseButtons boton)
        {
            try
            {
                UltimoBoton = boton.ToString();
                Clics++;
            }
            catch
            {
                Disponible = false;
            }
        }

        public string ObtenerEstado()
        {
            return Disponible ? "OK" : "ERROR";
        }

        public void Reiniciar()
        {
            PosicionX = 0;
            PosicionY = 0;
            UltimoBoton = "Ninguno";
            Clics = 0;
            Disponible = true;
        }
    }
}
