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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarEncInd));
            this.flpJugadores = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMinuto = new System.Windows.Forms.Label();
            this.lblNombreEncuentro = new System.Windows.Forms.Label();
            this.btnAgregarPuntos = new System.Windows.Forms.Button();
            this.btnQuitarPuntos = new System.Windows.Forms.Button();
            this.numPuntuacion = new System.Windows.Forms.NumericUpDown();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnReanudar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numPuntuacion)).BeginInit();
            this.SuspendLayout();
            // 
            // flpJugadores
            // 
            resources.ApplyResources(this.flpJugadores, "flpJugadores");
            this.flpJugadores.Name = "flpJugadores";
            // 
            // lblMinuto
            // 
            resources.ApplyResources(this.lblMinuto, "lblMinuto");
            this.lblMinuto.BackColor = System.Drawing.Color.Transparent;
            this.lblMinuto.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblMinuto.Name = "lblMinuto";
            // 
            // lblNombreEncuentro
            // 
            resources.ApplyResources(this.lblNombreEncuentro, "lblNombreEncuentro");
            this.lblNombreEncuentro.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreEncuentro.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblNombreEncuentro.Name = "lblNombreEncuentro";
            // 
            // btnAgregarPuntos
            // 
            resources.ApplyResources(this.btnAgregarPuntos, "btnAgregarPuntos");
            this.btnAgregarPuntos.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAgregarPuntos.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAgregarPuntos.Name = "btnAgregarPuntos";
            this.btnAgregarPuntos.UseVisualStyleBackColor = false;
            this.btnAgregarPuntos.Click += new System.EventHandler(this.btnAgregarPuntos_Click);
            // 
            // btnQuitarPuntos
            // 
            resources.ApplyResources(this.btnQuitarPuntos, "btnQuitarPuntos");
            this.btnQuitarPuntos.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnQuitarPuntos.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnQuitarPuntos.Name = "btnQuitarPuntos";
            this.btnQuitarPuntos.UseVisualStyleBackColor = false;
            this.btnQuitarPuntos.Click += new System.EventHandler(this.btnQuitarPuntos_Click);
            // 
            // numPuntuacion
            // 
            resources.ApplyResources(this.numPuntuacion, "numPuntuacion");
            this.numPuntuacion.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numPuntuacion.Name = "numPuntuacion";
            // 
            // btnIniciar
            // 
            resources.ApplyResources(this.btnIniciar, "btnIniciar");
            this.btnIniciar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnPausar
            // 
            resources.ApplyResources(this.btnPausar, "btnPausar");
            this.btnPausar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnPausar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.UseVisualStyleBackColor = false;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnFinalizar
            // 
            resources.ApplyResources(this.btnFinalizar, "btnFinalizar");
            this.btnFinalizar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnReanudar
            // 
            resources.ApplyResources(this.btnReanudar, "btnReanudar");
            this.btnReanudar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnReanudar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnReanudar.Name = "btnReanudar";
            this.btnReanudar.UseVisualStyleBackColor = false;
            this.btnReanudar.Click += new System.EventHandler(this.btnReanudar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmGestionarEncInd
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnReanudar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.numPuntuacion);
            this.Controls.Add(this.btnQuitarPuntos);
            this.Controls.Add(this.btnAgregarPuntos);
            this.Controls.Add(this.lblNombreEncuentro);
            this.Controls.Add(this.lblMinuto);
            this.Controls.Add(this.flpJugadores);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGestionarEncInd";
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
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnReanudar;
        private System.Windows.Forms.Timer timer1;
    }
}