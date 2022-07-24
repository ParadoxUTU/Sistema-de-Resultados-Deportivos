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
using SistemaResultadosDeportivos.Logica;
using SistemaResultadosDeportivos.Modelos;

namespace SistemaResultadosDeportivos
{
    public partial class Usuarios : Form
    {
        private LogicaUsuarios lg;

        public Usuarios()
        {
            InitializeComponent();
            lg = new LogicaUsuarios();
            this.Dock = DockStyle.Fill;
            listarUsuarios();
            lviewUsuarios.FullRowSelect = true;
        }

        private void listarUsuarios()
        {
            lviewUsuarios.Items.Clear();
            List<Usuario> l = lg.devolverUsuarios();
            if (l.Count > 0)
            {
                foreach (Usuario us in l)
                {
                    ListViewItem item = new ListViewItem(us.correo);
                    item.SubItems.Add(us.nombre);
                    item.SubItems.Add(us.rol.ToString());
                    lviewUsuarios.Items.Add(item);
                }
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            string correo = txtEmail.Text;
            string contrasena = txtContrasena.Text;
            int rol = 0;
            string username = txtUsername.Text;
            try
            {
                rol = short.Parse(txtRol.Text);
            }
            catch
            {
                MessageBox.Show("Tipo de dato no valido, reemplazado por 0.");
            }

            if (rol != 0 && rol != 1)
            {
                MessageBox.Show("Las opciones son: 0 para aficionado, 1 para administrador");
            }
            else if (lg.registrarUsuario(correo, username, contrasena, rol))
            {
                listarUsuarios();
                txtEmail.Text = null;
                txtContrasena.Text = null;
                txtRol.Text = null;
                txtUsername.Text = null;
            }
            else
            {
                MessageBox.Show("No se ha podido agregar el usuario");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (lviewUsuarios.SelectedItems.Count > 0)
            {
                string correo = lviewUsuarios.SelectedItems[0].Text;
                if (lg.bajaUsuario(correo))
                {
                    listarUsuarios();
                }
                else
                {
                    MessageBox.Show("No se ha podido eliminar el usuario");
                }
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (lviewUsuarios.SelectedItems != null)
                {
                    String nombre = Microsoft.VisualBasic.Interaction.InputBox("Nombre del Usuario:", "Modificar Usuario");
                    int rol;
                    int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Rol:", "Modificar Usuario"), out rol);
                    String correo = lviewUsuarios.SelectedItems[0].Text;
                    if(rol == 0 || rol == 1)
                    {
                        if (lg.modificarUsuario(correo, nombre, rol))
                        {
                            listarUsuarios();
                        }
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

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
