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
            string urlBanner = txtUrlBanner.Text;
            string urlSitio = txtUrlSitio.Text;
            try
            {
                ADODB.Connection cn = new ADODB.Connection();
                cn.Open("miodbc", "root", "");
                String sql = "INSERT INTO Publicidad (Marca, PathBanner, URLSitio) VALUES('" + marca + "', '" + urlBanner + "', '" + urlSitio + "');";
                cn.Execute(sql, out object cantFilas, -1);
                cn.Close();
                listarPublicidad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = lviewPublicidad.SelectedItems[0].Text;
            try
            {
                ADODB.Connection cn = new ADODB.Connection();
                cn.Open("miodbc", "root", "Veimach0");
                String sql = "DELETE FROM Publicidad WHERE idPublicidad = '" + id + "';";
                cn.Execute(sql, out object cantFilas, -1);
                cn.Close();
                listarPublicidad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                    ADODB.Connection cn = new ADODB.Connection();
                    cn.Open("miodbc", "root", "Veimach0");
                    String sql = "UPDATE Publicidad SET marca = '" + marca + "', PathBanner = '" + urlBanner + "', URLSitio = '" + urlSitio +"' WHERE IdPublicidad = '" + id + "';";
                    cn.Execute(sql, out object cantFilas, -1);
                    cn.Close();
                    listarPublicidad();
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

