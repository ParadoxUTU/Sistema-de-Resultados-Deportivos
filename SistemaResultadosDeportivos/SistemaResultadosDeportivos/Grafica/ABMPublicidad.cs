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
    public partial class ABMPublicidad : Form
    {
        public LogicaPublicidad lg;

        public ABMPublicidad()
        {
            InitializeComponent();
            lg = new LogicaPublicidad();
            this.Dock = DockStyle.Fill;
            listarPublicidad();
            lviewPublicidad.FullRowSelect = true;
        }

        private void listarPublicidad()
        {
            lviewPublicidad.Items.Clear();
            List<Publicidad> l = lg.devolverPublicidades();
            if(l != null)
            {
                foreach (Publicidad pb in l)
                {
                    ListViewItem item = new ListViewItem(pb.idPublicidad.ToString());
                    item.SubItems.Add(pb.marca);
                    item.SubItems.Add(pb.pathBanner);
                    item.SubItems.Add(pb.urlSitio);
                    lviewPublicidad.Items.Add(item);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            string pathBanner = txtUrlBanner.Text;
            string urlSitio = txtUrlSitio.Text;
            if(!marca.Equals("") && !pathBanner.Equals("") && !urlSitio.Equals(""))
            {
                if (lg.agregarPublicidad(marca, pathBanner, urlSitio))
                {
                    listarPublicidad();
                }
            }
            else
            {
                MessageBox.Show("No se ha podido agregar la publicidad");
            }
            limpiarTextos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lviewPublicidad.SelectedItems.Count > 0)
            {
                string id = lviewPublicidad.SelectedItems[0].Text;
                if (lg.eliminarPublicidad(id))
                {
                    listarPublicidad();
                }
                else
                {
                    MessageBox.Show("No se ha podido eliminar la publicidad.");
                }
            }
            else
            {
                MessageBox.Show("No se ha publicidad seleccionada.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lviewPublicidad.SelectedItems.Count == 1)
                {
                    String marca = Microsoft.VisualBasic.Interaction.InputBox("Nombre de Marca:", "Modificar Publicidad");
                    String urlBanner = Microsoft.VisualBasic.Interaction.InputBox("Ruta del Banner:", "Modificar Publicidad");
                    String urlSitio = Microsoft.VisualBasic.Interaction.InputBox("Ruta del Sitio:", "Modificar Publicidad");
                    int id;
                    bool exito = int.TryParse(lviewPublicidad.SelectedItems[0].Text, out id);
                    if (!marca.Equals("") && !urlBanner.Equals("") && !urlSitio.Equals("") && exito)
                    {
                        if (lg.modificarPublicidad(id, marca, urlBanner, urlSitio))
                        {
                            listarPublicidad();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Datos invalidos.");
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

        private void limpiarTextos()
        {
            txtMarca.Text = null;
            txtUrlBanner.Text = null;
            txtUrlSitio.Text = null;
        }

        private void Publicidad_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void ABMPublicidad_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

