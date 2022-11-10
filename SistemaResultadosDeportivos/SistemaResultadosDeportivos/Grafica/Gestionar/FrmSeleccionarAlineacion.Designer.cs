namespace SistemaResultadosDeportivos
{
    partial class FrmSeleccionarAlineacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeleccionarAlineacion));
            this.flpJugadores = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpJugadores
            // 
            resources.ApplyResources(this.flpJugadores, "flpJugadores");
            this.flpJugadores.Name = "flpJugadores";
            this.flpJugadores.Paint += new System.Windows.Forms.PaintEventHandler(this.flpJugadores_Paint);
            // 
            // lblEquipo
            // 
            resources.ApplyResources(this.lblEquipo, "lblEquipo");
            this.lblEquipo.BackColor = System.Drawing.Color.Transparent;
            this.lblEquipo.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Click += new System.EventHandler(this.lblEquipo_Click);
            // 
            // btnSiguiente
            // 
            resources.ApplyResources(this.btnSiguiente, "btnSiguiente");
            this.btnSiguiente.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSiguiente.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // FrmSeleccionarAlineacion
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.flpJugadores);
            this.Name = "FrmSeleccionarAlineacion";
            this.Load += new System.EventHandler(this.FrmSeleccionarAlineacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpJugadores;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Button btnSiguiente;
    }
}