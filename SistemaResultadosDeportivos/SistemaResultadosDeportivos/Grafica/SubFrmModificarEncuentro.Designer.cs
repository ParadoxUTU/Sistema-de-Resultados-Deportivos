namespace SistemaResultadosDeportivos
{
    partial class SubFrmModificarEncuentro
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
            this.timeHora = new System.Windows.Forms.DateTimePicker();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.cbxTorneos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numMinActual = new System.Windows.Forms.NumericUpDown();
            this.cbxDeportes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.flpParticipantes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGestionarEncuentro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinActual)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.timeHora);
            this.panel1.Controls.Add(this.dateFecha);
            this.panel1.Controls.Add(this.cbxTorneos);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.numMinActual);
            this.panel1.Controls.Add(this.cbxDeportes);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbxEstado);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 566);
            this.panel1.TabIndex = 1;
            // 
            // timeHora
            // 
            this.timeHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeHora.Location = new System.Drawing.Point(22, 365);
            this.timeHora.Name = "timeHora";
            this.timeHora.Size = new System.Drawing.Size(200, 20);
            this.timeHora.TabIndex = 11;
            // 
            // dateFecha
            // 
            this.dateFecha.Location = new System.Drawing.Point(22, 141);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(200, 20);
            this.dateFecha.TabIndex = 10;
            this.dateFecha.ValueChanged += new System.EventHandler(this.dateFecha_ValueChanged);
            // 
            // cbxTorneos
            // 
            this.cbxTorneos.Enabled = false;
            this.cbxTorneos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTorneos.FormattingEnabled = true;
            this.cbxTorneos.Location = new System.Drawing.Point(22, 525);
            this.cbxTorneos.Name = "cbxTorneos";
            this.cbxTorneos.Size = new System.Drawing.Size(203, 24);
            this.cbxTorneos.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Menu;
            this.label8.Location = new System.Drawing.Point(29, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Torneo:";
            // 
            // numMinActual
            // 
            this.numMinActual.Location = new System.Drawing.Point(22, 430);
            this.numMinActual.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numMinActual.Name = "numMinActual";
            this.numMinActual.Size = new System.Drawing.Size(36, 20);
            this.numMinActual.TabIndex = 7;
            // 
            // cbxDeportes
            // 
            this.cbxDeportes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDeportes.FormattingEnabled = true;
            this.cbxDeportes.Location = new System.Drawing.Point(22, 305);
            this.cbxDeportes.Name = "cbxDeportes";
            this.cbxDeportes.Size = new System.Drawing.Size(203, 24);
            this.cbxDeportes.TabIndex = 0;
            this.cbxDeportes.SelectedIndexChanged += new System.EventHandler(this.cbxDeportes_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Menu;
            this.label7.Location = new System.Drawing.Point(25, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Deporte:";
            // 
            // cbxEstado
            // 
            this.cbxEstado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Iniciado",
            "Pausado",
            "Finalizado"});
            this.cbxEstado.Location = new System.Drawing.Point(22, 233);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(203, 24);
            this.cbxEstado.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Menu;
            this.label6.Location = new System.Drawing.Point(25, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Estado del encuentro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Menu;
            this.label5.Location = new System.Drawing.Point(28, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Minuto actual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(28, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(19, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(22, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(203, 22);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Visible = false;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            this.label2.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnGuardar.Location = new System.Drawing.Point(21, 614);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(248, 37);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // flpParticipantes
            // 
            this.flpParticipantes.AutoScroll = true;
            this.flpParticipantes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpParticipantes.Location = new System.Drawing.Point(290, 12);
            this.flpParticipantes.Name = "flpParticipantes";
            this.flpParticipantes.Size = new System.Drawing.Size(610, 566);
            this.flpParticipantes.TabIndex = 17;
            this.flpParticipantes.WrapContents = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnEliminar.Location = new System.Drawing.Point(652, 614);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(248, 37);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGestionarEncuentro
            // 
            this.btnGestionarEncuentro.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGestionarEncuentro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGestionarEncuentro.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarEncuentro.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnGestionarEncuentro.Location = new System.Drawing.Point(341, 614);
            this.btnGestionarEncuentro.Name = "btnGestionarEncuentro";
            this.btnGestionarEncuentro.Size = new System.Drawing.Size(248, 37);
            this.btnGestionarEncuentro.TabIndex = 19;
            this.btnGestionarEncuentro.Text = "Gestionar Encuentro";
            this.btnGestionarEncuentro.UseVisualStyleBackColor = false;
            this.btnGestionarEncuentro.Click += new System.EventHandler(this.btnGestionarEncuentro_Click);
            // 
            // SubFrmModificarEncuentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(916, 663);
            this.Controls.Add(this.btnGestionarEncuentro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.flpParticipantes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardar);
            this.Name = "SubFrmModificarEncuentro";
            this.Text = " ";
            this.Load += new System.EventHandler(this.SubFrmModificarEncuentro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinActual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker timeHora;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.ComboBox cbxTorneos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numMinActual;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbxDeportes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.FlowLayoutPanel flpParticipantes;
        private System.Windows.Forms.Button btnGestionarEncuentro;
    }
}