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
            this.lblMinuto = new System.Windows.Forms.Label();
            this.lblPuntaje2 = new System.Windows.Forms.Label();
            this.lblPuntaje1 = new System.Windows.Forms.Label();
            this.lblJugador2 = new System.Windows.Forms.Label();
            this.lblJugador1 = new System.Windows.Forms.Label();
            this.flpIncidencias = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblMinuto
            // 
            this.lblMinuto.AutoSize = true;
            this.lblMinuto.BackColor = System.Drawing.Color.Transparent;
            this.lblMinuto.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinuto.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblMinuto.Location = new System.Drawing.Point(473, 23);
            this.lblMinuto.Name = "lblMinuto";
            this.lblMinuto.Size = new System.Drawing.Size(29, 32);
            this.lblMinuto.TabIndex = 38;
            this.lblMinuto.Text = "0";
            // 
            // lblPuntaje2
            // 
            this.lblPuntaje2.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntaje2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje2.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblPuntaje2.Location = new System.Drawing.Point(519, 23);
            this.lblPuntaje2.Name = "lblPuntaje2";
            this.lblPuntaje2.Size = new System.Drawing.Size(250, 32);
            this.lblPuntaje2.TabIndex = 37;
            this.lblPuntaje2.Text = "0";
            this.lblPuntaje2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblPuntaje2.Click += new System.EventHandler(this.lblPuntaje2_Click);
            // 
            // lblPuntaje1
            // 
            this.lblPuntaje1.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntaje1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje1.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblPuntaje1.Location = new System.Drawing.Point(217, 23);
            this.lblPuntaje1.Name = "lblPuntaje1";
            this.lblPuntaje1.Size = new System.Drawing.Size(250, 32);
            this.lblPuntaje1.TabIndex = 36;
            this.lblPuntaje1.Text = "0";
            // 
            // lblJugador2
            // 
            this.lblJugador2.BackColor = System.Drawing.Color.Transparent;
            this.lblJugador2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador2.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblJugador2.Location = new System.Drawing.Point(840, 23);
            this.lblJugador2.Name = "lblJugador2";
            this.lblJugador2.Size = new System.Drawing.Size(146, 32);
            this.lblJugador2.TabIndex = 35;
            this.lblJugador2.Text = "Jugador 2";
            this.lblJugador2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblJugador1
            // 
            this.lblJugador1.BackColor = System.Drawing.Color.Transparent;
            this.lblJugador1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador1.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblJugador1.Location = new System.Drawing.Point(21, 23);
            this.lblJugador1.Name = "lblJugador1";
            this.lblJugador1.Size = new System.Drawing.Size(148, 32);
            this.lblJugador1.TabIndex = 34;
            this.lblJugador1.Text = "Jugador 1";
            // 
            // flpIncidencias
            // 
            this.flpIncidencias.AutoScroll = true;
            this.flpIncidencias.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpIncidencias.Location = new System.Drawing.Point(22, 81);
            this.flpIncidencias.Name = "flpIncidencias";
            this.flpIncidencias.Size = new System.Drawing.Size(964, 417);
            this.flpIncidencias.TabIndex = 33;
            this.flpIncidencias.Paint += new System.Windows.Forms.PaintEventHandler(this.flpIncidencias_Paint);
            // 
            // FrmVerEncuentroIndDeADos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(1005, 521);
            this.Controls.Add(this.lblMinuto);
            this.Controls.Add(this.lblPuntaje2);
            this.Controls.Add(this.lblPuntaje1);
            this.Controls.Add(this.lblJugador2);
            this.Controls.Add(this.lblJugador1);
            this.Controls.Add(this.flpIncidencias);
            this.Name = "FrmVerEncuentroIndDeADos";
            this.Text = "FrmVerEncuentroIndDeADos";
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
    }
}