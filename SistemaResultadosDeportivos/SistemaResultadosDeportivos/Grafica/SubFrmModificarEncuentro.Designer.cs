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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubFrmModificarEncuentro));
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
            resources.ApplyResources(this.panel1, "panel1");
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
            this.panel1.Name = "panel1";
            // 
            // timeHora
            // 
            resources.ApplyResources(this.timeHora, "timeHora");
            this.timeHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeHora.Name = "timeHora";
            // 
            // dateFecha
            // 
            resources.ApplyResources(this.dateFecha, "dateFecha");
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.ValueChanged += new System.EventHandler(this.dateFecha_ValueChanged);
            // 
            // cbxTorneos
            // 
            resources.ApplyResources(this.cbxTorneos, "cbxTorneos");
            this.cbxTorneos.FormattingEnabled = true;
            this.cbxTorneos.Name = "cbxTorneos";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.Menu;
            this.label8.Name = "label8";
            // 
            // numMinActual
            // 
            resources.ApplyResources(this.numMinActual, "numMinActual");
            this.numMinActual.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numMinActual.Name = "numMinActual";
            // 
            // cbxDeportes
            // 
            resources.ApplyResources(this.cbxDeportes, "cbxDeportes");
            this.cbxDeportes.FormattingEnabled = true;
            this.cbxDeportes.Name = "cbxDeportes";
            this.cbxDeportes.SelectedIndexChanged += new System.EventHandler(this.cbxDeportes_SelectedIndexChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.Menu;
            this.label7.Name = "label7";
            // 
            // cbxEstado
            // 
            resources.ApplyResources(this.cbxEstado, "cbxEstado");
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            resources.GetString("cbxEstado.Items"),
            resources.GetString("cbxEstado.Items1"),
            resources.GetString("cbxEstado.Items2")});
            this.cbxEstado.Name = "cbxEstado";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.Menu;
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.Menu;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Name = "label3";
            // 
            // txtNombre
            // 
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Name = "label2";
            // 
            // btnGuardar
            // 
            resources.ApplyResources(this.btnGuardar, "btnGuardar");
            this.btnGuardar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // flpParticipantes
            // 
            resources.ApplyResources(this.flpParticipantes, "flpParticipantes");
            this.flpParticipantes.Name = "flpParticipantes";
            // 
            // btnEliminar
            // 
            resources.ApplyResources(this.btnEliminar, "btnEliminar");
            this.btnEliminar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGestionarEncuentro
            // 
            resources.ApplyResources(this.btnGestionarEncuentro, "btnGestionarEncuentro");
            this.btnGestionarEncuentro.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGestionarEncuentro.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnGestionarEncuentro.Name = "btnGestionarEncuentro";
            this.btnGestionarEncuentro.UseVisualStyleBackColor = false;
            this.btnGestionarEncuentro.Click += new System.EventHandler(this.btnGestionarEncuentro_Click);
            // 
            // SubFrmModificarEncuentro
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.Controls.Add(this.btnGestionarEncuentro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.flpParticipantes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardar);
            this.Name = "SubFrmModificarEncuentro";
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