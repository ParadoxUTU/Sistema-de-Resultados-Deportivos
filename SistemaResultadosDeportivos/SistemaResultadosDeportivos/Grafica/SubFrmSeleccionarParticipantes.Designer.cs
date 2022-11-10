namespace SistemaResultadosDeportivos
{
    partial class SubFrmSeleccionarParticipantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubFrmSeleccionarParticipantes));
            this.flpParticipantes = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.pnlLupa = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pnlBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpParticipantes
            // 
            resources.ApplyResources(this.flpParticipantes, "flpParticipantes");
            this.flpParticipantes.Name = "flpParticipantes";
            // 
            // pnlBuscar
            // 
            resources.ApplyResources(this.pnlBuscar, "pnlBuscar");
            this.pnlBuscar.Controls.Add(this.pnlLupa);
            this.pnlBuscar.Controls.Add(this.btnBuscar);
            this.pnlBuscar.Controls.Add(this.txtBuscar);
            this.pnlBuscar.Name = "pnlBuscar";
            // 
            // pnlLupa
            // 
            resources.ApplyResources(this.pnlLupa, "pnlLupa");
            this.pnlLupa.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLupa.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.lupa;
            this.pnlLupa.Name = "pnlLupa";
            // 
            // btnBuscar
            // 
            resources.ApplyResources(this.btnBuscar, "btnBuscar");
            this.btnBuscar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            resources.ApplyResources(this.txtBuscar, "txtBuscar");
            this.txtBuscar.Name = "txtBuscar";
            // 
            // SubFrmSeleccionarParticipantes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.flpParticipantes);
            this.Name = "SubFrmSeleccionarParticipantes";
            this.Load += new System.EventHandler(this.SubFrmSeleccionarParticipantes_Load);
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpParticipantes;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel pnlLupa;
    }
}