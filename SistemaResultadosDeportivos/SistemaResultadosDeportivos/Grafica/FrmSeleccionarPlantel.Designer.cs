namespace SistemaResultadosDeportivos
{
    partial class FrmSeleccionarPlantel
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
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.pnlLupa = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.flpJugadores = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.Controls.Add(this.pnlLupa);
            this.pnlBuscar.Controls.Add(this.btnBuscar);
            this.pnlBuscar.Controls.Add(this.txtBuscar);
            this.pnlBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBuscar.Location = new System.Drawing.Point(12, 12);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(884, 39);
            this.pnlBuscar.TabIndex = 20;
            // 
            // pnlLupa
            // 
            this.pnlLupa.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLupa.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.lupa;
            this.pnlLupa.Location = new System.Drawing.Point(0, 0);
            this.pnlLupa.Name = "pnlLupa";
            this.pnlLupa.Size = new System.Drawing.Size(54, 39);
            this.pnlLupa.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnBuscar.Location = new System.Drawing.Point(644, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(74, 26);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(70, 10);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBuscar.Size = new System.Drawing.Size(561, 22);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.Text = "Escriba el nombre del participante que desea seleccionar";
            // 
            // flpJugadores
            // 
            this.flpJugadores.AutoScroll = true;
            this.flpJugadores.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpJugadores.Location = new System.Drawing.Point(12, 72);
            this.flpJugadores.Name = "flpJugadores";
            this.flpJugadores.Size = new System.Drawing.Size(884, 441);
            this.flpJugadores.TabIndex = 21;
            this.flpJugadores.WrapContents = false;
            // 
            // FrmSeleccionarPlantel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(908, 549);
            this.Controls.Add(this.flpJugadores);
            this.Controls.Add(this.pnlBuscar);
            this.Name = "FrmSeleccionarPlantel";
            this.Text = "FrmSeleccionarPlantel";
            this.Load += new System.EventHandler(this.FrmSeleccionarPlantel_Load);
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Panel pnlLupa;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.FlowLayoutPanel flpJugadores;
    }
}