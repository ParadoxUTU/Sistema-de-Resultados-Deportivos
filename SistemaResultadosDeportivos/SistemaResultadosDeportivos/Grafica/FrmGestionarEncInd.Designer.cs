namespace SistemaResultadosDeportivos.Grafica
{
    partial class FrmGestionarEncInd
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
            this.flpEncuentros = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpEncuentros
            // 
            this.flpEncuentros.AutoScroll = true;
            this.flpEncuentros.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEncuentros.Location = new System.Drawing.Point(12, 93);
            this.flpEncuentros.Name = "flpEncuentros";
            this.flpEncuentros.Size = new System.Drawing.Size(964, 408);
            this.flpEncuentros.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(964, 68);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // FrmGestionarEncInd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(988, 597);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flpEncuentros);
            this.Name = "FrmGestionarEncInd";
            this.Text = "FrmGestionarEncInd";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpEncuentros;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}