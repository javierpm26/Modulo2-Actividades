using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ExploracionSubmarinaApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer? components = null;

        private TabControl tabPrincipal;
        private TabPage tabExpediciones;
        private TabPage tabInformes;

        private TableLayoutPanel tlpExpediciones;
        private GroupBox grpDatosExpedicion;

        private Label lblNombre;
        private TextBox txtNombre;

        private Label lblFechaSalida;
        private DateTimePicker dtpFechaSalida;

        private Label lblDuracion;
        private NumericUpDown nudDuracion;

        private Label lblZona;
        private ComboBox cboZona;

        private Label lblSumergible;
        private ComboBox cboSumergible;

        private FlowLayoutPanel flpAcciones;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnRecargar;
        private Label lblModoRegistro;

        private DataGridView dgvExpediciones;

        private TableLayoutPanel tlpInformes;
        private FlowLayoutPanel flpBarraInformes;
        private ComboBox cboConsulta;
        private Label lblFechaDesde;
        private DateTimePicker dtpFechaDesde;
        private Button btnEjecutarInforme;

        private DataGridView dgvResultados;
        private Label lblEstadoInforme;

        private StatusStrip statusStripPrincipal;
        private ToolStripStatusLabel lblEstadoConexion;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            tabPrincipal = new TabControl();
            tabExpediciones = new TabPage();
            tabInformes = new TabPage();

            tlpExpediciones = new TableLayoutPanel();
            grpDatosExpedicion = new GroupBox();

            lblNombre = new Label();
            txtNombre = new TextBox();

            lblFechaSalida = new Label();
            dtpFechaSalida = new DateTimePicker();

            lblDuracion = new Label();
            nudDuracion = new NumericUpDown();

            lblZona = new Label();
            cboZona = new ComboBox();

            lblSumergible = new Label();
            cboSumergible = new ComboBox();

            flpAcciones = new FlowLayoutPanel();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnRecargar = new Button();
            lblModoRegistro = new Label();

            dgvExpediciones = new DataGridView();

            tlpInformes = new TableLayoutPanel();
            flpBarraInformes = new FlowLayoutPanel();
            cboConsulta = new ComboBox();
            lblFechaDesde = new Label();
            dtpFechaDesde = new DateTimePicker();
            btnEjecutarInforme = new Button();

            dgvResultados = new DataGridView();
            lblEstadoInforme = new Label();

            statusStripPrincipal = new StatusStrip();
            lblEstadoConexion = new ToolStripStatusLabel();

            tabPrincipal.SuspendLayout();
            tabExpediciones.SuspendLayout();
            tabInformes.SuspendLayout();

            tlpExpediciones.SuspendLayout();
            grpDatosExpedicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuracion).BeginInit();
            flpAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpediciones).BeginInit();

            tlpInformes.SuspendLayout();
            flpBarraInformes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();

            statusStripPrincipal.SuspendLayout();

            SuspendLayout();

            // tabPrincipal
            tabPrincipal.Controls.Add(tabExpediciones);
            tabPrincipal.Controls.Add(tabInformes);
            tabPrincipal.Dock = DockStyle.Fill;
            tabPrincipal.Location = new Point(0, 0);
            tabPrincipal.Name = "tabPrincipal";
            tabPrincipal.SelectedIndex = 0;
            tabPrincipal.Size = new Size(1200, 728);
            tabPrincipal.TabIndex = 0;

            // tabExpediciones
            tabExpediciones.Controls.Add(tlpExpediciones);
            tabExpediciones.Location = new Point(4, 24);
            tabExpediciones.Name = "tabExpediciones";
            tabExpediciones.Padding = new Padding(3);
            tabExpediciones.Size = new Size(1192, 700);
            tabExpediciones.TabIndex = 0;
            tabExpediciones.Text = "Expediciones";
            tabExpediciones.UseVisualStyleBackColor = true;

            // tlpExpediciones
            tlpExpediciones.ColumnCount = 1;
            tlpExpediciones.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F)
            );

            tlpExpediciones.Controls.Add(grpDatosExpedicion, 0, 0);
            tlpExpediciones.Controls.Add(flpAcciones, 0, 1);
            tlpExpediciones.Controls.Add(dgvExpediciones, 0, 2);

            tlpExpediciones.Dock = DockStyle.Fill;
            tlpExpediciones.Location = new Point(3, 3);
            tlpExpediciones.Name = "tlpExpediciones";
            tlpExpediciones.RowCount = 3;

            tlpExpediciones.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 170F)
            );

            tlpExpediciones.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 50F)
            );

            tlpExpediciones.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F)
            );

            tlpExpediciones.Size = new Size(1186, 694);
            tlpExpediciones.TabIndex = 0;

            // grpDatosExpedicion
            grpDatosExpedicion.Controls.Add(lblNombre);
            grpDatosExpedicion.Controls.Add(txtNombre);
            grpDatosExpedicion.Controls.Add(lblFechaSalida);
            grpDatosExpedicion.Controls.Add(dtpFechaSalida);
            grpDatosExpedicion.Controls.Add(lblDuracion);
            grpDatosExpedicion.Controls.Add(nudDuracion);
            grpDatosExpedicion.Controls.Add(lblZona);
            grpDatosExpedicion.Controls.Add(cboZona);
            grpDatosExpedicion.Controls.Add(lblSumergible);
            grpDatosExpedicion.Controls.Add(cboSumergible);

            grpDatosExpedicion.Dock = DockStyle.Fill;
            grpDatosExpedicion.Location = new Point(3, 3);
            grpDatosExpedicion.Name = "grpDatosExpedicion";
            grpDatosExpedicion.Size = new Size(1180, 164);
            grpDatosExpedicion.TabIndex = 0;
            grpDatosExpedicion.TabStop = false;
            grpDatosExpedicion.Text = "Datos de la expedición";

            // lblNombre
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(25, 38);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";

            // txtNombre
            txtNombre.Location = new Point(120, 35);
            txtNombre.MaxLength = 150;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(340, 23);
            txtNombre.TabIndex = 1;

            // lblFechaSalida
            lblFechaSalida.AutoSize = true;
            lblFechaSalida.Location = new Point(500, 38);
            lblFechaSalida.Name = "lblFechaSalida";
            lblFechaSalida.Size = new Size(91, 15);
            lblFechaSalida.TabIndex = 2;
            lblFechaSalida.Text = "Fecha de salida:";

            // dtpFechaSalida
            dtpFechaSalida.Format = DateTimePickerFormat.Short;
            dtpFechaSalida.Location = new Point(610, 35);
            dtpFechaSalida.Name = "dtpFechaSalida";
            dtpFechaSalida.Size = new Size(140, 23);
            dtpFechaSalida.TabIndex = 3;

            // lblDuracion
            lblDuracion.AutoSize = true;
            lblDuracion.Location = new Point(790, 38);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(98, 15);
            lblDuracion.TabIndex = 4;
            lblDuracion.Text = "Duración (horas):";

            // nudDuracion
            nudDuracion.Location = new Point(905, 35);
            nudDuracion.Maximum = new decimal(
                new int[] { 500, 0, 0, 0 }
            );
            nudDuracion.Minimum = new decimal(
                new int[] { 1, 0, 0, 0 }
            );
            nudDuracion.Name = "nudDuracion";
            nudDuracion.Size = new Size(100, 23);
            nudDuracion.TabIndex = 5;
            nudDuracion.Value = new decimal(
                new int[] { 1, 0, 0, 0 }
            );

            // lblZona
            lblZona.AutoSize = true;
            lblZona.Location = new Point(25, 95);
            lblZona.Name = "lblZona";
            lblZona.Size = new Size(37, 15);
            lblZona.TabIndex = 6;
            lblZona.Text = "Zona:";

            // cboZona
            cboZona.DropDownStyle = ComboBoxStyle.DropDownList;
            cboZona.FormattingEnabled = true;
            cboZona.Location = new Point(120, 92);
            cboZona.Name = "cboZona";
            cboZona.Size = new Size(340, 23);
            cboZona.TabIndex = 7;

            // lblSumergible
            lblSumergible.AutoSize = true;
            lblSumergible.Location = new Point(500, 95);
            lblSumergible.Name = "lblSumergible";
            lblSumergible.Size = new Size(73, 15);
            lblSumergible.TabIndex = 8;
            lblSumergible.Text = "Sumergible:";

            // cboSumergible
            cboSumergible.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSumergible.FormattingEnabled = true;
            cboSumergible.Location = new Point(610, 92);
            cboSumergible.Name = "cboSumergible";
            cboSumergible.Size = new Size(340, 23);
            cboSumergible.TabIndex = 9;

            // flpAcciones
            flpAcciones.Controls.Add(btnNuevo);
            flpAcciones.Controls.Add(btnGuardar);
            flpAcciones.Controls.Add(btnEliminar);
            flpAcciones.Controls.Add(btnRecargar);
            flpAcciones.Controls.Add(lblModoRegistro);

            flpAcciones.Dock = DockStyle.Fill;
            flpAcciones.Location = new Point(3, 173);
            flpAcciones.Name = "flpAcciones";
            flpAcciones.Padding = new Padding(5);
            flpAcciones.Size = new Size(1180, 44);
            flpAcciones.TabIndex = 1;

            // btnNuevo
            btnNuevo.AutoSize = true;
            btnNuevo.Location = new Point(8, 8);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(110, 25);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo / Limpiar";
            btnNuevo.UseVisualStyleBackColor = true;

            // btnGuardar
            btnGuardar.AutoSize = true;
            btnGuardar.Location = new Point(124, 8);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 25);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;

            // btnEliminar
            btnEliminar.AutoSize = true;
            btnEliminar.Location = new Point(205, 8);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 25);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;

            // btnRecargar
            btnRecargar.AutoSize = true;
            btnRecargar.Location = new Point(286, 8);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(75, 25);
            btnRecargar.TabIndex = 3;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = true;

            // lblModoRegistro
            lblModoRegistro.AutoSize = true;
            lblModoRegistro.Location = new Point(377, 13);
            lblModoRegistro.Margin = new Padding(13, 8, 3, 0);
            lblModoRegistro.Name = "lblModoRegistro";
            lblModoRegistro.Size = new Size(142, 15);
            lblModoRegistro.TabIndex = 4;
            lblModoRegistro.Text = "Modo: nueva expedición";

            // dgvExpediciones
            dgvExpediciones.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgvExpediciones.Dock = DockStyle.Fill;
            dgvExpediciones.Location = new Point(3, 223);
            dgvExpediciones.Name = "dgvExpediciones";
            dgvExpediciones.Size = new Size(1180, 468);
            dgvExpediciones.TabIndex = 2;

            // tabInformes
            tabInformes.Controls.Add(tlpInformes);
            tabInformes.Location = new Point(4, 24);
            tabInformes.Name = "tabInformes";
            tabInformes.Padding = new Padding(3);
            tabInformes.Size = new Size(1192, 700);
            tabInformes.TabIndex = 1;
            tabInformes.Text = "Consultas e informes";
            tabInformes.UseVisualStyleBackColor = true;

            // tlpInformes
            tlpInformes.ColumnCount = 1;
            tlpInformes.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F)
            );

            tlpInformes.Controls.Add(flpBarraInformes, 0, 0);
            tlpInformes.Controls.Add(dgvResultados, 0, 1);
            tlpInformes.Controls.Add(lblEstadoInforme, 0, 2);

            tlpInformes.Dock = DockStyle.Fill;
            tlpInformes.Location = new Point(3, 3);
            tlpInformes.Name = "tlpInformes";
            tlpInformes.RowCount = 3;

            tlpInformes.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 80F)
            );

            tlpInformes.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F)
            );

            tlpInformes.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 30F)
            );

            tlpInformes.Size = new Size(1186, 694);
            tlpInformes.TabIndex = 0;

            // flpBarraInformes
            flpBarraInformes.Controls.Add(cboConsulta);
            flpBarraInformes.Controls.Add(lblFechaDesde);
            flpBarraInformes.Controls.Add(dtpFechaDesde);
            flpBarraInformes.Controls.Add(btnEjecutarInforme);

            flpBarraInformes.Dock = DockStyle.Fill;
            flpBarraInformes.Location = new Point(3, 3);
            flpBarraInformes.Name = "flpBarraInformes";
            flpBarraInformes.Padding = new Padding(10);
            flpBarraInformes.Size = new Size(1180, 74);
            flpBarraInformes.TabIndex = 0;

            // cboConsulta
            cboConsulta.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConsulta.FormattingEnabled = true;
            cboConsulta.Location = new Point(13, 13);
            cboConsulta.Name = "cboConsulta";
            cboConsulta.Size = new Size(350, 23);
            cboConsulta.TabIndex = 0;

            // lblFechaDesde
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.Location = new Point(379, 18);
            lblFechaDesde.Margin = new Padding(13, 8, 3, 0);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(76, 15);
            lblFechaDesde.TabIndex = 1;
            lblFechaDesde.Text = "Desde fecha:";

            // dtpFechaDesde
            dtpFechaDesde.Format = DateTimePickerFormat.Short;
            dtpFechaDesde.Location = new Point(461, 13);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(130, 23);
            dtpFechaDesde.TabIndex = 2;

            // btnEjecutarInforme
            btnEjecutarInforme.AutoSize = true;
            btnEjecutarInforme.Location = new Point(597, 13);
            btnEjecutarInforme.Name = "btnEjecutarInforme";
            btnEjecutarInforme.Size = new Size(115, 25);
            btnEjecutarInforme.TabIndex = 3;
            btnEjecutarInforme.Text = "Ejecutar consulta";
            btnEjecutarInforme.UseVisualStyleBackColor = true;

            // dgvResultados
            dgvResultados.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgvResultados.Dock = DockStyle.Fill;
            dgvResultados.Location = new Point(3, 83);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(1180, 578);
            dgvResultados.TabIndex = 1;

            // lblEstadoInforme
            lblEstadoInforme.AutoSize = true;
            lblEstadoInforme.Dock = DockStyle.Fill;
            lblEstadoInforme.Location = new Point(3, 664);
            lblEstadoInforme.Name = "lblEstadoInforme";
            lblEstadoInforme.Padding = new Padding(5);
            lblEstadoInforme.Size = new Size(1180, 30);
            lblEstadoInforme.TabIndex = 2;
            lblEstadoInforme.Text = "Selecciona una consulta";
            lblEstadoInforme.TextAlign = ContentAlignment.MiddleLeft;

            // statusStripPrincipal
            statusStripPrincipal.Items.AddRange(
                new ToolStripItem[]
                {
                    lblEstadoConexion
                }
            );

            statusStripPrincipal.Location = new Point(0, 728);
            statusStripPrincipal.Name = "statusStripPrincipal";
            statusStripPrincipal.Size = new Size(1200, 22);
            statusStripPrincipal.TabIndex = 1;

            // lblEstadoConexion
            lblEstadoConexion.Name = "lblEstadoConexion";
            lblEstadoConexion.Size = new Size(73, 17);
            lblEstadoConexion.Text = "Sin conectar";

            // MainForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 750);
            Controls.Add(tabPrincipal);
            Controls.Add(statusStripPrincipal);
            MinimumSize = new Size(1000, 650);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exploración submarina - Gestión de expediciones";
            WindowState = FormWindowState.Maximized;

            tabPrincipal.ResumeLayout(false);
            tabExpediciones.ResumeLayout(false);
            tabInformes.ResumeLayout(false);

            tlpExpediciones.ResumeLayout(false);
            grpDatosExpedicion.ResumeLayout(false);
            grpDatosExpedicion.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)nudDuracion).EndInit();

            flpAcciones.ResumeLayout(false);
            flpAcciones.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)dgvExpediciones).EndInit();

            tlpInformes.ResumeLayout(false);
            tlpInformes.PerformLayout();

            flpBarraInformes.ResumeLayout(false);
            flpBarraInformes.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();

            statusStripPrincipal.ResumeLayout(false);
            statusStripPrincipal.PerformLayout();

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}