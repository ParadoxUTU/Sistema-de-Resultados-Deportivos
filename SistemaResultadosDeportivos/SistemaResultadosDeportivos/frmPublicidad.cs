using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADODB;

namespace SistemaResultadosDeportivos
{
    public partial class frmPublicidad : Form
    {
        public ListViewItem lista;

        public frmPublicidad()
        {
            InitializeComponent();
            listarPublicidad();
            lviewPublicidad.FullRowSelect = true;
            this.Dock = DockStyle.Fill;
        }

        private void listarPublicidad()
        {
            lviewPublicidad.Items.Clear();
            try
            {
                lviewPublicidad.Items.Clear();
                ADODB.Connection cn = new ADODB.Connection();
                cn.Open("miodbc", "root", "Veimach0"); //"contraseña" se puede cambiar por la contraseña del portador de la base de datos
                String sql = "SELECT * FROM Publicidad;";
                ADODB.Recordset rs = cn.Execute(sql, out object cantFilas, -1);
                for (int i = 0; i < (int)cantFilas; i++)
                {
                    lista = new ListViewItem(Convert.ToString(rs.Fields[0].Value));
                    lista.SubItems.Add(Convert.ToString(rs.Fields[1].Value));
                    lista.SubItems.Add(Convert.ToString(rs.Fields[2].Value));
                    lista.SubItems.Add(Convert.ToString(rs.Fields[3].Value));
                    lviewPublicidad.Items.Add(lista);
                    rs.MoveNext();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                cn.Open("miodbc", "root", "Veimach0");
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
    }
}

