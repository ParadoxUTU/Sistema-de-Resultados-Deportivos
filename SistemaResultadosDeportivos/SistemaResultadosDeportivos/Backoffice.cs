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
    public partial class Backoffice : Form
    {
        public Backoffice()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void FormPadre_Load(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.MdiParent = this;
            usuarios.Show();
        }

        private void publicidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Publicidad publicidad = new Publicidad();
            publicidad.MdiParent = this;
            publicidad.Show();
        }
    }
}
