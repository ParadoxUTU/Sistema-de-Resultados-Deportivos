namespace SistemaResultadosDeportivos
{
    partial class FrmBackoffice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackoffice));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.encuentrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torneosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encuentrosToolStripMenuItem,
            this.equiposToolStripMenuItem,
            this.jugadoresToolStripMenuItem,
            this.torneosToolStripMenuItem,
            this.deportesToolStripMenuItem,
            this.publicidadToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // encuentrosToolStripMenuItem
            // 
            resources.ApplyResources(this.encuentrosToolStripMenuItem, "encuentrosToolStripMenuItem");
            this.encuentrosToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.encuentrosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Menu;
            this.encuentrosToolStripMenuItem.Name = "encuentrosToolStripMenuItem";
            this.encuentrosToolStripMenuItem.Click += new System.EventHandler(this.encuentrosToolStripMenuItem_Click);
            // 
            // equiposToolStripMenuItem
            // 
            resources.ApplyResources(this.equiposToolStripMenuItem, "equiposToolStripMenuItem");
            this.equiposToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.equiposToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Menu;
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Click += new System.EventHandler(this.equiposToolStripMenuItem_Click);
            // 
            // jugadoresToolStripMenuItem
            // 
            resources.ApplyResources(this.jugadoresToolStripMenuItem, "jugadoresToolStripMenuItem");
            this.jugadoresToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.jugadoresToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Menu;
            this.jugadoresToolStripMenuItem.Name = "jugadoresToolStripMenuItem";
            this.jugadoresToolStripMenuItem.Click += new System.EventHandler(this.jugadoresToolStripMenuItem_Click);
            // 
            // torneosToolStripMenuItem
            // 
            resources.ApplyResources(this.torneosToolStripMenuItem, "torneosToolStripMenuItem");
            this.torneosToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.torneosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Menu;
            this.torneosToolStripMenuItem.Name = "torneosToolStripMenuItem";
            this.torneosToolStripMenuItem.Click += new System.EventHandler(this.torneosToolStripMenuItem_Click);
            // 
            // deportesToolStripMenuItem
            // 
            resources.ApplyResources(this.deportesToolStripMenuItem, "deportesToolStripMenuItem");
            this.deportesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.deportesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Menu;
            this.deportesToolStripMenuItem.Name = "deportesToolStripMenuItem";
            this.deportesToolStripMenuItem.Click += new System.EventHandler(this.deportesToolStripMenuItem_Click);
            // 
            // publicidadToolStripMenuItem
            // 
            resources.ApplyResources(this.publicidadToolStripMenuItem, "publicidadToolStripMenuItem");
            this.publicidadToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.publicidadToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Menu;
            this.publicidadToolStripMenuItem.Name = "publicidadToolStripMenuItem";
            this.publicidadToolStripMenuItem.Click += new System.EventHandler(this.publicidadToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            resources.ApplyResources(this.usuariosToolStripMenuItem, "usuariosToolStripMenuItem");
            this.usuariosToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Menu;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            resources.ApplyResources(this.logoutToolStripMenuItem, "logoutToolStripMenuItem");
            this.logoutToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Menu;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // FrmBackoffice
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBackoffice";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBackoffice_FormClosed);
            this.Load += new System.EventHandler(this.FrmBackoffice_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torneosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jugadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encuentrosToolStripMenuItem;
    }
}