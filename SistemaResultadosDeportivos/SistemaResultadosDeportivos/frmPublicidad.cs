using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaResultadosDeportivos.Modelos;
using ADODB;

namespace SistemaResultadosDeportivos
{
    public partial class frmPublicidad : Form
    {
        public LogicaPublicidad lg;

        public frmPublicidad()
        {
            InitializeComponent();
            lg = new LogicaPublicidad();
            listarPublicidad();
            lviewPublicidad.FullRowSelect = true;
            this.Dock = DockStyle.Fill;
        }

        private void listarPublicidad()
        {
            lviewPublicidad.Items.Clear();
            List<Publicidad> l = lg.devolverPublicidades();
            foreach (Publicidad pb in l)
            {
                ListViewItem item = new ListViewItem(pb.idPublicidad.ToString());
                item.SubItems.Add(pb.marca);
                item.SubItems.Add(pb.pathBanner);
                item.SubItems.Add(pb.urlSitio);
                lviewPublicidad.Items.Add(item);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            string pathBanner = txtUrlBanner.Text;
            string urlSitio = txtUrlSitio.Text;
            if (lg.agregarPublicidad(marca, pathBanner, urlSitio))
            {
                listarPublicidad();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = lviewPublicidad.SelectedItems[0].Text;
            if (lg.eliminarPublicidad(id))
            {
                listarPublicidad();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lviewPublicidad.SelectedItems != null)
                {
                    String marca = Microsoft.VisualBasic.Interaction.InputBox("Nombre de Marca:", "Modificar Publicidad");
                    String urlBanner = Microsoft.VisualBasic.Interaction.InputBox("Ruta del Banner:", "Modificar Publicidad");
                    String urlSitio = Microsoft.VisualBasic.Interaction.InputBox("Ruta del Sitio:", "Modificar Publicidad");
                    String id = lviewPublicidad.SelectedItems[0].Text;
                    if(lg.modificarPublicidad(id, marca, urlBanner, urlSitio))
                    {
                        listarPublicidad();
                    }
                }
                else
                {
                    MessageBox.Show("No hay publicidad seleccionada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Publicidad_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmPublicidad_Load(object sender, EventArgs e)
        {

        }
    }
}

