namespace SistemaResultadosDeportivos
{
    partial class SubFrmEquipoApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubFrmEquipoApp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlantel = new System.Windows.Forms.Button();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSuscribirse = new System.Windows.Forms.Button();
            this.pnlPerfil = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.btnPlantel);
            this.panel1.Controls.Add(this.txtPais);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSuscribirse);
            this.panel1.Controls.Add(this.pnlPerfil);
            this.panel1.Name = "panel1";
            // 
            // btnPlantel
            // 
            resources.ApplyResources(this.btnPlantel, "btnPlantel");
            this.btnPlantel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnPlantel.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnPlantel.Name = "btnPlantel";
            this.btnPlantel.UseVisualStyleBackColor = false;
            this.btnPlantel.Click += new System.EventHandler(this.btnPlantel_Click);
            // 
            // txtPais
            // 
            resources.ApplyResources(this.txtPais, "txtPais");
            this.txtPais.Name = "txtPais";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Name = "label3";
            // 
            // txtNombre
            // 
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.Name = "txtNombre";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Name = "label2";
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
            // pnlPerfil
            // 
            resources.ApplyResources(this.pnlPerfil, "pnlPerfil");
            this.pnlPerfil.Name = "pnlPerfil";
            // 
            // SubFrmEquipoApp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubFrmEquipoApp";
            this.Load += new System.EventHandler(this.SubFrmEquipoApp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSuscribirse;
        private System.Windows.Forms.Panel pnlPerfil;
        private System.Windows.Forms.Button btnPlantel;
    }
}