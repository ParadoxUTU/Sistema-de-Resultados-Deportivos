namespace SistemaResultadosDeportivos
{
    partial class FrmInicioEncuentros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioEncuentros));
            this.btnCrear = new System.Windows.Forms.Button();
            this.flpEncuentros = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            resources.ApplyResources(this.btnCrear, "btnCrear");
            this.btnCrear.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCrear.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // flpEncuentros
            // 
            resources.ApplyResources(this.flpEncuentros, "flpEncuentros");
            this.flpEncuentros.Name = "flpEncuentros";
            // 
            // FrmInicioEncuentros
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.Controls.Add(this.flpEncuentros);
            this.Controls.Add(this.btnCrear);
            this.Name = "FrmInicioEncuentros";
            this.Load += new System.EventHandler(this.FrmInicioEncuentros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.FlowLayoutPanel flpEncuentros;
    }
}