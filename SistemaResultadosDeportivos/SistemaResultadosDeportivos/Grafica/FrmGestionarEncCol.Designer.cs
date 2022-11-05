namespace SistemaResultadosDeportivos
{
    partial class FrmGestionarEncCol
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
            this.components = new System.ComponentModel.Container();
            this.flpIncidencias = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregarPuntos1 = new System.Windows.Forms.Button();
            this.lblEquipo1 = new System.Windows.Forms.Label();
            this.lblEquipo2 = new System.Windows.Forms.Label();
            this.lblPuntaje1 = new System.Windows.Forms.Label();
            this.lblPuntaje2 = new System.Windows.Forms.Label();
            this.btnAgregarPuntos2 = new System.Windows.Forms.Button();
            this.lblMinuto = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnReanudar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpIncidencias
            // 
            this.flpIncidencias.AutoScroll = true;
            this.flpIncidencias.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpIncidencias.Location = new System.Drawing.Point(12, 93);
            this.flpIncidencias.Name = "flpIncidencias";
            this.flpIncidencias.Size = new System.Drawing.Size(964, 408);
            this.flpIncidencias.TabIndex = 5;
            // 
            // btnAgregarPuntos1
            // 
            this.btnAgregarPuntos1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAgregarPuntos1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarPuntos1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPuntos1.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAgregarPuntos1.Location = new System.Drawing.Point(12, 527);
            this.btnAgregarPuntos1.Name = "btnAgregarPuntos1";
            this.btnAgregarPuntos1.Size = new System.Drawing.Size(220, 40);
            this.btnAgregarPuntos1.TabIndex = 22;
            this.btnAgregarPuntos1.Text = "Agregar Puntos";
            this.btnAgregarPuntos1.UseVisualStyleBackColor = false;
            this.btnAgregarPuntos1.Click += new System.EventHandler(this.btnAgregarPuntos1_Click);
            // 
            // lblEquipo1
            // 
            this.lblEquipo1.BackColor = System.Drawing.Color.Transparent;
            this.lblEquipo1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipo1.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblEquipo1.Location = new System.Drawing.Point(12, 31);
            this.lblEquipo1.Name = "lblEquipo1";
            this.lblEquipo1.Size = new System.Drawing.Size(131, 32);
            this.lblEquipo1.TabIndex = 23;
            this.lblEquipo1.Text = "Equipo 1";
            // 
            // lblEquipo2
            // 
            this.lblEquipo2.BackColor = System.Drawing.Color.Transparent;
            this.lblEquipo2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipo2.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblEquipo2.Location = new System.Drawing.Point(845, 31);
            this.lblEquipo2.Name = "lblEquipo2";
            this.lblEquipo2.Size = new System.Drawing.Size(131, 32);
            this.lblEquipo2.TabIndex = 24;
            this.lblEquipo2.Text = "Equipo 2";
            this.lblEquipo2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPuntaje1
            // 
            this.lblPuntaje1.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntaje1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje1.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblPuntaje1.Location = new System.Drawing.Point(208, 31);
            this.lblPuntaje1.Name = "lblPuntaje1";
            this.lblPuntaje1.Size = new System.Drawing.Size(250, 32);
            this.lblPuntaje1.TabIndex = 25;
            this.lblPuntaje1.Text = "0";
            // 
            // lblPuntaje2
            // 
            this.lblPuntaje2.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntaje2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje2.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblPuntaje2.Location = new System.Drawing.Point(510, 31);
            this.lblPuntaje2.Name = "lblPuntaje2";
            this.lblPuntaje2.Size = new System.Drawing.Size(250, 32);
            this.lblPuntaje2.TabIndex = 26;
            this.lblPuntaje2.Text = "0";
            this.lblPuntaje2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblPuntaje2.Click += new System.EventHandler(this.lblPuntaje2_Click);
            // 
            // btnAgregarPuntos2
            // 
            this.btnAgregarPuntos2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAgregarPuntos2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarPuntos2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPuntos2.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAgregarPuntos2.Location = new System.Drawing.Point(756, 527);
            this.btnAgregarPuntos2.Name = "btnAgregarPuntos2";
            this.btnAgregarPuntos2.Size = new System.Drawing.Size(220, 40);
            this.btnAgregarPuntos2.TabIndex = 28;
            this.btnAgregarPuntos2.Text = "Agregar Puntos";
            this.btnAgregarPuntos2.UseVisualStyleBackColor = false;
            this.btnAgregarPuntos2.Click += new System.EventHandler(this.btnAgregarPuntos2_Click);
            // 
            // lblMinuto
            // 
            this.lblMinuto.AutoSize = true;
            this.lblMinuto.BackColor = System.Drawing.Color.Transparent;
            this.lblMinuto.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinuto.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblMinuto.Location = new System.Drawing.Point(464, 31);
            this.lblMinuto.Name = "lblMinuto";
            this.lblMinuto.Size = new System.Drawing.Size(29, 32);
            this.lblMinuto.TabIndex = 27;
            this.lblMinuto.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPausar
            // 
            this.btnPausar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnPausar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPausar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPausar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnPausar.Location = new System.Drawing.Point(391, 527);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(87, 40);
            this.btnPausar.TabIndex = 29;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = false;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnReanudar
            // 
            this.btnReanudar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnReanudar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReanudar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReanudar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnReanudar.Location = new System.Drawing.Point(509, 527);
            this.btnReanudar.Name = "btnReanudar";
            this.btnReanudar.Size = new System.Drawing.Size(87, 40);
            this.btnReanudar.TabIndex = 30;
            this.btnReanudar.Text = "Reanudar";
            this.btnReanudar.UseVisualStyleBackColor = false;
            this.btnReanudar.Click += new System.EventHandler(this.btnReanudar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinalizar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnFinalizar.Location = new System.Drawing.Point(626, 527);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(87, 40);
            this.btnFinalizar.TabIndex = 31;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnIniciar.Location = new System.Drawing.Point(275, 527);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(87, 40);
            this.btnIniciar.TabIndex = 32;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // FrmGestionarEncCol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(991, 600);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnReanudar);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.btnAgregarPuntos2);
            this.Controls.Add(this.lblMinuto);
            this.Controls.Add(this.lblPuntaje2);
            this.Controls.Add(this.lblPuntaje1);
            this.Controls.Add(this.lblEquipo2);
            this.Controls.Add(this.lblEquipo1);
            this.Controls.Add(this.btnAgregarPuntos1);
            this.Controls.Add(this.flpIncidencias);
            this.Name = "FrmGestionarEncCol";
            this.Text = "GestionarEncCol";
            this.Load += new System.EventHandler(this.FrmGestionarEncCol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpIncidencias;
        private System.Windows.Forms.Button btnAgregarPuntos1;
        private System.Windows.Forms.Label lblEquipo1;
        private System.Windows.Forms.Label lblEquipo2;
        private System.Windows.Forms.Button btnAgregarPuntos2;
        public System.Windows.Forms.Label lblPuntaje1;
        public System.Windows.Forms.Label lblPuntaje2;
        public System.Windows.Forms.Label lblMinuto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnReanudar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnIniciar;
    }
}