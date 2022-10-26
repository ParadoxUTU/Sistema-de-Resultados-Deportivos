namespace SistemaResultadosDeportivos
{
    partial class FrmGestionarEncInd
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpJugadores = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMinuto = new System.Windows.Forms.Label();
            this.lblNombreEncuentro = new System.Windows.Forms.Label();
            this.btnAgregarPuntos = new System.Windows.Forms.Button();
            this.btnQuitarPuntos = new System.Windows.Forms.Button();
            this.numPuntuacion = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numPuntuacion)).BeginInit();
            this.SuspendLayout();
            // 
            // flpJugadores
            // 
            this.flpJugadores.AutoScroll = true;
            this.flpJugadores.Location = new System.Drawing.Point(22, 90);
            this.flpJugadores.Name = "flpJugadores";
            this.flpJugadores.Size = new System.Drawing.Size(964, 436);
            this.flpJugadores.TabIndex = 6;
            // 
            // lblMinuto
            // 
            this.lblMinuto.AutoSize = true;
            this.lblMinuto.BackColor = System.Drawing.Color.Transparent;
            this.lblMinuto.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinuto.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblMinuto.Location = new System.Drawing.Point(870, 31);
            this.lblMinuto.Name = "lblMinuto";
            this.lblMinuto.Size = new System.Drawing.Size(29, 32);
            this.lblMinuto.TabIndex = 28;
            this.lblMinuto.Text = "0";
            // 
            // lblNombreEncuentro
            // 
            this.lblNombreEncuentro.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreEncuentro.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEncuentro.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblNombreEncuentro.Location = new System.Drawing.Point(22, 31);
            this.lblNombreEncuentro.Name = "lblNombreEncuentro";
            this.lblNombreEncuentro.Size = new System.Drawing.Size(796, 32);
            this.lblNombreEncuentro.TabIndex = 29;
            this.lblNombreEncuentro.Text = "Nombre Encuentro";
            this.lblNombreEncuentro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarPuntos
            // 
            this.btnAgregarPuntos.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAgregarPuntos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarPuntos.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPuntos.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAgregarPuntos.Location = new System.Drawing.Point(28, 553);
            this.btnAgregarPuntos.Name = "btnAgregarPuntos";
            this.btnAgregarPuntos.Size = new System.Drawing.Size(220, 40);
            this.btnAgregarPuntos.TabIndex = 30;
            this.btnAgregarPuntos.Text = "Agregar Puntos";
            this.btnAgregarPuntos.UseVisualStyleBackColor = false;
            this.btnAgregarPuntos.Click += new System.EventHandler(this.btnAgregarPuntos_Click);
            // 
            // btnQuitarPuntos
            // 
            this.btnQuitarPuntos.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnQuitarPuntos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitarPuntos.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarPuntos.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnQuitarPuntos.Location = new System.Drawing.Point(766, 553);
            this.btnQuitarPuntos.Name = "btnQuitarPuntos";
            this.btnQuitarPuntos.Size = new System.Drawing.Size(220, 40);
            this.btnQuitarPuntos.TabIndex = 31;
            this.btnQuitarPuntos.Text = "Quitar Puntos";
            this.btnQuitarPuntos.UseVisualStyleBackColor = false;
            this.btnQuitarPuntos.Click += new System.EventHandler(this.btnQuitarPuntos_Click);
            // 
            // numPuntuacion
            // 
            this.numPuntuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPuntuacion.Location = new System.Drawing.Point(404, 553);
            this.numPuntuacion.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numPuntuacion.Name = "numPuntuacion";
            this.numPuntuacion.Size = new System.Drawing.Size(180, 38);
            this.numPuntuacion.TabIndex = 32;
            // 
            // FrmGestionarEncInd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(1008, 620);
            this.Controls.Add(this.numPuntuacion);
            this.Controls.Add(this.btnQuitarPuntos);
            this.Controls.Add(this.btnAgregarPuntos);
            this.Controls.Add(this.lblNombreEncuentro);
            this.Controls.Add(this.lblMinuto);
            this.Controls.Add(this.flpJugadores);
            this.Name = "FrmGestionarEncInd";
            this.Text = "FrmGestionarEncInd";
            this.Load += new System.EventHandler(this.FrmGestionarEncInd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPuntuacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpJugadores;
        public System.Windows.Forms.Label lblMinuto;
        private System.Windows.Forms.Label lblNombreEncuentro;
        private System.Windows.Forms.Button btnAgregarPuntos;
        private System.Windows.Forms.Button btnQuitarPuntos;
        private System.Windows.Forms.NumericUpDown numPuntuacion;
    }
}