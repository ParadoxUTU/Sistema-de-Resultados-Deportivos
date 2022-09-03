namespace SistemaResultadosDeportivos
{
    partial class FrmInicioEquipos
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpEquipos
            // 
            this.flpEquipos.AutoScroll = true;
            this.flpEquipos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEquipos.Location = new System.Drawing.Point(12, 39);
            this.flpEquipos.Name = "flpEquipos";
            this.flpEquipos.Size = new System.Drawing.Size(884, 441);
            this.flpEquipos.TabIndex = 18;
            this.flpEquipos.WrapContents = false;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrear.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnCrear.Location = new System.Drawing.Point(12, 498);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(203, 37);
            this.btnCrear.TabIndex = 17;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // FrmInicioEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(908, 546);
            this.Controls.Add(this.flpEquipos);
            this.Controls.Add(this.btnCrear);
            this.Name = "FrmInicioEquipos";
            this.Text = "FrmInicioEquipos";
            this.Load += new System.EventHandler(this.FrmInicioEquipos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpEquipos;
        private System.Windows.Forms.Button btnCrear;
    }
}