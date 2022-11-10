namespace SistemaResultadosDeportivos
{
    partial class ABMEncuentros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMEncuentros));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxEtapa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timeHora = new System.Windows.Forms.DateTimePicker();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.cbxTorneos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbxDeportes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.flpEncuentros = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLupa = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.cbxEtapa);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.timeHora);
            this.panel1.Controls.Add(this.dateFecha);
            this.panel1.Controls.Add(this.cbxTorneos);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.cbxDeportes);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbxEstado);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // cbxEtapa
            // 
            resources.ApplyResources(this.cbxEtapa, "cbxEtapa");
            this.cbxEtapa.FormattingEnabled = true;
            this.cbxEtapa.Items.AddRange(new object[] {
            resources.GetString("cbxEtapa.Items"),
            resources.GetString("cbxEtapa.Items1"),
            resources.GetString("cbxEtapa.Items2"),
            resources.GetString("cbxEtapa.Items3"),
            resources.GetString("cbxEtapa.Items4"),
            resources.GetString("cbxEtapa.Items5")});
            this.cbxEtapa.Name = "cbxEtapa";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.Menu;
            this.label5.Name = "label5";
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
            // 
            // cbxTorneos
            // 
            resources.ApplyResources(this.cbxTorneos, "cbxTorneos");
            this.cbxTorneos.FormattingEnabled = true;
            this.cbxTorneos.Name = "cbxTorneos";
            this.cbxTorneos.SelectedIndexChanged += new System.EventHandler(this.cbxTorneos_SelectedIndexChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.Menu;
            this.label8.Name = "label8";
            // 
            // btnAgregar
            // 
            resources.ApplyResources(this.btnAgregar, "btnAgregar");
            this.btnAgregar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Name = "label1";
            // 
            // pnlBuscar
            // 
            resources.ApplyResources(this.pnlBuscar, "pnlBuscar");
            this.pnlBuscar.Controls.Add(this.btnBuscar);
            this.pnlBuscar.Controls.Add(this.txtBuscar);
            this.pnlBuscar.Name = "pnlBuscar";
            // 
            // btnBuscar
            // 
            resources.ApplyResources(this.btnBuscar, "btnBuscar");
            this.btnBuscar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            resources.ApplyResources(this.txtBuscar, "txtBuscar");
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscar_MouseClick);
            // 
            // flpEncuentros
            // 
            resources.ApplyResources(this.flpEncuentros, "flpEncuentros");
            this.flpEncuentros.Name = "flpEncuentros";
            // 
            // pnlLupa
            // 
            resources.ApplyResources(this.pnlLupa, "pnlLupa");
            this.pnlLupa.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.lupa;
            this.pnlLupa.Name = "pnlLupa";
            // 
            // ABMEncuentros
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.Controls.Add(this.pnlLupa);
            this.Controls.Add(this.flpEncuentros);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABMEncuentros";
            this.Load += new System.EventHandler(this.ABMEncuentros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.FlowLayoutPanel flpEncuentros;
        private System.Windows.Forms.Panel pnlLupa;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbxDeportes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxTorneos;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.DateTimePicker timeHora;
        private System.Windows.Forms.ComboBox cbxEtapa;
        private System.Windows.Forms.Label label5;
    }
}