namespace SistemaResultadosDeportivos
{
    partial class SubFrmModificarPublicidad
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
            this.txtUrlSitio = new System.Windows.Forms.TextBox();
            this.txtUrlBanner = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUrlSitio
            // 
            this.txtUrlSitio.Location = new System.Drawing.Point(301, 183);
            this.txtUrlSitio.Name = "txtUrlSitio";
            this.txtUrlSitio.Size = new System.Drawing.Size(174, 20);
            this.txtUrlSitio.TabIndex = 30;
            // 
            // txtUrlBanner
            // 
            this.txtUrlBanner.Location = new System.Drawing.Point(301, 138);
            this.txtUrlBanner.Name = "txtUrlBanner";
            this.txtUrlBanner.Size = new System.Drawing.Size(174, 20);
            this.txtUrlBanner.TabIndex = 29;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(301, 92);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(174, 20);
            this.txtMarca.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Sitio Web:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ruta del Banner:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Marca:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(301, 291);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(163, 54);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Aceptar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // SubFrmModificarPublicidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUrlSitio);
            this.Controls.Add(this.txtUrlBanner);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregar);
            this.Name = "SubFrmModificarPublicidad";
            this.Text = "SubFrmModificarPublicidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrlSitio;
        private System.Windows.Forms.TextBox txtUrlBanner;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
    }
}