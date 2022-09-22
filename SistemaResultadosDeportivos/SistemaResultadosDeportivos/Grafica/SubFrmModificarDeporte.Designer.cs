namespace SistemaResultadosDeportivos
{
    partial class SubFrmModificarDeporte
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.numAlineacion = new System.Windows.Forms.NumericUpDown();
            this.numParticipantes = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxPuntuacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxModalidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pnlPerfil = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlineacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParticipantes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numAlineacion);
            this.panel1.Controls.Add(this.numParticipantes);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbxPuntuacion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbxModalidad);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.pnlPerfil);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Location = new System.Drawing.Point(95, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 496);
            this.panel1.TabIndex = 24;
            // 
            // numAlineacion
            // 
            this.numAlineacion.Location = new System.Drawing.Point(399, 318);
            this.numAlineacion.Name = "numAlineacion";
            this.numAlineacion.Size = new System.Drawing.Size(180, 20);
            this.numAlineacion.TabIndex = 36;
            // 
            // numParticipantes
            // 
            this.numParticipantes.Location = new System.Drawing.Point(399, 265);
            this.numParticipantes.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numParticipantes.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numParticipantes.Name = "numParticipantes";
            this.numParticipantes.Size = new System.Drawing.Size(180, 20);
            this.numParticipantes.TabIndex = 35;
            this.numParticipantes.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Menu;
            this.label6.Location = new System.Drawing.Point(396, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tamaño de la alineación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Menu;
            this.label5.Location = new System.Drawing.Point(396, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Cantidad de participantes:";
            // 
            // cbxPuntuacion
            // 
            this.cbxPuntuacion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPuntuacion.FormattingEnabled = true;
            this.cbxPuntuacion.Items.AddRange(new object[] {
            "Anotaciones",
            "Sets"});
            this.cbxPuntuacion.Location = new System.Drawing.Point(399, 183);
            this.cbxPuntuacion.Name = "cbxPuntuacion";
            this.cbxPuntuacion.Size = new System.Drawing.Size(180, 24);
            this.cbxPuntuacion.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(396, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Puntuación:";
            // 
            // cbxModalidad
            // 
            this.cbxModalidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxModalidad.FormattingEnabled = true;
            this.cbxModalidad.Items.AddRange(new object[] {
            "Individual",
            "Por equipos"});
            this.cbxModalidad.Location = new System.Drawing.Point(399, 119);
            this.cbxModalidad.Name = "cbxModalidad";
            this.cbxModalidad.Size = new System.Drawing.Size(180, 24);
            this.cbxModalidad.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(396, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Modalidad:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(399, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 22);
            this.txtNombre.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(396, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nombre:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnEliminar.Location = new System.Drawing.Point(44, 430);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(220, 40);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar Deporte";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnModificar.Location = new System.Drawing.Point(399, 357);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(220, 40);
            this.btnModificar.TabIndex = 25;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // pnlPerfil
            // 
            this.pnlPerfil.Location = new System.Drawing.Point(44, 31);
            this.pnlPerfil.Name = "pnlPerfil";
            this.pnlPerfil.Size = new System.Drawing.Size(220, 220);
            this.pnlPerfil.TabIndex = 24;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAceptar.Location = new System.Drawing.Point(44, 357);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(220, 40);
            this.btnAceptar.TabIndex = 21;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // SubFrmModificarDeporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 547);
            this.Controls.Add(this.panel1);
            this.Name = "SubFrmModificarDeporte";
            this.Text = "SubFrmModificarDeporte";
            this.Load += new System.EventHandler(this.SubFrmModificarDeporte_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlineacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParticipantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel pnlPerfil;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.NumericUpDown numAlineacion;
        private System.Windows.Forms.NumericUpDown numParticipantes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxPuntuacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxModalidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
    }
}