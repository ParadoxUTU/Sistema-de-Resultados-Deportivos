namespace SistemaResultadosDeportivos
{
    partial class FrmInicioAppLogin
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
            this.flpDeportes = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpDeportes
            // 
            this.flpDeportes.AutoScroll = true;
            this.flpDeportes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDeportes.Location = new System.Drawing.Point(20, 101);
            this.flpDeportes.Name = "flpDeportes";
            this.flpDeportes.Size = new System.Drawing.Size(964, 466);
            this.flpDeportes.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(323, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 32);
            this.label1.TabIndex = 35;
            this.label1.Text = "¿Qué deporte le interesa?";
            // 
            // FrmInicioAppLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(1004, 597);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpDeportes);
            this.Name = "FrmInicioAppLogin";
            this.Text = "FrmInicioAppLogin";
            this.Load += new System.EventHandler(this.FrmInicioAppLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpDeportes;
        private System.Windows.Forms.Label label1;
    }
}