namespace SistemaResultadosDeportivos
{
    partial class FrmVerEncuentroInd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerEncuentroInd));
            this.lblNombreEncuentro = new System.Windows.Forms.Label();
            this.lblMinuto = new System.Windows.Forms.Label();
            this.flpJugadores = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnSuscribirse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreEncuentro
            // 
            resources.ApplyResources(this.lblNombreEncuentro, "lblNombreEncuentro");
            this.lblNombreEncuentro.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreEncuentro.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblNombreEncuentro.Name = "lblNombreEncuentro";
            this.lblNombreEncuentro.Click += new System.EventHandler(this.lblNombreEncuentro_Click);
            // 
            // lblMinuto
            // 
            resources.ApplyResources(this.lblMinuto, "lblMinuto");
            this.lblMinuto.BackColor = System.Drawing.Color.Transparent;
            this.lblMinuto.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblMinuto.Name = "lblMinuto";
            // 
            // flpJugadores
            // 
            resources.ApplyResources(this.flpJugadores, "flpJugadores");
            this.flpJugadores.Name = "flpJugadores";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
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
            // FrmVerEncuentroInd
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.Controls.Add(this.btnSuscribirse);
            this.Controls.Add(this.lblNombreEncuentro);
            this.Controls.Add(this.lblMinuto);
            this.Controls.Add(this.flpJugadores);
            this.Name = "FrmVerEncuentroInd";
            this.Load += new System.EventHandler(this.FrmVerEncuentroInd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreEncuentro;
        public System.Windows.Forms.Label lblMinuto;
        private System.Windows.Forms.FlowLayoutPanel flpJugadores;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnSuscribirse;
    }
}