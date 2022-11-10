namespace SistemaResultadosDeportivos
{
    partial class FrmVerEncuentroEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerEncuentroEquipo));
            this.flpIncidencias = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMinuto = new System.Windows.Forms.Label();
            this.lblPuntaje2 = new System.Windows.Forms.Label();
            this.lblPuntaje1 = new System.Windows.Forms.Label();
            this.lblEquipo2 = new System.Windows.Forms.Label();
            this.lblEquipo1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSuscribirse = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // flpIncidencias
            // 
            resources.ApplyResources(this.flpIncidencias, "flpIncidencias");
            this.flpIncidencias.Name = "flpIncidencias";
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
            // 
            // lblPuntaje1
            // 
            resources.ApplyResources(this.lblPuntaje1, "lblPuntaje1");
            this.lblPuntaje1.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntaje1.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblPuntaje1.Name = "lblPuntaje1";
            // 
            // lblEquipo2
            // 
            resources.ApplyResources(this.lblEquipo2, "lblEquipo2");
            this.lblEquipo2.BackColor = System.Drawing.Color.Transparent;
            this.lblEquipo2.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblEquipo2.Name = "lblEquipo2";
            // 
            // lblEquipo1
            // 
            resources.ApplyResources(this.lblEquipo1, "lblEquipo1");
            this.lblEquipo1.BackColor = System.Drawing.Color.Transparent;
            this.lblEquipo1.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblEquipo1.Name = "lblEquipo1";
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
            // timer2
            // 
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FrmVerEncuentroEquipo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.Controls.Add(this.btnSuscribirse);
            this.Controls.Add(this.lblMinuto);
            this.Controls.Add(this.lblPuntaje2);
            this.Controls.Add(this.lblPuntaje1);
            this.Controls.Add(this.lblEquipo2);
            this.Controls.Add(this.lblEquipo1);
            this.Controls.Add(this.flpIncidencias);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVerEncuentroEquipo";
            this.Load += new System.EventHandler(this.FrmVerEncuentroApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpIncidencias;
        public System.Windows.Forms.Label lblMinuto;
        public System.Windows.Forms.Label lblPuntaje2;
        public System.Windows.Forms.Label lblPuntaje1;
        private System.Windows.Forms.Label lblEquipo2;
        private System.Windows.Forms.Label lblEquipo1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSuscribirse;
        private System.Windows.Forms.Timer timer2;
    }
}