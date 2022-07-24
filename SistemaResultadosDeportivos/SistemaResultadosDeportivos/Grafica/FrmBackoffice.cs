using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaResultadosDeportivos
{
    public partial class FrmBackoffice : Form
    {
        public FrmBackoffice()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void FormPadre_Load(object sender, EventArgs e)
        {
            ABMUsuarios usuarios = new ABMUsuarios();
            usuarios.MdiParent = this;
            usuarios.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.MdiChildren.Count() > 0)
            {
                this.MdiChildren[0].Dispose();
            }
            ABMUsuarios usuarios = new ABMUsuarios();
            usuarios.MdiParent = this;
            usuarios.Show();
        }

        private void publicidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                this.MdiChildren[0].Dispose();
            }
            ABMPublicidad publicidad = new ABMPublicidad();
            publicidad.MdiParent = this;
            publicidad.Show();
        }

        private void FrmBackoffice_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
