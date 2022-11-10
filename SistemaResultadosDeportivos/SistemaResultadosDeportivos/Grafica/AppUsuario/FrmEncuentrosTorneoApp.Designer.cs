namespace SistemaResultadosDeportivos
{
    partial class FrmEncuentrosTorneoApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEncuentrosTorneoApp));
            this.flpEncuentros = new System.Windows.Forms.FlowLayoutPanel();
            this.banner = new System.Windows.Forms.PictureBox();
            this.btnSuscribirse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            this.SuspendLayout();
            // 
            // flpEncuentros
            // 
            resources.ApplyResources(this.flpEncuentros, "flpEncuentros");
            this.flpEncuentros.Name = "flpEncuentros";
            // 
            // banner
            // 
            resources.ApplyResources(this.banner, "banner");
            this.banner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.banner.Name = "banner";
            this.banner.TabStop = false;
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
            // FrmEncuentrosTorneoApp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.Controls.Add(this.btnSuscribirse);
            this.Controls.Add(this.flpEncuentros);
            this.Controls.Add(this.banner);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEncuentrosTorneoApp";
            this.Load += new System.EventHandler(this.FrmEncuentrosTorneoApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpEncuentros;
        private System.Windows.Forms.PictureBox banner;
        private System.Windows.Forms.Button btnSuscribirse;
    }
}