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
            this.flpJugadores = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpJugadores
            // 
            this.flpJugadores.AutoScroll = true;
            this.flpJugadores.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpJugadores.Location = new System.Drawing.Point(12, 12);
            this.flpJugadores.Name = "flpJugadores";
            this.flpJugadores.Size = new System.Drawing.Size(884, 441);
            this.flpJugadores.TabIndex = 17;
            this.flpJugadores.WrapContents = false;
            // 
            // SeleccionarJugadorAlineacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(911, 463);
            this.Controls.Add(this.flpJugadores);
            this.Name = "SeleccionarJugadorAlineacion";
            this.Text = "SeleccionarJugadorAlineacion";
            this.Load += new System.EventHandler(this.SeleccionarJugadorAlineacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpJugadores;
    }
}