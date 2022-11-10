namespace SistemaResultadosDeportivos
{
    partial class FrmEquiposDeporteApp
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
            this.flpEquipos = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpEquipos
            // 
            this.flpEquipos.AutoScroll = true;
            this.flpEquipos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEquipos.Location = new System.Drawing.Point(12, 12);
            this.flpEquipos.Name = "flpEquipos";
            this.flpEquipos.Size = new System.Drawing.Size(964, 556);
            this.flpEquipos.TabIndex = 35;
            // 
            // FrmEquiposDeporteApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(993, 580);
            this.Controls.Add(this.flpEquipos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEquiposDeporteApp";
            this.Text = "FrmEquiposDeporteApp";
            this.Load += new System.EventHandler(this.FrmEquiposDeporteApp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpEquipos;
    }
}