namespace MonitorDispositivos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            grpTeclado = new GroupBox();
            lblPulsaciones = new Label();
            lblCodigoTecla = new Label();
            lblEstadoTeclado = new Label();
            lblUltimaTecla = new Label();
            grpRaton = new GroupBox();
            lblEstadoRaton = new Label();
            lblClics = new Label();
            lblBoton = new Label();
            lblPosicionY = new Label();
            lblPosicionX = new Label();
            lblInformacion = new Label();
            grpTeclado.SuspendLayout();
            grpRaton.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Location = new Point(265, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(286, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Monitor de dispositivos";
            // 
            // grpTeclado
            // 
            grpTeclado.Controls.Add(lblPulsaciones);
            grpTeclado.Controls.Add(lblCodigoTecla);
            grpTeclado.Controls.Add(lblEstadoTeclado);
            grpTeclado.Controls.Add(lblUltimaTecla);
            grpTeclado.Location = new Point(25, 80);
            grpTeclado.Name = "grpTeclado";
            grpTeclado.Size = new Size(350, 180);
            grpTeclado.TabIndex = 1;
            grpTeclado.TabStop = false;
            grpTeclado.Text = "Teclado";
            // 
            // lblPulsaciones
            // 
            lblPulsaciones.AutoSize = true;
            lblPulsaciones.Location = new Point(20, 95);
            lblPulsaciones.Name = "lblPulsaciones";
            lblPulsaciones.Size = new Size(81, 15);
            lblPulsaciones.TabIndex = 2;
            lblPulsaciones.Text = "Pulsaciones: 0";
            // 
            // lblCodigoTecla
            // 
            lblCodigoTecla.AutoSize = true;
            lblCodigoTecla.Location = new Point(20, 65);
            lblCodigoTecla.Name = "lblCodigoTecla";
            lblCodigoTecla.Size = new Size(58, 15);
            lblCodigoTecla.TabIndex = 1;
            lblCodigoTecla.Text = "Código: 0";
            // 
            // lblEstadoTeclado
            // 
            lblEstadoTeclado.AutoSize = true;
            lblEstadoTeclado.Location = new Point(20, 125);
            lblEstadoTeclado.Name = "lblEstadoTeclado";
            lblEstadoTeclado.Size = new Size(64, 15);
            lblEstadoTeclado.TabIndex = 3;
            lblEstadoTeclado.Text = "Estado: OK";
            // 
            // lblUltimaTecla
            // 
            lblUltimaTecla.AutoSize = true;
            lblUltimaTecla.Location = new Point(20, 35);
            lblUltimaTecla.Name = "lblUltimaTecla";
            lblUltimaTecla.Size = new Size(122, 15);
            lblUltimaTecla.TabIndex = 0;
            lblUltimaTecla.Text = "Última tecla: Ninguna";
            // 
            // grpRaton
            // 
            grpRaton.Controls.Add(lblEstadoRaton);
            grpRaton.Controls.Add(lblClics);
            grpRaton.Controls.Add(lblBoton);
            grpRaton.Controls.Add(lblPosicionY);
            grpRaton.Controls.Add(lblPosicionX);
            grpRaton.Location = new Point(400, 80);
            grpRaton.Name = "grpRaton";
            grpRaton.Size = new Size(350, 180);
            grpRaton.TabIndex = 2;
            grpRaton.TabStop = false;
            grpRaton.Text = "Ratón";
            // 
            // lblEstadoRaton
            // 
            lblEstadoRaton.AutoSize = true;
            lblEstadoRaton.Location = new Point(20, 150);
            lblEstadoRaton.Name = "lblEstadoRaton";
            lblEstadoRaton.Size = new Size(64, 15);
            lblEstadoRaton.TabIndex = 4;
            lblEstadoRaton.Text = "Estado: OK";
            // 
            // lblClics
            // 
            lblClics.AutoSize = true;
            lblClics.Location = new Point(20, 125);
            lblClics.Name = "lblClics";
            lblClics.Size = new Size(44, 15);
            lblClics.TabIndex = 3;
            lblClics.Text = "Clics: 0";
            // 
            // lblBoton
            // 
            lblBoton.AutoSize = true;
            lblBoton.Location = new Point(20, 95);
            lblBoton.Name = "lblBoton";
            lblBoton.Size = new Size(131, 15);
            lblBoton.TabIndex = 2;
            lblBoton.Text = "Último botón: Ninguno";
            // 
            // lblPosicionY
            // 
            lblPosicionY.AutoSize = true;
            lblPosicionY.Location = new Point(20, 65);
            lblPosicionY.Name = "lblPosicionY";
            lblPosicionY.Size = new Size(74, 15);
            lblPosicionY.TabIndex = 1;
            lblPosicionY.Text = "Posición Y: 0";
            // 
            // lblPosicionX
            // 
            lblPosicionX.AutoSize = true;
            lblPosicionX.Location = new Point(20, 35);
            lblPosicionX.Name = "lblPosicionX";
            lblPosicionX.Size = new Size(74, 15);
            lblPosicionX.TabIndex = 0;
            lblPosicionX.Text = "Posición X: 0";
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Location = new Point(248, 284);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(259, 15);
            lblInformacion.TabIndex = 3;
            lblInformacion.Text = "Mueve el ratón o pulsa una tecla para comenzar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(780, 330);
            Controls.Add(lblInformacion);
            Controls.Add(grpRaton);
            Controls.Add(grpTeclado);
            Controls.Add(lblTitulo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Monitor de dispositivos";
            Load += Form1_Load;
            grpTeclado.ResumeLayout(false);
            grpTeclado.PerformLayout();
            grpRaton.ResumeLayout(false);
            grpRaton.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpTeclado;
        private System.Windows.Forms.Label lblUltimaTecla;
        private System.Windows.Forms.Label lblEstadoTeclado;
        private System.Windows.Forms.Label lblCodigoTecla;
        private System.Windows.Forms.GroupBox grpRaton;
        private System.Windows.Forms.Label lblPosicionY;
        private System.Windows.Forms.Label lblPosicionX;
        private System.Windows.Forms.Label lblBoton;
        private System.Windows.Forms.Label lblEstadoRaton;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Label lblClics;
        private System.Windows.Forms.Label lblPulsaciones;
    }
}

