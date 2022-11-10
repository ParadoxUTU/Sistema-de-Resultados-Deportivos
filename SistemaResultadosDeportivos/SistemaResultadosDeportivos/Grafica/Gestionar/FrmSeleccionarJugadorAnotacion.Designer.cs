namespace SistemaResultadosDeportivos
{
    partial class FrmSeleccionarJugadorAnotacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeleccionarJugadorAnotacion));
            this.flpJugadores = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.numPuntuacion = new System.Windows.Forms.NumericUpDown();
            this.lblEquipo1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPuntuacion)).BeginInit();
            this.SuspendLayout();
            // 
            // flpJugadores
            // 
            resources.ApplyResources(this.flpJugadores, "flpJugadores");
            this.flpJugadores.Name = "flpJugadores";
            // 
            // btnAceptar
            // 
            resources.ApplyResources(this.btnAceptar, "btnAceptar");
            this.btnAceptar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // numPuntuacion
            // 
            resources.ApplyResources(this.numPuntuacion, "numPuntuacion");
            this.numPuntuacion.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numPuntuacion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPuntuacion.Name = "numPuntuacion";
            this.numPuntuacion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblEquipo1
            // 
            resources.ApplyResources(this.lblEquipo1, "lblEquipo1");
            this.lblEquipo1.BackColor = System.Drawing.Color.Transparent;
            this.lblEquipo1.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblEquipo1.Name = "lblEquipo1";
            this.lblEquipo1.Click += new System.EventHandler(this.lblEquipo1_Click);
            // 
            // FrmSeleccionarJugadorAnotacion
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.numPuntuacion);
            this.Controls.Add(this.lblEquipo1);
            this.Controls.Add(this.flpJugadores);
            this.Name = "FrmSeleccionarJugadorAnotacion";
            this.Load += new System.EventHandler(this.SeleccionarJugadorAlineacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPuntuacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpJugadores;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.NumericUpDown numPuntuacion;
        private System.Windows.Forms.Label lblEquipo1;
    }
}