﻿namespace SistemaResultadosDeportivos
{
    partial class SubFrmEncuentrosTorneo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubFrmEncuentrosTorneo));
            this.flpEncuentros = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpEncuentros
            // 
            resources.ApplyResources(this.flpEncuentros, "flpEncuentros");
            this.flpEncuentros.Name = "flpEncuentros";
            // 
            // SubFrmEncuentrosTorneo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.Controls.Add(this.flpEncuentros);
            this.Name = "SubFrmEncuentrosTorneo";
            this.Load += new System.EventHandler(this.SubFrmEncuentrosTorneo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpEncuentros;
    }
}