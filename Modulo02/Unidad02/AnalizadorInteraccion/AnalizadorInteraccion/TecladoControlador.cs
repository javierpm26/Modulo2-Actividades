using System.Collections.Generic;
using System.Windows.Forms;

namespace AnalizadorInteraccion
{
    public class TecladoControlador : IControladorDispositivo
    {
        public int TotalTeclas { get; private set; }
        public int LetrasTeclado { get; private set; }
        public int NumerosTeclado { get; private set; }
        public int OtrosTeclado { get; private set; }

        public string TeclaMasUtilizada { get; private set; } = "Ninguna";

        private Dictionary<Keys, int> contadorTeclas;

        public TecladoControlador()
        {
            contadorTeclas = new Dictionary<Keys, int>();
        }

        public void ProcesarTecla(Keys tecla)
        {
            TotalTeclas++;

            if(tecla >= Keys.A && tecla <= Keys.Z)
            {
                LetrasTeclado++;
            }
            else if(tecla >= Keys.D0 && tecla <= Keys.D9 || tecla >= Keys.NumPad0 && tecla <= Keys.NumPad9)
            {
                NumerosTeclado++;
            }
            else
            {
                OtrosTeclado++;
            }

            // Registrar cuantas veces se ha pulsado cada letra
            // Actualizar la tecla más utilizada
        }

        public void Reiniciar()
        {
            TotalTeclas = 0;
            Letras = 0;
            Numeros = 0;
            Otras = 0;

            TeclaMasUtilizada = "Ninguna";

            contadorTeclas.Clear();
        }
    }
}