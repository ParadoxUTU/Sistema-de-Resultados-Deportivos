namespace SistemaResultadosDeportivos
{
    partial class FrmVerEncuentroIndDeADos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerEncuentroIndDeADos));
            this.lblMinuto = new System.Windows.Forms.Label();
            this.lblPuntaje2 = new System.Windows.Forms.Label();
            this.lblPuntaje1 = new System.Windows.Forms.Label();
            this.lblJugador2 = new System.Windows.Forms.Label();
            this.lblJugador1 = new System.Windows.Forms.Label();
            this.flpIncidencias = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSuscribirse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMinuto
            // 
            resources.ApplyResources(this.lblMinuto, "lblMinuto");
            this.lblMinuto.BackColor = System.Drawing.Color.Transparent;
            this.lblMinuto.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblMinuto.Name = "lblMinuto";
            // 
            // lblPuntaje2
            // 
            resources.ApplyResources(this.lblPuntaje2, "lblPuntaje2");
            this.lblPuntaje2.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntaje2.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblPuntaje2.Name = "lblPuntaje2";
            this.lblPuntaje2.Click += new System.EventHandler(this.lblPuntaje2_Click);
            // 
            // lblPuntaje1
            // 
            resources.ApplyResources(this.lblPuntaje1, "lblPuntaje1");
            this.lblPuntaje1.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntaje1.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblPuntaje1.Name = "lblPuntaje1";
            // 
            // lblJugador2
            // 
            resources.ApplyResources(this.lblJugador2, "lblJugador2");
            this.lblJugador2.BackColor = System.Drawing.Color.Transparent;
            this.lblJugador2.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblJugador2.Name = "lblJugador2";
            // 
            // lblJugador1
            // 
            resources.ApplyResources(this.lblJugador1, "lblJugador1");
            this.lblJugador1.BackColor = System.Drawing.Color.Transparent;
            this.lblJugador1.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblJugador1.Name = "lblJugador1";
            // 
            // flpIncidencias
            // 
            resources.ApplyResources(this.flpIncidencias, "flpIncidencias");
            this.flpIncidencias.Name = "flpIncidencias";
            this.flpIncidencias.Paint += new System.Windows.Forms.PaintEventHandler(this.flpIncidencias_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSuscribirse
            // 
            resources.ApplyResources(this.btnSuscribirse, "btnSuscribirse");
            this.btnSuscribirse.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSuscribirse.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnSuscribirse.Name = "btnSuscribirse";
            this.btnSuscribirse.UseVisualStyleBackColor = false;
            this.btnSuscribirse.Click += new System.EventHandler(this.btnSuscribirse_Click);
            // 
            // FrmVerEncuentroIndDeADos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.Controls.Add(this.btnSuscribirse);
            this.Controls.Add(this.lblMinuto);
            this.Controls.Add(this.lblPuntaje2);
            this.Controls.Add(this.lblPuntaje1);
            this.Controls.Add(this.lblJugador2);
            this.Controls.Add(this.lblJugador1);
            this.Controls.Add(this.flpIncidencias);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVerEncuentroIndDeADos";
            this.Load += new System.EventHandler(this.FrmVerEncuentroIndDeADos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblMinuto;
        public System.Windows.Forms.Label lblPuntaje2;
        public System.Windows.Forms.Label lblPuntaje1;
        private System.Windows.Forms.Label lblJugador2;
        private System.Windows.Forms.Label lblJugador1;
        private System.Windows.Forms.FlowLayoutPanel flpIncidencias;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSuscribirse;
    }
}