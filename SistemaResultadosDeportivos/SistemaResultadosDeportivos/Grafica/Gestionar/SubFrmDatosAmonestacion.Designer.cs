namespace SistemaResultadosDeportivos
{
    partial class SubFrmDatosAmonestacion
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
            this.flpJugadores = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblEquipo1 = new System.Windows.Forms.Label();
            this.cbxNombre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // flpJugadores
            // 
            this.flpJugadores.AutoScroll = true;
            this.flpJugadores.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpJugadores.Location = new System.Drawing.Point(12, 12);
            this.flpJugadores.Name = "flpJugadores";
            this.flpJugadores.Size = new System.Drawing.Size(884, 441);
            this.flpJugadores.TabIndex = 18;
            this.flpJugadores.WrapContents = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAceptar.Location = new System.Drawing.Point(592, 496);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(220, 40);
            this.btnAceptar.TabIndex = 30;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblEquipo1
            // 
            this.lblEquipo1.BackColor = System.Drawing.Color.Transparent;
            this.lblEquipo1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipo1.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblEquipo1.Location = new System.Drawing.Point(12, 461);
            this.lblEquipo1.Name = "lblEquipo1";
            this.lblEquipo1.Size = new System.Drawing.Size(751, 32);
            this.lblEquipo1.TabIndex = 31;
            this.lblEquipo1.Text = "Ingrese el tipo de la amonestación:";
            this.lblEquipo1.Click += new System.EventHandler(this.lblEquipo1_Click);
            // 
            // cbxNombre
            // 
            this.cbxNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNombre.FormattingEnabled = true;
            this.cbxNombre.Location = new System.Drawing.Point(592, 466);
            this.cbxNombre.Name = "cbxNombre";
            this.cbxNombre.Size = new System.Drawing.Size(174, 24);
            this.cbxNombre.TabIndex = 32;
            // 
            // SubFrmDatosAmonestacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(909, 548);
            this.Controls.Add(this.cbxNombre);
            this.Controls.Add(this.lblEquipo1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.flpJugadores);
            this.Name = "SubFrmDatosAmonestacion";
            this.Text = "SubFrmDatosAmonestacion";
            this.Load += new System.EventHandler(this.SubFrmDatosAmonestacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpJugadores;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblEquipo1;
        private System.Windows.Forms.ComboBox cbxNombre;
    }
}