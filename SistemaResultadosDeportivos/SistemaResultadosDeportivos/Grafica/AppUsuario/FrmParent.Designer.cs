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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParent));
            this.btnEncuentros = new System.Windows.Forms.Button();
            this.btnEquipos = new System.Windows.Forms.Button();
            this.btnJugadores = new System.Windows.Forms.Button();
            this.btnTorneos = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEncuentros
            // 
            resources.ApplyResources(this.btnEncuentros, "btnEncuentros");
            this.btnEncuentros.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEncuentros.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnEncuentros.Name = "btnEncuentros";
            this.btnEncuentros.UseVisualStyleBackColor = false;
            this.btnEncuentros.Click += new System.EventHandler(this.btnEncuentros_Click);
            // 
            // btnEquipos
            // 
            resources.ApplyResources(this.btnEquipos, "btnEquipos");
            this.btnEquipos.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEquipos.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnEquipos.Name = "btnEquipos";
            this.btnEquipos.UseVisualStyleBackColor = false;
            this.btnEquipos.Click += new System.EventHandler(this.btnEquipos_Click);
            // 
            // btnJugadores
            // 
            resources.ApplyResources(this.btnJugadores, "btnJugadores");
            this.btnJugadores.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnJugadores.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnJugadores.Name = "btnJugadores";
            this.btnJugadores.UseVisualStyleBackColor = false;
            this.btnJugadores.Click += new System.EventHandler(this.btnJugadores_Click);
            // 
            // btnTorneos
            // 
            resources.ApplyResources(this.btnTorneos, "btnTorneos");
            this.btnTorneos.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnTorneos.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnTorneos.Name = "btnTorneos";
            this.btnTorneos.UseVisualStyleBackColor = false;
            this.btnTorneos.Click += new System.EventHandler(this.btnTorneos_Click);
            // 
            // btnPerfil
            // 
            resources.ApplyResources(this.btnPerfil, "btnPerfil");
            this.btnPerfil.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnPerfil.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // FrmParent
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.btnTorneos);
            this.Controls.Add(this.btnJugadores);
            this.Controls.Add(this.btnEquipos);
            this.Controls.Add(this.btnEncuentros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmParent";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEncuentros;
        private System.Windows.Forms.Button btnEquipos;
        private System.Windows.Forms.Button btnJugadores;
        private System.Windows.Forms.Button btnTorneos;
        private System.Windows.Forms.Button btnPerfil;
    }
}