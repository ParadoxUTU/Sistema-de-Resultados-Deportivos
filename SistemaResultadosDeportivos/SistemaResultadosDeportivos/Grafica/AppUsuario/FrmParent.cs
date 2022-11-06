using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaResultadosDeportivos.APIs;
using SistemaResultadosDeportivos.Modelos;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.IO;

namespace SistemaResultadosDeportivos
{
    public partial class FrmParent : Form
    {
        Deporte deporte;

        public FrmParent(Deporte deporte)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.deporte = deporte;
            if (!deporte.porEquipos) 
            {
                menuStrip1.Items[1].Visible = false;
            }
        }

        private void encuentrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                this.MdiChildren[0].Dispose();
            }
            FrmEncuentrosDeporteApp encuentros = new FrmEncuentrosDeporteApp(deporte);
            encuentros.MdiParent = this;
            encuentros.Show();
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                this.MdiChildren[0].Dispose();
            }
            FrmEquiposDeporteApp equipos = new FrmEquiposDeporteApp(deporte);
            equipos.MdiParent = this;
            equipos.Show();
        }

        private void torneosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                this.MdiChildren[0].Dispose();
            }
            FrmTorneosDeporteApp torneos = new FrmTorneosDeporteApp(deporte);
            torneos.MdiParent = this;
            torneos.Show();
        }

        private void jugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                this.MdiChildren[0].Dispose();
            }
            FrmJugadoresDeporteApp jugadores = new FrmJugadoresDeporteApp(deporte);
            jugadores.MdiParent = this;
            jugadores.Show();
        }
    }
}
