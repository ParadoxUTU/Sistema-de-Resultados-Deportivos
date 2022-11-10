namespace SistemaResultadosDeportivos
{
    partial class FrmGestionarEncCol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarEncCol));
            this.flpIncidencias = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregarPuntos1 = new System.Windows.Forms.Button();
            this.lblEquipo1 = new System.Windows.Forms.Label();
            this.lblEquipo2 = new System.Windows.Forms.Label();
            this.lblPuntaje1 = new System.Windows.Forms.Label();
            this.lblPuntaje2 = new System.Windows.Forms.Label();
            this.btnAgregarPuntos2 = new System.Windows.Forms.Button();
            this.lblMinuto = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnReanudar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnAmonestacion1 = new System.Windows.Forms.Button();
            this.btnAmonestacion2 = new System.Windows.Forms.Button();
            this.btnCambio1 = new System.Windows.Forms.Button();
            this.btnCambio2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpIncidencias
            // 
            resources.ApplyResources(this.flpIncidencias, "flpIncidencias");
            this.flpIncidencias.Name = "flpIncidencias";
            this.flpIncidencias.Paint += new System.Windows.Forms.PaintEventHandler(this.flpIncidencias_Paint);
            // 
            // btnAgregarPuntos1
            // 
            resources.ApplyResources(this.btnAgregarPuntos1, "btnAgregarPuntos1");
            this.btnAgregarPuntos1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAgregarPuntos1.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAgregarPuntos1.Name = "btnAgregarPuntos1";
            this.btnAgregarPuntos1.UseVisualStyleBackColor = false;
            this.btnAgregarPuntos1.Click += new System.EventHandler(this.btnAgregarPuntos1_Click);
            // 
            // lblEquipo1
            // 
            resources.ApplyResources(this.lblEquipo1, "lblEquipo1");
            this.lblEquipo1.BackColor = System.Drawing.Color.Transparent;
            this.lblEquipo1.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblEquipo1.Name = "lblEquipo1";
            this.lblEquipo1.Click += new System.EventHandler(this.lblEquipo1_Click);
            // 
            // lblEquipo2
            // 
            resources.ApplyResources(this.lblEquipo2, "lblEquipo2");
            this.lblEquipo2.BackColor = System.Drawing.Color.Transparent;
            this.lblEquipo2.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblEquipo2.Name = "lblEquipo2";
            // 
            // lblPuntaje1
            // 
            resources.ApplyResources(this.lblPuntaje1, "lblPuntaje1");
            this.lblPuntaje1.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntaje1.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblPuntaje1.Name = "lblPuntaje1";
            // 
            // lblPuntaje2
            // 
            resources.ApplyResources(this.lblPuntaje2, "lblPuntaje2");
            this.lblPuntaje2.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntaje2.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblPuntaje2.Name = "lblPuntaje2";
            this.lblPuntaje2.Click += new System.EventHandler(this.lblPuntaje2_Click);
            // 
            // btnAgregarPuntos2
            // 
            resources.ApplyResources(this.btnAgregarPuntos2, "btnAgregarPuntos2");
            this.btnAgregarPuntos2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAgregarPuntos2.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAgregarPuntos2.Name = "btnAgregarPuntos2";
            this.btnAgregarPuntos2.UseVisualStyleBackColor = false;
            this.btnAgregarPuntos2.Click += new System.EventHandler(this.btnAgregarPuntos2_Click);
            // 
            // lblMinuto
            // 
            resources.ApplyResources(this.lblMinuto, "lblMinuto");
            this.lblMinuto.BackColor = System.Drawing.Color.Transparent;
            this.lblMinuto.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblMinuto.Name = "lblMinuto";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // btnReanudar
            // 
            resources.ApplyResources(this.btnReanudar, "btnReanudar");
            this.btnReanudar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnReanudar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnReanudar.Name = "btnReanudar";
            this.btnReanudar.UseVisualStyleBackColor = false;
            this.btnReanudar.Click += new System.EventHandler(this.btnReanudar_Click);
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
            // btnIniciar
            // 
            resources.ApplyResources(this.btnIniciar, "btnIniciar");
            this.btnIniciar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnAmonestacion1
            // 
            resources.ApplyResources(this.btnAmonestacion1, "btnAmonestacion1");
            this.btnAmonestacion1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAmonestacion1.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAmonestacion1.Name = "btnAmonestacion1";
            this.btnAmonestacion1.UseVisualStyleBackColor = false;
            this.btnAmonestacion1.Click += new System.EventHandler(this.btnAmonestacion1_Click);
            // 
            // btnAmonestacion2
            // 
            resources.ApplyResources(this.btnAmonestacion2, "btnAmonestacion2");
            this.btnAmonestacion2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAmonestacion2.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAmonestacion2.Name = "btnAmonestacion2";
            this.btnAmonestacion2.UseVisualStyleBackColor = false;
            this.btnAmonestacion2.Click += new System.EventHandler(this.btnAmonestacion2_Click);
            // 
            // btnCambio1
            // 
            resources.ApplyResources(this.btnCambio1, "btnCambio1");
            this.btnCambio1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCambio1.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnCambio1.Name = "btnCambio1";
            this.btnCambio1.UseVisualStyleBackColor = false;
            this.btnCambio1.Click += new System.EventHandler(this.btnCambio1_Click);
            // 
            // btnCambio2
            // 
            resources.ApplyResources(this.btnCambio2, "btnCambio2");
            this.btnCambio2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCambio2.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnCambio2.Name = "btnCambio2";
            this.btnCambio2.UseVisualStyleBackColor = false;
            this.btnCambio2.Click += new System.EventHandler(this.btnCambio2_Click);
            // 
            // FrmGestionarEncCol
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.Controls.Add(this.btnCambio2);
            this.Controls.Add(this.btnCambio1);
            this.Controls.Add(this.btnAmonestacion2);
            this.Controls.Add(this.btnAmonestacion1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnReanudar);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.btnAgregarPuntos2);
            this.Controls.Add(this.lblMinuto);
            this.Controls.Add(this.lblPuntaje2);
            this.Controls.Add(this.lblPuntaje1);
            this.Controls.Add(this.lblEquipo2);
            this.Controls.Add(this.lblEquipo1);
            this.Controls.Add(this.btnAgregarPuntos1);
            this.Controls.Add(this.flpIncidencias);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGestionarEncCol";
            this.Load += new System.EventHandler(this.FrmGestionarEncCol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpIncidencias;
        private System.Windows.Forms.Button btnAgregarPuntos1;
        private System.Windows.Forms.Label lblEquipo1;
        private System.Windows.Forms.Label lblEquipo2;
        private System.Windows.Forms.Button btnAgregarPuntos2;
        public System.Windows.Forms.Label lblPuntaje1;
        public System.Windows.Forms.Label lblPuntaje2;
        public System.Windows.Forms.Label lblMinuto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnReanudar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnAmonestacion1;
        private System.Windows.Forms.Button btnAmonestacion2;
        private System.Windows.Forms.Button btnCambio1;
        private System.Windows.Forms.Button btnCambio2;
    }
}