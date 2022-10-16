namespace SistemaResultadosDeportivos
{
    partial class SubFrmModificarEquipo
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
            this.btnAgregarJugador = new System.Windows.Forms.Button();
            this.cbxDeportes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pnlPerfil = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAgregarJugador);
            this.panel1.Controls.Add(this.cbxDeportes);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPais);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.pnlPerfil);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Location = new System.Drawing.Point(85, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 496);
            this.panel1.TabIndex = 24;
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAgregarJugador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarJugador.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarJugador.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAgregarJugador.Location = new System.Drawing.Point(399, 430);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Size = new System.Drawing.Size(220, 40);
            this.btnAgregarJugador.TabIndex = 33;
            this.btnAgregarJugador.Text = "Agregar jugador";
            this.btnAgregarJugador.UseVisualStyleBackColor = false;
            this.btnAgregarJugador.Click += new System.EventHandler(this.btnAgregarJugador_Click);
            // 
            // cbxDeportes
            // 
            this.cbxDeportes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDeportes.FormattingEnabled = true;
            this.cbxDeportes.Location = new System.Drawing.Point(399, 221);
            this.cbxDeportes.Name = "cbxDeportes";
            this.cbxDeportes.Size = new System.Drawing.Size(174, 24);
            this.cbxDeportes.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(396, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Deporte:";
            // 
            // txtPais
            // 
            this.txtPais.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.Location = new System.Drawing.Point(399, 140);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(174, 22);
            this.txtPais.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(396, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "País:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(399, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 22);
            this.txtNombre.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(396, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 32;
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
            this.btnEliminar.Text = "Eliminar equipo";
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
            // SubFrmModificarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(874, 558);
            this.Controls.Add(this.panel1);
            this.Name = "SubFrmModificarEquipo";
            this.Text = "SubFrmModificarEquipo";
            this.Load += new System.EventHandler(this.SubFrmModificarEquipo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel pnlPerfil;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cbxDeportes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarJugador;
    }
}