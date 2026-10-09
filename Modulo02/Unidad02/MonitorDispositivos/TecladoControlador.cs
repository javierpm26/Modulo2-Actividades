using System.Windows.Forms;
namespace MonitorDispositivos
{
    public class  TecladoControlador: IControladorDispositivo
    {
        public string Nombre => "Teclado";

        public bool Disponible { get; private set; } = true;

        public string UltimaTecla { get; private set; } = "Ninguna";

        public int Codigo { get; private set; } = 0;

        public int Pulsaciones { get; private set; } = 0;

        public void ProcesarTecla(Keys tecla)
        {
            try
            {
                UltimaTecla = tecla.ToString();
                Codigo = (int)tecla;
                Pulsaciones++;
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
            UltimaTecla = "Ninguna";
            Codigo = 0;
            Pulsaciones = 0;
            Disponible = true;
        }


    }
    
    
}