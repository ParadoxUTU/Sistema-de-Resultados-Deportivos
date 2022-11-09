namespace SistemaResultadosDeportivos
{
    partial class SubFrmDatosCambio
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
            this.flpAlineacion = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPlantel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblEquipo1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpAlineacion
            // 
            this.flpAlineacion.AutoScroll = true;
            this.flpAlineacion.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAlineacion.Location = new System.Drawing.Point(12, 67);
            this.flpAlineacion.Name = "flpAlineacion";
            this.flpAlineacion.Size = new System.Drawing.Size(453, 445);
            this.flpAlineacion.TabIndex = 18;
            this.flpAlineacion.WrapContents = false;
            // 
            // flpPlantel
            // 
            this.flpPlantel.AutoScroll = true;
            this.flpPlantel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPlantel.Location = new System.Drawing.Point(483, 67);
            this.flpPlantel.Name = "flpPlantel";
            this.flpPlantel.Size = new System.Drawing.Size(453, 445);
            this.flpPlantel.TabIndex = 19;
            this.flpPlantel.WrapContents = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAceptar.Location = new System.Drawing.Point(382, 537);
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
            this.lblEquipo1.Location = new System.Drawing.Point(12, 19);
            this.lblEquipo1.Name = "lblEquipo1";
            this.lblEquipo1.Size = new System.Drawing.Size(453, 32);
            this.lblEquipo1.TabIndex = 31;
            this.lblEquipo1.Text = "Jugador Saliente:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(483, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 32);
            this.label1.TabIndex = 32;
            this.label1.Text = "Jugador Entrante:";
            // 
            // SubFrmDatosCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(948, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEquipo1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.flpPlantel);
            this.Controls.Add(this.flpAlineacion);
            this.Name = "SubFrmDatosCambio";
            this.Text = "SubFrmDatosCambio";
            this.Load += new System.EventHandler(this.SubFrmDatosCambio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpAlineacion;
        private System.Windows.Forms.FlowLayoutPanel flpPlantel;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblEquipo1;
        private System.Windows.Forms.Label label1;
    }
}