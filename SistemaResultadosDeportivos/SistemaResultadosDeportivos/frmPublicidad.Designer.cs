namespace SistemaResultadosDeportivos
{
    partial class frmPublicidad
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lviewPublicidad = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.marca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urlbanner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urlsitio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtUrlSitio
            // 
            this.txtUrlSitio.Location = new System.Drawing.Point(106, 232);
            this.txtUrlSitio.Name = "txtUrlSitio";
            this.txtUrlSitio.Size = new System.Drawing.Size(174, 20);
            this.txtUrlSitio.TabIndex = 23;
            // 
            // txtUrlBanner
            // 
            this.txtUrlBanner.Location = new System.Drawing.Point(106, 187);
            this.txtUrlBanner.Name = "txtUrlBanner";
            this.txtUrlBanner.Size = new System.Drawing.Size(174, 20);
            this.txtUrlBanner.TabIndex = 22;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(106, 141);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(174, 20);
            this.txtMarca.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Sitio Web:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ruta del Banner:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Marca:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(862, 340);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(163, 54);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(375, 340);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(163, 54);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(106, 340);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(163, 54);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lviewPublicidad
            // 
            this.lviewPublicidad.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.marca,
            this.urlbanner,
            this.urlsitio});
            this.lviewPublicidad.HideSelection = false;
            this.lviewPublicidad.Location = new System.Drawing.Point(375, 37);
            this.lviewPublicidad.Name = "lviewPublicidad";
            this.lviewPublicidad.Size = new System.Drawing.Size(650, 297);
            this.lviewPublicidad.TabIndex = 24;
            this.lviewPublicidad.UseCompatibleStateImageBehavior = false;
            this.lviewPublicidad.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Id";
            // 
            // marca
            // 
            this.marca.Text = "Marca";
            this.marca.Width = 100;
            // 
            // urlbanner
            // 
            this.urlbanner.Text = "Banner";
            this.urlbanner.Width = 250;
            // 
            // urlsitio
            // 
            this.urlsitio.Text = "Sitio Web";
            this.urlsitio.Width = 250;
            // 
            // Publicidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 425);
            this.Controls.Add(this.lviewPublicidad);
            this.Controls.Add(this.txtUrlSitio);
            this.Controls.Add(this.txtUrlBanner);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Publicidad";
            this.Text = "Publicidad";
            this.Load += new System.EventHandler(this.Publicidad_Load);
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
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lviewPublicidad;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader marca;
        private System.Windows.Forms.ColumnHeader urlbanner;
        private System.Windows.Forms.ColumnHeader urlsitio;
    }
}