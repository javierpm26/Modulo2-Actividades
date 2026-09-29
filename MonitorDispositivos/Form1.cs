using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonitorDispositivos
{
    public partial class Form1 : Form
    {
        private readonly TecladoControlador teclado;
        private readonly RatonControlador raton;

        public Form1()
        {
            InitializeComponent();

            teclado = new TecladoControlador();
            raton = new RatonControlador();

            KeyPreview = true;

            KeyDown += Form1_KeyDown;
            MouseMove += Form1_MouseMove;
            MouseClick += Form1_MouseClick;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            teclado.ProcesarTecla(e.KeyCode);
            ActualizarInterfaz();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            raton.ProcesarMovimiento(e.Location);
            ActualizarInterfaz();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            raton.ProcesarClic(e.Button);
            ActualizarInterfaz();
        }

        private void ActualizarInterfaz()
        {
            lblUltimaTecla.Text =
                $"Última tecla: {teclado.UltimaTecla}";

            lblCodigoTecla.Text =
                $"Código: {teclado.Codigo}";

            lblPulsaciones.Text =
                $"Pulsaciones: {teclado.Pulsaciones}";

            lblEstadoTeclado.Text =
                $"Estado: {teclado.ObtenerEstado()}";

            lblPosicionX.Text =
                $"Posición X: {raton.PosicionX}";

            lblPosicionY.Text =
                $"Posición Y: {raton.PosicionY}";

            lblBoton.Text =
                $"Último botón: {raton.UltimoBoton}";

            lblClics.Text =
                $"Clics: {raton.Clics}";

            lblEstadoRaton.Text =
                $"Estado: {raton.ObtenerEstado()}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

