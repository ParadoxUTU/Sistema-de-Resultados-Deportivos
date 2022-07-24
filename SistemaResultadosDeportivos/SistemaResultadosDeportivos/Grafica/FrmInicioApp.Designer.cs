
namespace SistemaResultadosDeportivos
{
    partial class FrmInicioApp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.banner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // banner
            // 
            this.banner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.banner.Location = new System.Drawing.Point(12, 134);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(776, 139);
            this.banner.TabIndex = 0;
            this.banner.Click += new System.EventHandler(this.banner_Click_1);
            // 
            // FrmInicioApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.banner);
            this.Name = "FrmInicioApp";
            this.Text = "App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmInicioApp_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label banner;
    }
}

