namespace SistemaResultadosDeportivos
{
    partial class SubFrmDatosSetJug
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.numPuntuacion = new System.Windows.Forms.NumericUpDown();
            this.lblEquipo1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPuntuacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAceptar.Location = new System.Drawing.Point(92, 124);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(220, 40);
            this.btnAceptar.TabIndex = 29;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // numPuntuacion
            // 
            this.numPuntuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPuntuacion.Location = new System.Drawing.Point(113, 67);
            this.numPuntuacion.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numPuntuacion.Name = "numPuntuacion";
            this.numPuntuacion.Size = new System.Drawing.Size(180, 38);
            this.numPuntuacion.TabIndex = 28;
            // 
            // lblEquipo1
            // 
            this.lblEquipo1.BackColor = System.Drawing.Color.Transparent;
            this.lblEquipo1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipo1.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblEquipo1.Location = new System.Drawing.Point(12, 9);
            this.lblEquipo1.Name = "lblEquipo1";
            this.lblEquipo1.Size = new System.Drawing.Size(485, 32);
            this.lblEquipo1.TabIndex = 27;
            this.lblEquipo1.Text = "Ingrese la puntuación del set:";
            // 
            // SubFrmDatosSetJug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(433, 176);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.numPuntuacion);
            this.Controls.Add(this.lblEquipo1);
            this.Name = "SubFrmDatosSetJug";
            this.Text = "SubFrmDatosSetJug";
            ((System.ComponentModel.ISupportInitialize)(this.numPuntuacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.NumericUpDown numPuntuacion;
        private System.Windows.Forms.Label lblEquipo1;
    }
}