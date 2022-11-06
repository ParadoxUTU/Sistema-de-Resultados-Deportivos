namespace SistemaResultadosDeportivos
{
    partial class FrmParent
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
            this.btnEncuentros = new System.Windows.Forms.Button();
            this.btnEquipos = new System.Windows.Forms.Button();
            this.btnJugadores = new System.Windows.Forms.Button();
            this.btnTorneos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEncuentros
            // 
            this.btnEncuentros.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEncuentros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEncuentros.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncuentros.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnEncuentros.Location = new System.Drawing.Point(16, 28);
            this.btnEncuentros.Name = "btnEncuentros";
            this.btnEncuentros.Size = new System.Drawing.Size(220, 40);
            this.btnEncuentros.TabIndex = 7;
            this.btnEncuentros.Text = "Encuentros";
            this.btnEncuentros.UseVisualStyleBackColor = false;
            this.btnEncuentros.Click += new System.EventHandler(this.btnEncuentros_Click);
            // 
            // btnEquipos
            // 
            this.btnEquipos.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEquipos.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipos.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnEquipos.Location = new System.Drawing.Point(16, 131);
            this.btnEquipos.Name = "btnEquipos";
            this.btnEquipos.Size = new System.Drawing.Size(220, 40);
            this.btnEquipos.TabIndex = 8;
            this.btnEquipos.Text = "Equipos";
            this.btnEquipos.UseVisualStyleBackColor = false;
            this.btnEquipos.Click += new System.EventHandler(this.btnEquipos_Click);
            // 
            // btnJugadores
            // 
            this.btnJugadores.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnJugadores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJugadores.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugadores.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnJugadores.Location = new System.Drawing.Point(348, 28);
            this.btnJugadores.Name = "btnJugadores";
            this.btnJugadores.Size = new System.Drawing.Size(220, 40);
            this.btnJugadores.TabIndex = 9;
            this.btnJugadores.Text = "Jugadores";
            this.btnJugadores.UseVisualStyleBackColor = false;
            this.btnJugadores.Click += new System.EventHandler(this.btnJugadores_Click);
            // 
            // btnTorneos
            // 
            this.btnTorneos.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnTorneos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTorneos.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTorneos.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnTorneos.Location = new System.Drawing.Point(348, 131);
            this.btnTorneos.Name = "btnTorneos";
            this.btnTorneos.Size = new System.Drawing.Size(220, 40);
            this.btnTorneos.TabIndex = 10;
            this.btnTorneos.Text = "Torneos";
            this.btnTorneos.UseVisualStyleBackColor = false;
            this.btnTorneos.Click += new System.EventHandler(this.btnTorneos_Click);
            // 
            // FrmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(589, 200);
            this.Controls.Add(this.btnTorneos);
            this.Controls.Add(this.btnJugadores);
            this.Controls.Add(this.btnEquipos);
            this.Controls.Add(this.btnEncuentros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmParent";
            this.Text = "FrmParent";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEncuentros;
        private System.Windows.Forms.Button btnEquipos;
        private System.Windows.Forms.Button btnJugadores;
        private System.Windows.Forms.Button btnTorneos;
    }
}