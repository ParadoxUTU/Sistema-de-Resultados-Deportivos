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
            this.btnCrear = new System.Windows.Forms.Button();
            this.flpEncuentros = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrear.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnCrear.Location = new System.Drawing.Point(12, 496);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(203, 37);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // flpEncuentros
            // 
            this.flpEncuentros.AutoScroll = true;
            this.flpEncuentros.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEncuentros.Location = new System.Drawing.Point(12, 37);
            this.flpEncuentros.Name = "flpEncuentros";
            this.flpEncuentros.Size = new System.Drawing.Size(884, 441);
            this.flpEncuentros.TabIndex = 16;
            this.flpEncuentros.WrapContents = false;
            // 
            // FrmInicioEncuentros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(908, 545);
            this.Controls.Add(this.flpEncuentros);
            this.Controls.Add(this.btnCrear);
            this.Name = "FrmInicioEncuentros";
            this.Text = "FrmInicioEncuentros";
            this.Load += new System.EventHandler(this.FrmInicioEncuentros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.FlowLayoutPanel flpEncuentros;
    }
}