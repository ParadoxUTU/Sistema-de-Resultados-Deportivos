﻿namespace SistemaResultadosDeportivos
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
            this.flpEncuentros = new System.Windows.Forms.FlowLayoutPanel();
            this.banner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            this.SuspendLayout();
            // 
            // flpEncuentros
            // 
            this.flpEncuentros.AutoScroll = true;
            this.flpEncuentros.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEncuentros.Location = new System.Drawing.Point(29, 26);
            this.flpEncuentros.Name = "flpEncuentros";
            this.flpEncuentros.Size = new System.Drawing.Size(884, 441);
            this.flpEncuentros.TabIndex = 21;
            this.flpEncuentros.WrapContents = false;
            // 
            // banner
            // 
            this.banner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.banner.Location = new System.Drawing.Point(80, 502);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(776, 139);
            this.banner.TabIndex = 20;
            this.banner.TabStop = false;
            // 
            // FrmEncuentrosTorneoApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(946, 660);
            this.Controls.Add(this.flpEncuentros);
            this.Controls.Add(this.banner);
            this.Name = "FrmEncuentrosTorneoApp";
            this.Text = "FrmEncuentrosTorneoApp";
            this.Load += new System.EventHandler(this.FrmEncuentrosTorneoApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpEncuentros;
        private System.Windows.Forms.PictureBox banner;
    }
}