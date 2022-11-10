namespace SistemaResultadosDeportivos
{
    partial class FrmTorneosDeporteApp
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
            this.flpTorneos = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpTorneos
            // 
            this.flpTorneos.AutoScroll = true;
            this.flpTorneos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTorneos.Location = new System.Drawing.Point(12, 12);
            this.flpTorneos.Name = "flpTorneos";
            this.flpTorneos.Size = new System.Drawing.Size(967, 564);
            this.flpTorneos.TabIndex = 3;
            this.flpTorneos.Paint += new System.Windows.Forms.PaintEventHandler(this.flpTorneos_Paint);
            // 
            // FrmTorneosDeporteApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(991, 589);
            this.Controls.Add(this.flpTorneos);
            this.Name = "FrmTorneosDeporteApp";
            this.Text = "FrmTorneosDeporteApp";
            this.Load += new System.EventHandler(this.FrmTorneosDeporteApp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTorneos;
    }
}