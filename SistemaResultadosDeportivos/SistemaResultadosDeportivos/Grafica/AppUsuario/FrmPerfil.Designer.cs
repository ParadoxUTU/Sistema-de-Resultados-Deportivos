namespace SistemaResultadosDeportivos
{
    partial class FrmPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.pnlPerfil = new System.Windows.Forms.Panel();
            this.btnMembresia = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.txtContrasena);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnRecuperar);
            this.panel1.Controls.Add(this.pnlPerfil);
            this.panel1.Controls.Add(this.btnMembresia);
            this.panel1.Name = "panel1";
            // 
            // txtContrasena
            // 
            resources.ApplyResources(this.txtContrasena, "txtContrasena");
            this.txtContrasena.Name = "txtContrasena";
            // 
            // btnCerrar
            // 
            resources.ApplyResources(this.btnCerrar, "btnCerrar");
            this.btnCerrar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardar
            // 
            resources.ApplyResources(this.btnGuardar, "btnGuardar");
            this.btnGuardar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.Name = "txtUsername";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Name = "label2";
            // 
            // btnEliminar
            // 
            resources.ApplyResources(this.btnEliminar, "btnEliminar");
            this.btnEliminar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRecuperar
            // 
            resources.ApplyResources(this.btnRecuperar, "btnRecuperar");
            this.btnRecuperar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnRecuperar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.UseVisualStyleBackColor = false;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // pnlPerfil
            // 
            resources.ApplyResources(this.pnlPerfil, "pnlPerfil");
            this.pnlPerfil.Name = "pnlPerfil";
            // 
            // btnMembresia
            // 
            resources.ApplyResources(this.btnMembresia, "btnMembresia");
            this.btnMembresia.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnMembresia.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnMembresia.Name = "btnMembresia";
            this.btnMembresia.UseVisualStyleBackColor = false;
            this.btnMembresia.Click += new System.EventHandler(this.btnMembresia_Click);
            // 
            // FrmPerfil
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPerfil";
            this.Load += new System.EventHandler(this.FrmPerfil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.Panel pnlPerfil;
        private System.Windows.Forms.Button btnMembresia;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtContrasena;
    }
}