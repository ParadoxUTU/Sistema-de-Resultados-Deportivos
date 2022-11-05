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
            this.lblNombreEncuentro = new System.Windows.Forms.Label();
            this.lblMinuto = new System.Windows.Forms.Label();
            this.flpJugadores = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblNombreEncuentro
            // 
            this.lblNombreEncuentro.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreEncuentro.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEncuentro.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblNombreEncuentro.Location = new System.Drawing.Point(23, 9);
            this.lblNombreEncuentro.Name = "lblNombreEncuentro";
            this.lblNombreEncuentro.Size = new System.Drawing.Size(796, 32);
            this.lblNombreEncuentro.TabIndex = 32;
            this.lblNombreEncuentro.Text = "Nombre Encuentro";
            this.lblNombreEncuentro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNombreEncuentro.Click += new System.EventHandler(this.lblNombreEncuentro_Click);
            // 
            // lblMinuto
            // 
            this.lblMinuto.AutoSize = true;
            this.lblMinuto.BackColor = System.Drawing.Color.Transparent;
            this.lblMinuto.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinuto.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblMinuto.Location = new System.Drawing.Point(871, 9);
            this.lblMinuto.Name = "lblMinuto";
            this.lblMinuto.Size = new System.Drawing.Size(29, 32);
            this.lblMinuto.TabIndex = 31;
            this.lblMinuto.Text = "0";
            // 
            // flpJugadores
            // 
            this.flpJugadores.AutoScroll = true;
            this.flpJugadores.Location = new System.Drawing.Point(23, 68);
            this.flpJugadores.Name = "flpJugadores";
            this.flpJugadores.Size = new System.Drawing.Size(964, 436);
            this.flpJugadores.TabIndex = 30;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmVerEncuentroInd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(1004, 521);
            this.Controls.Add(this.lblNombreEncuentro);
            this.Controls.Add(this.lblMinuto);
            this.Controls.Add(this.flpJugadores);
            this.Name = "FrmVerEncuentroInd";
            this.Text = "FrmVerEncuentroInd";
            this.Load += new System.EventHandler(this.FrmVerEncuentroInd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreEncuentro;
        public System.Windows.Forms.Label lblMinuto;
        private System.Windows.Forms.FlowLayoutPanel flpJugadores;
        private System.Windows.Forms.Timer timer1;
    }
}