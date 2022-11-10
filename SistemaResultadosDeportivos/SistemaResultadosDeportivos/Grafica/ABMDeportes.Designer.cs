namespace SistemaResultadosDeportivos
{
    partial class ABMDeportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMDeportes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.numParticipantes = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxPuntuacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxModalidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.flpDeportes = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLupa = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numParticipantes)).BeginInit();
            this.pnlBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.numParticipantes);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbxPuntuacion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbxModalidad);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // numParticipantes
            // 
            resources.ApplyResources(this.numParticipantes, "numParticipantes");
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
            this.numParticipantes.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
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
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.Menu;
            this.label5.Name = "label5";
            // 
            // cbxPuntuacion
            // 
            resources.ApplyResources(this.cbxPuntuacion, "cbxPuntuacion");
            this.cbxPuntuacion.FormattingEnabled = true;
            this.cbxPuntuacion.Items.AddRange(new object[] {
            resources.GetString("cbxPuntuacion.Items"),
            resources.GetString("cbxPuntuacion.Items1")});
            this.cbxPuntuacion.Name = "cbxPuntuacion";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Name = "label4";
            // 
            // cbxModalidad
            // 
            resources.ApplyResources(this.cbxModalidad, "cbxModalidad");
            this.cbxModalidad.FormattingEnabled = true;
            this.cbxModalidad.Items.AddRange(new object[] {
            resources.GetString("cbxModalidad.Items"),
            resources.GetString("cbxModalidad.Items1")});
            this.cbxModalidad.Name = "cbxModalidad";
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
            // flpDeportes
            // 
            resources.ApplyResources(this.flpDeportes, "flpDeportes");
            this.flpDeportes.Name = "flpDeportes";
            // 
            // pnlLupa
            // 
            resources.ApplyResources(this.pnlLupa, "pnlLupa");
            this.pnlLupa.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.lupa;
            this.pnlLupa.Name = "pnlLupa";
            // 
            // ABMDeportes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.Controls.Add(this.pnlLupa);
            this.Controls.Add(this.flpDeportes);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABMDeportes";
            this.Load += new System.EventHandler(this.ABMDeportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numParticipantes)).EndInit();
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.FlowLayoutPanel flpDeportes;
        private System.Windows.Forms.Panel pnlLupa;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbxModalidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxPuntuacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numParticipantes;
    }
}