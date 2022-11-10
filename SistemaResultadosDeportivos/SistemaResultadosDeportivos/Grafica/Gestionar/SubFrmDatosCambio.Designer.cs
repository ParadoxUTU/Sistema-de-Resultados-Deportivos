namespace SistemaResultadosDeportivos
{
    partial class SubFrmDatosCambio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubFrmDatosCambio));
            this.flpAlineacion = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPlantel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblEquipo1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpAlineacion
            // 
            resources.ApplyResources(this.flpAlineacion, "flpAlineacion");
            this.flpAlineacion.Name = "flpAlineacion";
            // 
            // flpPlantel
            // 
            resources.ApplyResources(this.flpPlantel, "flpPlantel");
            this.flpPlantel.Name = "flpPlantel";
            // 
            // btnAceptar
            // 
            resources.ApplyResources(this.btnAceptar, "btnAceptar");
            this.btnAceptar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblEquipo1
            // 
            resources.ApplyResources(this.lblEquipo1, "lblEquipo1");
            this.lblEquipo1.BackColor = System.Drawing.Color.Transparent;
            this.lblEquipo1.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblEquipo1.Name = "lblEquipo1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Name = "label1";
            // 
            // SubFrmDatosCambio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEquipo1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.flpPlantel);
            this.Controls.Add(this.flpAlineacion);
            this.Name = "SubFrmDatosCambio";
            this.Load += new System.EventHandler(this.SubFrmDatosCambio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpAlineacion;
        private System.Windows.Forms.FlowLayoutPanel flpPlantel;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblEquipo1;
        private System.Windows.Forms.Label label1;
    }
}