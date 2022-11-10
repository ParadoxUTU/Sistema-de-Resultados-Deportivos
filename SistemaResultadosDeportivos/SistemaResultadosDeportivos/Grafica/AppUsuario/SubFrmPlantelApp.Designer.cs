namespace SistemaResultadosDeportivos
{
    partial class SubFrmPlantelApp
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
            this.flpParticipantes = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpParticipantes
            // 
            this.flpParticipantes.AutoScroll = true;
            this.flpParticipantes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpParticipantes.Location = new System.Drawing.Point(27, 33);
            this.flpParticipantes.Name = "flpParticipantes";
            this.flpParticipantes.Size = new System.Drawing.Size(839, 482);
            this.flpParticipantes.TabIndex = 43;
            // 
            // SubFrmPlantelApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaResultadosDeportivos.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(893, 549);
            this.Controls.Add(this.flpParticipantes);
            this.Name = "SubFrmPlantelApp";
            this.Text = "SubFrmPlantelApp";
            this.Load += new System.EventHandler(this.SubFrmPlantelApp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpParticipantes;
    }
}