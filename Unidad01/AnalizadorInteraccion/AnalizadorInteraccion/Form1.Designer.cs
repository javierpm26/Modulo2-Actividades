namespace AnalizadorInteraccion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            grpTeclado = new GroupBox();
            lblTotal = new Label();
            lblLetras = new Label();
            lblNumeros = new Label();
            lblOtras = new Label();
            grpRaton = new GroupBox();
            lblMovimientos = new Label();
            lblClicIzquierdo = new Label();
            lblClicDerecho = new Label();
            lblDobleClics = new Label();
            lblPosicionX = new Label();
            lblPosicionY = new Label();
            lblUltimaAccion = new Label();
            grpTeclado.SuspendLayout();
            grpRaton.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(275, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(321, 24);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "ANALIZADOR DE INTERACCIÓN";
            // 
            // grpTeclado
            // 
            grpTeclado.Controls.Add(lblOtras);
            grpTeclado.Controls.Add(lblNumeros);
            grpTeclado.Controls.Add(lblLetras);
            grpTeclado.Controls.Add(lblTotal);
            grpTeclado.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpTeclado.Location = new Point(23, 86);
            grpTeclado.Name = "grpTeclado";
            grpTeclado.Size = new Size(380, 300);
            grpTeclado.TabIndex = 1;
            grpTeclado.TabStop = false;
            grpTeclado.Text = "TECLADO";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(6, 38);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(52, 20);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total: 0";
            // 
            // lblLetras
            // 
            lblLetras.AutoSize = true;
            lblLetras.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLetras.Location = new Point(6, 58);
            lblLetras.Name = "lblLetras";
            lblLetras.Size = new Size(60, 20);
            lblLetras.TabIndex = 1;
            lblLetras.Text = "Letras: 0";
            // 
            // lblNumeros
            // 
            lblNumeros.AutoSize = true;
            lblNumeros.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumeros.Location = new Point(6, 78);
            lblNumeros.Name = "lblNumeros";
            lblNumeros.Size = new Size(78, 20);
            lblNumeros.TabIndex = 2;
            lblNumeros.Text = "Números: 0";
            // 
            // lblOtras
            // 
            lblOtras.AutoSize = true;
            lblOtras.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOtras.Location = new Point(6, 98);
            lblOtras.Name = "lblOtras";
            lblOtras.Size = new Size(55, 20);
            lblOtras.TabIndex = 3;
            lblOtras.Text = "Otras: 0";
            // 
            // grpRaton
            // 
            grpRaton.Controls.Add(lblPosicionY);
            grpRaton.Controls.Add(lblPosicionX);
            grpRaton.Controls.Add(lblDobleClics);
            grpRaton.Controls.Add(lblClicDerecho);
            grpRaton.Controls.Add(lblClicIzquierdo);
            grpRaton.Controls.Add(lblMovimientos);
            grpRaton.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpRaton.Location = new Point(409, 86);
            grpRaton.Name = "grpRaton";
            grpRaton.Size = new Size(380, 300);
            grpRaton.TabIndex = 2;
            grpRaton.TabStop = false;
            grpRaton.Text = "RATÓN";
            // 
            // lblMovimientos
            // 
            lblMovimientos.AutoSize = true;
            lblMovimientos.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMovimientos.Location = new Point(7, 38);
            lblMovimientos.Name = "lblMovimientos";
            lblMovimientos.Size = new Size(100, 20);
            lblMovimientos.TabIndex = 0;
            lblMovimientos.Text = "Movimientos: 0";
            // 
            // lblClicIzquierdo
            // 
            lblClicIzquierdo.AutoSize = true;
            lblClicIzquierdo.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClicIzquierdo.Location = new Point(7, 58);
            lblClicIzquierdo.Name = "lblClicIzquierdo";
            lblClicIzquierdo.Size = new Size(120, 20);
            lblClicIzquierdo.TabIndex = 1;
            lblClicIzquierdo.Text = "Clics izquierdos: 0";
            // 
            // lblClicDerecho
            // 
            lblClicDerecho.AutoSize = true;
            lblClicDerecho.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClicDerecho.Location = new Point(7, 78);
            lblClicDerecho.Name = "lblClicDerecho";
            lblClicDerecho.Size = new Size(114, 20);
            lblClicDerecho.TabIndex = 2;
            lblClicDerecho.Text = "Clics derechos: 0";
            // 
            // lblDobleClics
            // 
            lblDobleClics.AutoSize = true;
            lblDobleClics.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDobleClics.Location = new Point(9, 98);
            lblDobleClics.Name = "lblDobleClics";
            lblDobleClics.Size = new Size(98, 20);
            lblDobleClics.TabIndex = 3;
            lblDobleClics.Text = "Dobles clics: 0";
            // 
            // lblPosicionX
            // 
            lblPosicionX.AutoSize = true;
            lblPosicionX.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPosicionX.Location = new Point(9, 131);
            lblPosicionX.Name = "lblPosicionX";
            lblPosicionX.Size = new Size(88, 20);
            lblPosicionX.TabIndex = 4;
            lblPosicionX.Text = "Posición X: 0";
            // 
            // lblPosicionY
            // 
            lblPosicionY.AutoSize = true;
            lblPosicionY.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPosicionY.Location = new Point(9, 151);
            lblPosicionY.Name = "lblPosicionY";
            lblPosicionY.Size = new Size(89, 20);
            lblPosicionY.TabIndex = 5;
            lblPosicionY.Text = "Posición Y: 0";
            // 
            // lblUltimaAccion
            // 
            lblUltimaAccion.AutoSize = true;
            lblUltimaAccion.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUltimaAccion.Location = new Point(374, 405);
            lblUltimaAccion.Name = "lblUltimaAccion";
            lblUltimaAccion.Size = new Size(123, 19);
            lblUltimaAccion.TabIndex = 6;
            lblUltimaAccion.Text = "Última Acción: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblUltimaAccion);
            Controls.Add(grpRaton);
            Controls.Add(grpTeclado);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            grpTeclado.ResumeLayout(false);
            grpTeclado.PerformLayout();
            grpRaton.ResumeLayout(false);
            grpRaton.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox grpTeclado;
        private Label lblNumeros;
        private Label lblLetras;
        private Label lblTotal;
        private Label lblOtras;
        private GroupBox grpRaton;
        private Label lblMovimientos;
        private Label lblPosicionX;
        private Label lblDobleClics;
        private Label lblClicDerecho;
        private Label lblClicIzquierdo;
        private Label lblPosicionY;
        private Label lblUltimaAccion;
    }
}
